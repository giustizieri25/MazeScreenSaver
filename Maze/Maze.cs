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
        internal MazeCell[][] Cells { get; }


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

            this.Cells = new MazeCell[height][];
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
