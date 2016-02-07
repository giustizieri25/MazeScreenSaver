namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownPathSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWallSize = new System.Windows.Forms.NumericUpDown();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonStepBuild = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.labelCells = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonFast = new System.Windows.Forms.Button();
            this.buttonSlow = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelBuiltCells = new System.Windows.Forms.Label();
            this.labelBacktrackBuiltCells = new System.Windows.Forms.Label();
            this.progressBarBuildBacktrack = new System.Windows.Forms.ProgressBar();
            this.progressBarBuildCells = new System.Windows.Forms.ProgressBar();
            this.buttonUpdateBuild = new System.Windows.Forms.Button();
            this.buttonBuildBacktrackColor = new System.Windows.Forms.Button();
            this.buttonBuildColor = new System.Windows.Forms.Button();
            this.checkBoxDebugBuildBacktrack = new System.Windows.Forms.CheckBox();
            this.checkBoxFastBacktrackBuild = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPathSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallSize)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 13);
            label1.TabIndex = 12;
            label1.Text = "Path size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 13;
            label2.Text = "Wall size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(146, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 13);
            label3.TabIndex = 2;
            label3.Text = "Build Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(146, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 13);
            label4.TabIndex = 3;
            label4.Text = "Backtrack Color";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 193);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // numericUpDownPathSize
            // 
            this.numericUpDownPathSize.Location = new System.Drawing.Point(62, 6);
            this.numericUpDownPathSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPathSize.Name = "numericUpDownPathSize";
            this.numericUpDownPathSize.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownPathSize.TabIndex = 3;
            this.numericUpDownPathSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownWallSize
            // 
            this.numericUpDownWallSize.Location = new System.Drawing.Point(62, 32);
            this.numericUpDownWallSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWallSize.Name = "numericUpDownWallSize";
            this.numericUpDownWallSize.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownWallSize.TabIndex = 4;
            this.numericUpDownWallSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(105, 6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(50, 46);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonStepBuild
            // 
            this.buttonStepBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepBuild.Location = new System.Drawing.Point(222, 6);
            this.buttonStepBuild.Name = "buttonStepBuild";
            this.buttonStepBuild.Size = new System.Drawing.Size(43, 20);
            this.buttonStepBuild.TabIndex = 10;
            this.buttonStepBuild.Text = ">";
            this.buttonStepBuild.UseVisualStyleBackColor = true;
            this.buttonStepBuild.Click += new System.EventHandler(this.buttonStepBuild_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(271, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(43, 20);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = ">>";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(173, 6);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(43, 20);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 85);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSkip);
            this.tabPage1.Controls.Add(this.labelCells);
            this.tabPage1.Controls.Add(this.labelSize);
            this.tabPage1.Controls.Add(this.buttonFast);
            this.tabPage1.Controls.Add(this.buttonSlow);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.numericUpDownPathSize);
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.numericUpDownWallSize);
            this.tabPage1.Controls.Add(this.buttonStepBuild);
            this.tabPage1.Controls.Add(this.buttonNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 59);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maze";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkip.Location = new System.Drawing.Point(320, 6);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(43, 20);
            this.buttonSkip.TabIndex = 19;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // labelCells
            // 
            this.labelCells.AutoSize = true;
            this.labelCells.Location = new System.Drawing.Point(368, 34);
            this.labelCells.Name = "labelCells";
            this.labelCells.Size = new System.Drawing.Size(0, 13);
            this.labelCells.TabIndex = 18;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(368, 8);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(0, 13);
            this.labelSize.TabIndex = 17;
            // 
            // buttonFast
            // 
            this.buttonFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFast.Location = new System.Drawing.Point(343, 32);
            this.buttonFast.Name = "buttonFast";
            this.buttonFast.Size = new System.Drawing.Size(20, 20);
            this.buttonFast.TabIndex = 16;
            this.buttonFast.Text = "+";
            this.buttonFast.UseVisualStyleBackColor = true;
            this.buttonFast.Click += new System.EventHandler(this.buttonFast_Click);
            // 
            // buttonSlow
            // 
            this.buttonSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlow.Location = new System.Drawing.Point(173, 32);
            this.buttonSlow.Name = "buttonSlow";
            this.buttonSlow.Size = new System.Drawing.Size(20, 20);
            this.buttonSlow.TabIndex = 16;
            this.buttonSlow.Text = "-";
            this.buttonSlow.UseVisualStyleBackColor = true;
            this.buttonSlow.Click += new System.EventHandler(this.buttonSlow_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(199, 32);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(138, 42);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelBuiltCells);
            this.tabPage2.Controls.Add(this.labelBacktrackBuiltCells);
            this.tabPage2.Controls.Add(this.progressBarBuildBacktrack);
            this.tabPage2.Controls.Add(this.progressBarBuildCells);
            this.tabPage2.Controls.Add(this.buttonUpdateBuild);
            this.tabPage2.Controls.Add(this.buttonBuildBacktrackColor);
            this.tabPage2.Controls.Add(this.buttonBuildColor);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(label3);
            this.tabPage2.Controls.Add(this.checkBoxDebugBuildBacktrack);
            this.tabPage2.Controls.Add(this.checkBoxFastBacktrackBuild);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 59);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Build";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelBuiltCells
            // 
            this.labelBuiltCells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuiltCells.AutoSize = true;
            this.labelBuiltCells.Location = new System.Drawing.Point(303, 7);
            this.labelBuiltCells.Name = "labelBuiltCells";
            this.labelBuiltCells.Size = new System.Drawing.Size(35, 13);
            this.labelBuiltCells.TabIndex = 15;
            this.labelBuiltCells.Text = "label5";
            // 
            // labelBacktrackBuiltCells
            // 
            this.labelBacktrackBuiltCells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBacktrackBuiltCells.AutoSize = true;
            this.labelBacktrackBuiltCells.Location = new System.Drawing.Point(303, 30);
            this.labelBacktrackBuiltCells.Name = "labelBacktrackBuiltCells";
            this.labelBacktrackBuiltCells.Size = new System.Drawing.Size(35, 13);
            this.labelBacktrackBuiltCells.TabIndex = 16;
            this.labelBacktrackBuiltCells.Text = "label6";
            // 
            // progressBarBuildBacktrack
            // 
            this.progressBarBuildBacktrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBuildBacktrack.BackColor = System.Drawing.Color.Black;
            this.progressBarBuildBacktrack.Location = new System.Drawing.Point(280, 26);
            this.progressBarBuildBacktrack.Name = "progressBarBuildBacktrack";
            this.progressBarBuildBacktrack.Size = new System.Drawing.Size(17, 20);
            this.progressBarBuildBacktrack.TabIndex = 8;
            // 
            // progressBarBuildCells
            // 
            this.progressBarBuildCells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBuildCells.BackColor = System.Drawing.Color.Black;
            this.progressBarBuildCells.Location = new System.Drawing.Point(280, 3);
            this.progressBarBuildCells.Name = "progressBarBuildCells";
            this.progressBarBuildCells.Size = new System.Drawing.Size(17, 20);
            this.progressBarBuildCells.TabIndex = 7;
            // 
            // buttonUpdateBuild
            // 
            this.buttonUpdateBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateBuild.Location = new System.Drawing.Point(455, 6);
            this.buttonUpdateBuild.Name = "buttonUpdateBuild";
            this.buttonUpdateBuild.Size = new System.Drawing.Size(50, 46);
            this.buttonUpdateBuild.TabIndex = 6;
            this.buttonUpdateBuild.Text = "Update";
            this.buttonUpdateBuild.UseVisualStyleBackColor = true;
            this.buttonUpdateBuild.Click += new System.EventHandler(this.buttonUpdateBuild_Click);
            // 
            // buttonBuildBacktrackColor
            // 
            this.buttonBuildBacktrackColor.Location = new System.Drawing.Point(242, 26);
            this.buttonBuildBacktrackColor.Name = "buttonBuildBacktrackColor";
            this.buttonBuildBacktrackColor.Size = new System.Drawing.Size(20, 20);
            this.buttonBuildBacktrackColor.TabIndex = 5;
            this.buttonBuildBacktrackColor.UseVisualStyleBackColor = true;
            this.buttonBuildBacktrackColor.Click += new System.EventHandler(this.buttonBuildBacktrackColor_Click);
            // 
            // buttonBuildColor
            // 
            this.buttonBuildColor.Location = new System.Drawing.Point(242, 3);
            this.buttonBuildColor.Name = "buttonBuildColor";
            this.buttonBuildColor.Size = new System.Drawing.Size(20, 20);
            this.buttonBuildColor.TabIndex = 4;
            this.buttonBuildColor.UseVisualStyleBackColor = true;
            this.buttonBuildColor.Click += new System.EventHandler(this.buttonBuildColor_Click);
            // 
            // checkBoxDebugBuildBacktrack
            // 
            this.checkBoxDebugBuildBacktrack.AutoSize = true;
            this.checkBoxDebugBuildBacktrack.Location = new System.Drawing.Point(6, 29);
            this.checkBoxDebugBuildBacktrack.Name = "checkBoxDebugBuildBacktrack";
            this.checkBoxDebugBuildBacktrack.Size = new System.Drawing.Size(110, 17);
            this.checkBoxDebugBuildBacktrack.TabIndex = 1;
            this.checkBoxDebugBuildBacktrack.Text = "Debug Backtrack";
            this.checkBoxDebugBuildBacktrack.UseVisualStyleBackColor = true;
            // 
            // checkBoxFastBacktrackBuild
            // 
            this.checkBoxFastBacktrackBuild.AutoSize = true;
            this.checkBoxFastBacktrackBuild.Location = new System.Drawing.Point(6, 6);
            this.checkBoxFastBacktrackBuild.Name = "checkBoxFastBacktrackBuild";
            this.checkBoxFastBacktrackBuild.Size = new System.Drawing.Size(98, 17);
            this.checkBoxFastBacktrackBuild.TabIndex = 0;
            this.checkBoxFastBacktrackBuild.Text = "Fast Backtrack";
            this.checkBoxFastBacktrackBuild.UseVisualStyleBackColor = true;
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            this.colorDialog.SolidColorOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 308);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPathSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallSize)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownPathSize;
        private System.Windows.Forms.NumericUpDown numericUpDownWallSize;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonStepBuild;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonFast;
        private System.Windows.Forms.Button buttonSlow;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCells;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.CheckBox checkBoxFastBacktrackBuild;
        private System.Windows.Forms.CheckBox checkBoxDebugBuildBacktrack;
        private System.Windows.Forms.Button buttonBuildBacktrackColor;
        private System.Windows.Forms.Button buttonBuildColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonUpdateBuild;
        private System.Windows.Forms.ProgressBar progressBarBuildCells;
        private System.Windows.Forms.ProgressBar progressBarBuildBacktrack;
        private System.Windows.Forms.Label labelBuiltCells;
        private System.Windows.Forms.Label labelBacktrackBuiltCells;
    }
}

