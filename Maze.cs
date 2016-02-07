using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum MazeDirection
    {
        None,
        Up,
        Right,
        Down,
        Left
    }

    public class Maze
    {
        #region Members

        public int Width { get; set; }
        public int Height { get; set; }

        public MazeCell[][] MazeCells { get; set; }

        #endregion

        #region Private Variables

        private Random random = new Random(DateTime.Now.Millisecond);

        #endregion

        #region Constructors

        public Maze(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            MazeCells = new MazeCell[height][];
            for (int h = 0; h < height; h++)
            {
                MazeCells[h] = new MazeCell[width];
                for (int w = 0; w < width; w++)
                {
                    MazeCells[h][w] = new MazeCell(w, h);
                }
            }

            for (int w = 0; w < this.Width; w++)
            {
                ((List<MazeDirection>)MazeCells[0][w].BuildDirections).Remove(MazeDirection.Up);
                ((List<MazeDirection>)MazeCells[this.Height - 1][w].BuildDirections).Remove(MazeDirection.Down);
            }
            for (int h = 0; h < this.Height; h++)
            {
                ((List<MazeDirection>)MazeCells[h][0].BuildDirections).Remove(MazeDirection.Left);
                ((List<MazeDirection>)MazeCells[h][this.Width - 1].BuildDirections).Remove(MazeDirection.Right);
            }
        }

        #endregion

        #region Public Methods

        public MazeCell GetRandomCell()
        {
            int randomX = random.Next(this.Width);
            int randomY = random.Next(this.Height);
            return this.MazeCells[randomY][randomX];
        }

        public MazeDirection GetRandomDirection(IEnumerable<MazeDirection> directions)
        {
            if (directions.Count() > 0)
            {
                int randomNumber = random.Next(directions.Count());
                return directions.ElementAt(randomNumber);
            }
            else
            {
                throw new Exception();
            }
        }

        public MazeCell AdvanceBuild(MazeCell mazeCell, MazeDirection mazeDirection)
        {
            MazeCell newHead = null;

            if (mazeCell != null)
            {
                switch (mazeDirection)
                {
                    case MazeDirection.Up:
                        newHead = this.MazeCells[mazeCell.Y - 1][mazeCell.X];
                        break;
                    case MazeDirection.Right:
                        newHead = this.MazeCells[mazeCell.Y][mazeCell.X + 1];
                        break;
                    case MazeDirection.Down:
                        newHead = this.MazeCells[mazeCell.Y + 1][mazeCell.X];
                        break;
                    case MazeDirection.Left:
                        newHead = this.MazeCells[mazeCell.Y][mazeCell.X - 1];
                        break;
                }

                ((List<MazeDirection>)mazeCell.BuildDirections).Remove(mazeDirection);
                ((List<MazeDirection>)mazeCell.ExploreDirections).Add(mazeDirection);

                newHead.PreviousBuildCell = mazeCell;
                newHead.PreviousBuildDirection = this.oppositeDirection(mazeDirection);
                newHead.HasPath = true;
                ((List<MazeDirection>)newHead.BuildDirections).Remove(this.oppositeDirection(mazeDirection));
                ((List<MazeDirection>)newHead.ExploreDirections).Add(this.oppositeDirection(mazeDirection));

                if (newHead.Y > 0)
                {
                    MazeCell upCell = this.MazeCells[newHead.Y - 1][newHead.X];
                    if (upCell.HasPath)
                    {
                        ((List<MazeDirection>)newHead.BuildDirections).Remove(MazeDirection.Up);
                        ((List<MazeDirection>)upCell.BuildDirections).Remove(MazeDirection.Down);
                    }
                }

                if (newHead.X < this.Width - 1)
                {
                    MazeCell rightCell = this.MazeCells[newHead.Y][newHead.X + 1];
                    if (rightCell.HasPath)
                    {
                        ((List<MazeDirection>)newHead.BuildDirections).Remove(MazeDirection.Right);
                        ((List<MazeDirection>)rightCell.BuildDirections).Remove(MazeDirection.Left);
                    }
                }

                if (newHead.Y < this.Height - 1)
                {
                    MazeCell downCell = this.MazeCells[newHead.Y + 1][newHead.X];
                    if (downCell.HasPath)
                    {
                        ((List<MazeDirection>)newHead.BuildDirections).Remove(MazeDirection.Down);
                        ((List<MazeDirection>)downCell.BuildDirections).Remove(MazeDirection.Up);
                    }

                }

                if (newHead.X > 0)
                {
                    MazeCell leftCell = this.MazeCells[newHead.Y][newHead.X - 1];
                    if (leftCell.HasPath)
                    {
                        ((List<MazeDirection>)newHead.BuildDirections).Remove(MazeDirection.Left);
                        ((List<MazeDirection>)leftCell.BuildDirections).Remove(MazeDirection.Right);
                    }
                }
            }

            return newHead;
        }

        public MazeCell AdvanceExplore(MazeCell mazeCell, MazeDirection mazeDirection)
        {
            MazeCell newHead = null;

            if (mazeCell != null)
            {
                switch (mazeDirection)
                {
                    case MazeDirection.Up:
                        newHead = this.MazeCells[mazeCell.Y - 1][mazeCell.X];
                        break;
                    case MazeDirection.Right:
                        newHead = this.MazeCells[mazeCell.Y][mazeCell.X + 1];
                        break;
                    case MazeDirection.Down:
                        newHead = this.MazeCells[mazeCell.Y + 1][mazeCell.X];
                        break;
                    case MazeDirection.Left:
                        newHead = this.MazeCells[mazeCell.Y][mazeCell.X - 1];
                        break;
                }

                ((List<MazeDirection>)mazeCell.ExploreDirections).Remove(mazeDirection);
                ((List<MazeDirection>)newHead.ExploreDirections).Remove(this.oppositeDirection(mazeDirection));

                newHead.PreviousExploreCell = mazeCell;
                newHead.PreviousExploreDirection = this.oppositeDirection(mazeDirection);
                newHead.Visited = true;
            }

            return newHead;
        }

        #endregion

        #region Private Methods

        private MazeDirection oppositeDirection(MazeDirection mazeDirection)
        {
            switch (mazeDirection)
            {
                case MazeDirection.Up:
                    return MazeDirection.Down;
                case MazeDirection.Right:
                    return MazeDirection.Left;
                case MazeDirection.Down:
                    return MazeDirection.Up;
                case MazeDirection.Left:
                    return MazeDirection.Right;
            }
            throw new Exception();
        }

        #endregion

        public MazeCell VisitInitialCell
        {
            get
            {
                return this.MazeCells[0][0];
            }
        }

        public MazeCell VisitFinalCell
        {
            get
            {
                return this.MazeCells[this.Height - 1][this.Width - 1];
            }
        }
    }
}
