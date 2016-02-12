using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maze;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        #region Properties

        Maze.Maze Maze;
        MazeDrawer MazeDrawer;
        MazeCell CurrentCell;
        MazeController mazeController;
        ToolTip tooltip = new ToolTip();
        Timer timer = new Timer();
        bool stepping = false;
        int buildCells = 0;
        int backtrakBuildCells = 0;
        int mazeHeight = 0;
        int mazeWidth = 0;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();

            timer.Tick += timer_Tick;
            this.mazeController = new MazeController();
        }

        #endregion

        #region Event Handlers

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.mazeController.CreateMaze ( this.panel1.CreateGraphics(), (int)numericUpDownPathSize.Value, (int)numericUpDownWallSize.Value);
            
        }

        private void buttonStepBuild_Click(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
        }

        void timer_Tick(object sender, EventArgs e)
        {
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
        }

        private void buttonSlow_Click(object sender, EventArgs e)
        {
        }

        private void buttonFast_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
        }

        private void buttonBuildColor_Click(object sender, EventArgs e)
        {
        }

        private void buttonBuildBacktrackColor_Click(object sender, EventArgs e)
        {
        }

        private void buttonUpdateBuild_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Private Methods

        private void doBuildStep(bool fastBacktrack, bool debugBacktrack)
        {
        }

        private void doExploreStep(bool fastBacktrack, bool debugBacktrack)
        {
        }

        #endregion

    }
}
