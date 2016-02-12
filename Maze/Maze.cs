using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{

    public class Maze
    {
        #region Members

        public int Heigth { get; set; }
        public int Width { get; set; }

        public readonly int MazeSize;
        public MazeCell[][] Cells { get; }
        public int CellsCount { get; private set; }
        public bool Completed
        {
            get
            {
                return this.CellsCount == this.MazeSize;
            }
        }

        #endregion

        #region Private Variables

        private Random random = new Random(DateTime.Now.Millisecond);
        private MazeCell currentCell;

        #endregion

        #region Constructors

        public Maze(int height, int width)
        {
            if (height == 0)
            {
                throw new ArgumentException("Invalid size", "height");
            }
            if (width == 0)
            {
                throw new ArgumentException("Invalid size", "width");
            }

            this.Heigth = height;
            this.Width = width;
            this.MazeSize = height * width;

            for (int h = 0; h < this.Heigth; h++)
            {
                this.Cells[h] = new MazeCell[width];
                for (int w = 0; w < this.Width; w++)
                {
                    this.Cells[h][w] = null;
                }
            }
        }

        #endregion

        #region Events


        public event EventHandler<CellCreatedEventArgs> CellCreated;

        #endregion

        #region Public Methods

        public void CreateCell()
        {
            if ( ! this.Completed )
            {
                MazeCell mc = new MazeCell();

                if ( this.currentCell == null )
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
                    this.CellCreated(this, new CellCreatedEventArgs() { Cell = mc } );
                }
            }
        }

        #endregion

        #region Private Methods

        #endregion

    }

    public class CellCreatedEventArgs : EventArgs
    {
        public MazeCell Cell { get; set; }
    }
}
