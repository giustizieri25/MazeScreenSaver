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


        #endregion

    }
}
