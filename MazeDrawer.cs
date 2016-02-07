using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MazeDrawer
    {

        #region Members

        public Maze Maze { get; set; }
        public Graphics Graphics { get; set; }

        public int WallSize { get; set; }
        public int PathSize { get; set; }

        public Color WallColor { get; set; }

        public Color BuildColor { get; set; }
        public Color BuildBackColor { get; set; }

        public Color ExploreColor { get; set; }
        public Color ExploreBackColor { get; set; }

        #endregion

        #region Constructors

        public MazeDrawer(Graphics graphics, Maze maze, int pathSize, int wallSize)
        {
            this.Graphics = graphics;
            this.Maze = maze;

            this.PathSize = pathSize;
            this.WallSize = wallSize;

            this.WallColor = Color.Black;
        }

        #endregion

        #region Public Methods

        public void Draw(bool buildBacktrack, bool exploreBacktrack)
        {
            this.Graphics.Clear(this.WallColor);
            //this.Graphics.DrawString(string.Format("{0}x{1}", this.Maze.XSize, this.Maze.YSize), SystemFonts.DefaultFont, Brushes.Black, 0, 0);
            Pen wallPen = new Pen(WallColor, WallSize);
            for (int i = 0; i < this.Maze.Width; i++)
            {
                int x1 = (i + 1) * PathSize + i * WallSize + WallSize / 2;
                int y1 = 0;
                int x2 = (i + 1) * PathSize + i * WallSize + WallSize / 2;
                int y2 = (int)this.Maze.Height * this.PathSize + (this.Maze.Height - 1) * this.WallSize + this.WallSize / 2;
                this.Graphics.DrawLine(wallPen, x1, y1, x2, y2);
            }
            for (int i = 0; i < this.Maze.Height; i++)
            {
                int x1 = 0;
                int y1 = (i + 1) * PathSize + i * WallSize + WallSize / 2;
                int x2 = (int)this.Maze.Width * this.PathSize + (this.Maze.Width - 1) * this.WallSize + this.WallSize / 2;
                int y2 = (i + 1) * PathSize + i * WallSize + WallSize / 2;
                this.Graphics.DrawLine(wallPen, x1, y1, x2, y2);
            }

            for (int w = 0; w < this.Maze.Width; w++)
            {
                for (int h = 0; h < this.Maze.Height; h++)
                {
                    //Rectangle r = this.GetCellRectangle(w, h);
                    //this.Graphics.DrawString(string.Format("{0}", this.Maze.MazeCells[h][w].BuildDirections.Count()), SystemFonts.DefaultFont, SystemBrushes.Desktop, r);

                    MazeCell mazeCell = this.Maze.MazeCells[h][w];
                    if (mazeCell.HasPath)
                    {
                        Color cellColor = this.BuildColor;
                        if (buildBacktrack && mazeCell.HasBacktrackPath)
                        {
                            cellColor = this.BuildBackColor;
                        }
                        if (exploreBacktrack && mazeCell.Visited)
                        {
                            cellColor = this.ExploreColor;
                            if ( mazeCell.VisitedBack)
                            {
                                cellColor = this.ExploreBackColor;
                            }
                        }

                        Rectangle r = this.GetCellRectangle(h, w);
                        this.PaintCell(w, h, cellColor);

                        this.PaintBorder(w, h, mazeCell.PreviousBuildDirection, cellColor);
                    }
                }
            }
        }

        public static void CalculateSize(Graphics graphics, int pathSize, int wallSize, out int width, out int height)
        {
            int grphicsWidth = (int)graphics.VisibleClipBounds.Width;
            int graphicsHeight = (int)graphics.VisibleClipBounds.Height;

            width = 0;
            height = 0;
            int computedSize = 0;
            while (computedSize + pathSize + wallSize < grphicsWidth)
            {
                width++;
                computedSize = (width * pathSize) + (width - 1) * wallSize;
            }

            computedSize = 0;
            while (computedSize + pathSize + wallSize < graphicsHeight)
            {
                height++;
                computedSize = (height * pathSize) + (height - 1) * wallSize;
            }
        }

        public Rectangle GetCellRectangle(int x, int y)
        {
            Rectangle rect = new Rectangle();
            if (x < this.Maze.Width && y < this.Maze.Height)
            {
                int rectX = (int)x * this.PathSize + x * this.WallSize;
                int rectY = (int)y * this.PathSize + y * this.WallSize;
                rect = new Rectangle(rectX, rectY, this.PathSize, this.PathSize);
            }
            return rect;
        }

        public Rectangle GetBorderRectangle(int x, int y, MazeDirection mazeDirection)
        {
            Rectangle rect = this.GetCellRectangle(x, y);
            if (rect != Rectangle.Empty)
            {
                switch (mazeDirection)
                {
                    case MazeDirection.Up:
                        rect.Y -= this.WallSize;
                        rect.Height = this.WallSize;
                        break;
                    case MazeDirection.Right:
                        rect.X += this.PathSize;
                        rect.Width = this.WallSize;
                        break;
                    case MazeDirection.Down:
                        rect.Y += this.PathSize;
                        rect.Height = this.WallSize;
                        break;
                    case MazeDirection.Left:
                        rect.X -= this.WallSize;
                        rect.Width = this.WallSize;
                        break;
                }
            }
            return rect;
        }

        public void PaintBuildForwardCells(MazeCell fromCell, MazeCell toCell, MazeDirection mazeDirection)
        {
            PaintCell(fromCell.X, fromCell.Y, this.BuildColor);
            PaintBorder(fromCell.X, fromCell.Y, mazeDirection, this.BuildColor);
            PaintCell(toCell.X, toCell.Y, this.BuildColor);
        }

        public void PaintBuildForwardCell(MazeCell mazeCell)
        {
            PaintCell(mazeCell.X, mazeCell.Y, this.BuildColor);
        }

        public void PaintCell(int x, int y, Color color)
        {
            Rectangle r = this.GetCellRectangle(x, y);
            if (r != Rectangle.Empty)
            {
                Brush b = new SolidBrush(color);
                this.Graphics.FillRectangle(b, r);
            }
        }

        public void PaintBorder(int x, int y, MazeDirection mazeDirection, Color color)
        {
            Rectangle r = this.GetBorderRectangle(x, y, mazeDirection);
            if (r != Rectangle.Empty)
            {
                Brush b = new SolidBrush(color);
                this.Graphics.FillRectangle(b, r);
            }
        }

        public void PaintBuildBackwardCells(MazeCell fromCell, MazeCell toCell, MazeDirection mazeDirection)
        {
            PaintCell(fromCell.X, fromCell.Y, this.BuildBackColor);
            PaintBorder(fromCell.X, fromCell.Y, mazeDirection, this.BuildBackColor);
            PaintCell(toCell.X, toCell.Y, this.BuildColor);
        }

        public void PaintExploreForwardCells(MazeCell fromCell, MazeCell toCell, MazeDirection mazeDirection)
        {
            PaintCell(fromCell.X, fromCell.Y, this.ExploreColor);
            PaintBorder(fromCell.X, fromCell.Y, mazeDirection, this.ExploreColor);
            PaintCell(toCell.X, toCell.Y, this.ExploreColor);
        }

        public void PaintExploreBackwardCells(MazeCell fromCell, MazeCell toCell, MazeDirection mazeDirection)
        {
            PaintCell(fromCell.X, fromCell.Y, this.ExploreBackColor);
            PaintBorder(fromCell.X, fromCell.Y, mazeDirection, this.ExploreBackColor);
            PaintCell(toCell.X, toCell.Y, this.ExploreBackColor);
        }

        public void GetCellFromCoords(int x, int y)
        {

        }

        #endregion

    }
}
