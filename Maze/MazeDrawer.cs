using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
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

        public MazeDrawer(Maze maze)
        {
            this.Maze = maze;

            this.Maze.CellCreated += Maze_CellCreated;
        }

        private void Maze_CellCreated(object sender, CellCreatedEventArgs e)
        {
            
        }

        #endregion

        #region Public Methods

        public static Size CalculateSize(Graphics graphics, int pathSize, int wallSize)
        {
            Size size = new Size();

            int grphicsWidth = (int)graphics.VisibleClipBounds.Width;
            int graphicsHeight = (int)graphics.VisibleClipBounds.Height;

            int computedSize = 0;
            while (computedSize + pathSize + wallSize < grphicsWidth)
            {
                size.Width++;
                computedSize = (size.Width * pathSize) + (size.Width - 1) * wallSize;
            }

            computedSize = 0;
            while (computedSize + pathSize + wallSize < graphicsHeight)
            {
                size.Height++;
                computedSize = (size.Height * pathSize) + (size.Height - 1) * wallSize;
            }

            return size;
        }

        #endregion

    }
}
