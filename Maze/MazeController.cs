using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class MazeController
    {
        private Maze maze;
        private MazeDrawer mazeDrawer;
        public int CellsCount { get; private set; }
        internal bool MazeComplete
        {
            get
            {
                return this.CellsCount == this.maze.MazeSize;
            }
        }

        public void CreateMaze(Graphics graphics, int pathSize, int wallSize)
        {
            Size size = MazeDrawer.CalculateSize(graphics, pathSize, wallSize);
            this.maze = new Maze(size.Height, size.Width);
            this.CellsCount = 0;
        }

        public void CreateCell()
        {
            if (!this.MazeComplete)
            {
                MazeCell mc = new MazeCell();

                if (this.currentCell == null)
                {
                    int randomHeight = this.random.Next(this.Heigth);
                    int randomWidth = this.random.Next(this.Width);
                }
                else
                {
                    // append to current head
                }

                if (this.CellCreated != null)
                {
                    this.CellCreated(this, new CellCreatedEventArgs() { Cell = mc });
                }
            }
        }
    }
}
