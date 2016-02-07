using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        #region Properties

        Maze Maze;
        MazeDrawer MazeDrawer;
        MazeCell CurrentCell;
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
        }

        #endregion

        #region Event Handlers

        private void buttonNew_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MazeDrawer.CalculateSize(this.panel1.CreateGraphics(), (int)numericUpDownPathSize.Value, (int)numericUpDownWallSize.Value, out this.mazeWidth, out this.mazeHeight);
            this.Maze = new Maze(this.mazeHeight, this.mazeWidth);
            this.MazeDrawer = new MazeDrawer(this.panel1.CreateGraphics(), this.Maze, (int)numericUpDownPathSize.Value, (int)numericUpDownWallSize.Value);
            this.MazeDrawer.BuildColor = this.buttonBuildColor.BackColor;
            this.MazeDrawer.BuildBackColor = this.buttonBuildBacktrackColor.BackColor;
            this.MazeDrawer.ExploreColor = Color.Red;
            this.MazeDrawer.ExploreBackColor = Color.Yellow;
            this.MazeDrawer.Draw(false, false);
            this.CurrentCell = null;

            this.panel1.BackColor = this.MazeDrawer.WallColor;
            this.labelSize.Text = string.Format("{0} x {1} maze", this.mazeHeight, this.mazeWidth);
            this.labelCells.Text = string.Format("{0} steps", this.mazeHeight * this.mazeWidth);
            this.buildCells = 0;
            this.backtrakBuildCells = 0;
            this.progressBarBuildCells.Maximum = this.mazeHeight * this.mazeWidth;
            this.progressBarBuildBacktrack.Maximum = this.buildCells;
            this.labelBuiltCells.Text = string.Format("{0} / {1} (0% / {2})", this.buildCells, this.mazeWidth * this.mazeHeight, this.buildCells - this.mazeWidth * this.mazeHeight);
            this.labelBacktrackBuiltCells.Text = string.Format("{0} / {1} (0% / {2})", this.backtrakBuildCells, this.buildCells, this.backtrakBuildCells - this.buildCells);
        }

        private void buttonStepBuild_Click(object sender, EventArgs e)
        {
            if (this.buildCells < this.mazeHeight * this.mazeWidth)
            {
                doBuildStep(checkBoxFastBacktrackBuild.Checked, checkBoxDebugBuildBacktrack.Checked);
                this.progressBarBuildCells.Value = this.buildCells;
                this.progressBarBuildBacktrack.Value = this.backtrakBuildCells;
                this.progressBarBuildBacktrack.Maximum = this.buildCells;
                if (this.buildCells == this.mazeWidth * this.mazeHeight)
                {
                    this.timer.Stop();
                    this.MazeDrawer.Draw(false, false);
                    this.CurrentCell = null;
                }
            }
            else if (this.CurrentCell != this.Maze.VisitFinalCell)
            {
                doExploreStep(true, true);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MazeDrawer != null)
            {
                int x = e.X / (this.MazeDrawer.PathSize + this.MazeDrawer.WallSize);
                int y = e.Y / (this.MazeDrawer.PathSize + this.MazeDrawer.WallSize);

                if (e.X < x * (this.MazeDrawer.PathSize + this.MazeDrawer.WallSize) + this.MazeDrawer.PathSize &&
                     e.Y < y * (this.MazeDrawer.PathSize + this.MazeDrawer.WallSize) + this.MazeDrawer.PathSize)
                {
                    tooltip.Show(this.Maze.MazeCells[y][x].ToString(), this, e.X + this.panel1.Bounds.X, e.Y + this.panel1.Bounds.Y);
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tooltip.Hide(this);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Interval = 1001 - this.trackBar1.Value;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (this.buildCells < this.mazeHeight * this.mazeWidth)
            {
                doBuildStep(checkBoxFastBacktrackBuild.Checked, checkBoxDebugBuildBacktrack.Checked);
                this.progressBarBuildCells.Value = this.buildCells;
                this.progressBarBuildBacktrack.Value = this.backtrakBuildCells;
                this.progressBarBuildBacktrack.Maximum = this.buildCells;
                if (this.buildCells == this.mazeWidth * this.mazeHeight)
                {
                    this.timer.Stop();
                    this.MazeDrawer.Draw(false, false);
                    this.CurrentCell = null;
                }
            }
            else if ( this.CurrentCell != this.Maze.VisitFinalCell )
            {
                doExploreStep(true, true);
            }
            this.timer.Interval = 1001 - this.trackBar1.Value;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void buttonSlow_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value - this.trackBar1.LargeChange > 0)
            {
                this.trackBar1.Value -= this.trackBar1.LargeChange;
            }
            else
            {
                this.trackBar1.Value = this.trackBar1.Minimum;
            }

            this.buttonSlow.Enabled = this.trackBar1.Value != this.trackBar1.Minimum;
            this.buttonFast.Enabled = true;
        }

        private void buttonFast_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value < this.trackBar1.Maximum - this.trackBar1.LargeChange)
            {
                if (this.trackBar1.Value + this.trackBar1.LargeChange > this.trackBar1.Maximum - this.trackBar1.LargeChange)
                {
                    this.trackBar1.Value = this.trackBar1.Maximum - this.trackBar1.LargeChange;
                }
                else
                {
                    this.trackBar1.Value += this.trackBar1.LargeChange;
                }
            }
            else
            {
                if (this.trackBar1.Value + this.trackBar1.SmallChange < this.trackBar1.Maximum)
                {
                    this.trackBar1.Value += this.trackBar1.SmallChange;
                }
                else
                {
                    this.trackBar1.Value = this.trackBar1.Maximum;
                }
            }

            this.buttonFast.Enabled = this.trackBar1.Value != this.trackBar1.Maximum;
            this.buttonSlow.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            bool timerEnabled = timer.Enabled;
            if (timerEnabled)
            {
                timer.Enabled = false;
            }
            if (this.MazeDrawer != null)
            {
                bool buildComplete = this.buildCells == this.mazeHeight * this.mazeWidth;
                if (!buildComplete)
                {
                    this.MazeDrawer.Draw(checkBoxDebugBuildBacktrack.Checked, false);
                }
                else
                {
                    this.MazeDrawer.Draw(false, true);
                }
            }
            if (timerEnabled)
            {
                timer.Enabled = true;
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            timer.Stop();
            while (this.buildCells < this.mazeHeight * this.mazeWidth)
            {
                doBuildStep(true, false);
                this.progressBarBuildCells.Value = this.buildCells;
                this.progressBarBuildBacktrack.Value = this.backtrakBuildCells;
                this.progressBarBuildBacktrack.Maximum = this.buildCells;
            }
            this.timer.Stop();
            this.MazeDrawer.Draw(false, false);
            this.CurrentCell = null;
        }

        private void buttonBuildColor_Click(object sender, EventArgs e)
        {
            if (this.MazeDrawer != null && this.MazeDrawer.BuildColor != null)
            {
                colorDialog.Color = this.MazeDrawer.BuildColor;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonBuildColor.BackColor = colorDialog.Color;
                progressBarBuildCells.ForeColor = colorDialog.Color;
                progressBarBuildBacktrack.BackColor = colorDialog.Color;
                if (this.MazeDrawer != null)
                {
                    this.MazeDrawer.BuildColor = colorDialog.Color;
                }
            }
        }

        private void buttonBuildBacktrackColor_Click(object sender, EventArgs e)
        {
            if (this.MazeDrawer != null && this.MazeDrawer.BuildBackColor != null)
            {
                colorDialog.Color = this.MazeDrawer.BuildBackColor;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonBuildBacktrackColor.BackColor = colorDialog.Color;
                progressBarBuildBacktrack.ForeColor = colorDialog.Color;
                if (this.MazeDrawer != null)
                {
                    this.MazeDrawer.BuildBackColor = colorDialog.Color;
                }
            }
        }

        private void buttonUpdateBuild_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
        }

        #endregion

        #region Private Methods

        private void doBuildStep(bool fastBacktrack, bool debugBacktrack)
        {
            if (!stepping && this.Maze != null && this.MazeDrawer != null && this.buildCells < this.mazeHeight * this.mazeWidth)
            {
                stepping = true;
                if (this.CurrentCell != null)
                {
                    if (this.CurrentCell.CanContinueBuild)
                    {
                        MazeDirection mazeDirection = this.Maze.GetRandomDirection(this.CurrentCell.BuildDirections);
                        MazeCell newCell = this.Maze.AdvanceBuild(this.CurrentCell, mazeDirection);
                        this.MazeDrawer.PaintBuildForwardCells(this.CurrentCell, newCell, mazeDirection);
                        this.CurrentCell = newCell;
                        this.buildCells++;
                        this.labelBuiltCells.Text = string.Format("{0} / {1} ({2}% / {3})", this.buildCells, this.mazeWidth * this.mazeHeight, (int)(100 * this.buildCells / (this.mazeWidth * this.mazeHeight)), this.buildCells - this.mazeWidth * this.mazeHeight);
                        this.labelBacktrackBuiltCells.Text = string.Format("{0} / {1} ({2}% / {3})", this.backtrakBuildCells, this.buildCells, (int)(100 * this.backtrakBuildCells / this.buildCells), this.backtrakBuildCells - this.buildCells);
                    }
                    else
                    {
                        Action stepBack = () =>
                        {
                            this.CurrentCell.HasBacktrackPath = true;
                            MazeDirection mazeDirection = this.CurrentCell.PreviousBuildDirection;
                            if (debugBacktrack)
                            {
                                this.MazeDrawer.PaintBuildBackwardCells(this.CurrentCell, this.CurrentCell.PreviousBuildCell, this.CurrentCell.PreviousBuildDirection);
                            }
                            this.CurrentCell = this.CurrentCell.PreviousBuildCell;
                            this.backtrakBuildCells++;
                            this.labelBacktrackBuiltCells.Text = string.Format("{0} / {1} ({2}% / {3})", this.backtrakBuildCells, this.buildCells, (int)(100 * this.backtrakBuildCells / this.buildCells), this.backtrakBuildCells - this.buildCells);
                        };

                        if (fastBacktrack)
                        {
                            while (!this.CurrentCell.CanContinueBuild && this.CurrentCell.PreviousBuildCell != null)
                            {
                                stepBack();
                            }
                        }
                        else
                        {
                            if (this.CurrentCell.PreviousBuildCell != null)
                            {
                                stepBack();
                            }
                        }
                    }
                }
                else
                {
                    this.CurrentCell = this.Maze.GetRandomCell();
                    this.CurrentCell.HasPath = true;
                    this.MazeDrawer.PaintCell(this.CurrentCell.X, this.CurrentCell.Y, this.MazeDrawer.BuildColor);
                    this.buildCells++;
                    this.labelBuiltCells.Text = string.Format("{0} / {1} ({2}% / {3})", this.buildCells, this.mazeWidth * this.mazeHeight, (int)(100 * this.buildCells / (this.mazeWidth * this.mazeHeight)), this.buildCells - this.mazeWidth * this.mazeHeight);
                    this.labelBacktrackBuiltCells.Text = string.Format("{0} / {1} ({2}% / {3})", this.backtrakBuildCells, this.buildCells, (int)(100 * this.backtrakBuildCells / this.buildCells), this.backtrakBuildCells - this.buildCells);
                }
                stepping = false;
            }
        }

        private void doExploreStep(bool fastBacktrack, bool debugBacktrack)
        {
            if (!stepping && this.CurrentCell != this.Maze.VisitFinalCell)
            {
                stepping = true;

                if (this.CurrentCell != null)
                {
                    if (this.CurrentCell.CanContinueExplore)
                    {
                        MazeDirection mazeDirection = this.Maze.GetRandomDirection(this.CurrentCell.ExploreDirections);
                        MazeCell newCell = this.Maze.AdvanceExplore(this.CurrentCell, mazeDirection);
                        this.MazeDrawer.PaintExploreForwardCells(this.CurrentCell, newCell, mazeDirection);
                        this.CurrentCell = newCell;
                    }
                    else
                    {
                        Action stepBack = () =>
                        {
                            this.CurrentCell.VisitedBack = true;
                            MazeDirection mazeDirection = this.CurrentCell.PreviousBuildDirection;
                            if (debugBacktrack)
                            {
                                this.MazeDrawer.PaintExploreBackwardCells(this.CurrentCell, this.CurrentCell.PreviousExploreCell, this.CurrentCell.PreviousExploreDirection);
                            }
                            this.CurrentCell = this.CurrentCell.PreviousExploreCell;
                        };

                        if (fastBacktrack)
                        {
                            while (!this.CurrentCell.CanContinueExplore)
                            {
                                stepBack();
                            }
                        }
                        else
                        {
                            stepBack();
                        }
                    }
                }
                else
                {
                    this.CurrentCell = this.Maze.VisitInitialCell;
                    this.CurrentCell.Visited = true;
                    this.MazeDrawer.PaintCell(this.CurrentCell.X, this.CurrentCell.Y, this.MazeDrawer.ExploreColor);
                }

                stepping = false;
            }
        }

        #endregion

    }
}
