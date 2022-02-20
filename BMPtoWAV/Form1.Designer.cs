namespace VinylDraw
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCreateWAVData = new System.Windows.Forms.Button();
            this.trkStartRadiusCm = new System.Windows.Forms.TrackBar();
            this.trkEndRadiusCm = new System.Windows.Forms.TrackBar();
            this.lblStartRadiusCm = new System.Windows.Forms.Label();
            this.lblEndRadiusCm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxSpeedRPM = new System.Windows.Forms.ListBox();
            this.trkLPcm = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLPcm = new System.Windows.Forms.Label();
            this.prgCreate = new System.Windows.Forms.ProgressBar();
            this.lblProcessingEnded = new System.Windows.Forms.Label();
            this.grpDiscData = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRowsReversed = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblColoursInPalette = new System.Windows.Forms.Label();
            this.lblVertRes = new System.Windows.Forms.Label();
            this.lblHorizRes = new System.Windows.Forms.Label();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.lblCompression = new System.Windows.Forms.Label();
            this.lblBitsPerPx = new System.Windows.Forms.Label();
            this.lblColourPlanes = new System.Windows.Forms.Label();
            this.lblHeightPx = new System.Windows.Forms.Label();
            this.lblWidthPx = new System.Windows.Forms.Label();
            this.lblDibHeaderLength = new System.Windows.Forms.Label();
            this.lblBmpOffset = new System.Windows.Forms.Label();
            this.lblFileLength = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.trkRfreq = new System.Windows.Forms.TrackBar();
            this.trkGfreq = new System.Windows.Forms.TrackBar();
            this.trkBfreq = new System.Windows.Forms.TrackBar();
            this.lblBpcent = new System.Windows.Forms.Label();
            this.lblRfreq = new System.Windows.Forms.Label();
            this.lblGpcent = new System.Windows.Forms.Label();
            this.lblStepsPerRev = new System.Windows.Forms.Label();
            this.lblGfreq = new System.Windows.Forms.Label();
            this.lblRpcent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBfreq = new System.Windows.Forms.Label();
            this.trkStepsPerRev = new System.Windows.Forms.TrackBar();
            this.trkBpcent = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trkGpcent = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trkRpcent = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBytesPerRow = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLPcm)).BeginInit();
            this.grpDiscData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStepsPerRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBpcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGpcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRpcent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openToolStripMenuItem.Text = "&Open BMP...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "&Save WAV...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmdCreateWAVData
            // 
            this.cmdCreateWAVData.Location = new System.Drawing.Point(15, 499);
            this.cmdCreateWAVData.Name = "cmdCreateWAVData";
            this.cmdCreateWAVData.Size = new System.Drawing.Size(106, 23);
            this.cmdCreateWAVData.TabIndex = 12;
            this.cmdCreateWAVData.Text = "Create WAV data";
            this.cmdCreateWAVData.UseVisualStyleBackColor = true;
            this.cmdCreateWAVData.Click += new System.EventHandler(this.button1_Click);
            // 
            // trkStartRadiusCm
            // 
            this.trkStartRadiusCm.LargeChange = 4;
            this.trkStartRadiusCm.Location = new System.Drawing.Point(87, 27);
            this.trkStartRadiusCm.Maximum = 35;
            this.trkStartRadiusCm.Name = "trkStartRadiusCm";
            this.trkStartRadiusCm.Size = new System.Drawing.Size(178, 45);
            this.trkStartRadiusCm.TabIndex = 1;
            this.trkStartRadiusCm.Value = 10;
            this.trkStartRadiusCm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkEndRadiusCm
            // 
            this.trkEndRadiusCm.Location = new System.Drawing.Point(87, 78);
            this.trkEndRadiusCm.Maximum = 30;
            this.trkEndRadiusCm.Name = "trkEndRadiusCm";
            this.trkEndRadiusCm.Size = new System.Drawing.Size(176, 45);
            this.trkEndRadiusCm.SmallChange = 2;
            this.trkEndRadiusCm.TabIndex = 2;
            this.trkEndRadiusCm.Value = 18;
            this.trkEndRadiusCm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // lblStartRadiusCm
            // 
            this.lblStartRadiusCm.AutoSize = true;
            this.lblStartRadiusCm.Location = new System.Drawing.Point(286, 39);
            this.lblStartRadiusCm.Name = "lblStartRadiusCm";
            this.lblStartRadiusCm.Size = new System.Drawing.Size(35, 13);
            this.lblStartRadiusCm.TabIndex = 10;
            this.lblStartRadiusCm.Text = "label1";
            // 
            // lblEndRadiusCm
            // 
            this.lblEndRadiusCm.AutoSize = true;
            this.lblEndRadiusCm.Location = new System.Drawing.Point(283, 90);
            this.lblEndRadiusCm.Name = "lblEndRadiusCm";
            this.lblEndRadiusCm.Size = new System.Drawing.Size(35, 13);
            this.lblEndRadiusCm.TabIndex = 11;
            this.lblEndRadiusCm.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "End Radius";
            // 
            // lbxSpeedRPM
            // 
            this.lbxSpeedRPM.FormattingEnabled = true;
            this.lbxSpeedRPM.Location = new System.Drawing.Point(403, 39);
            this.lbxSpeedRPM.Name = "lbxSpeedRPM";
            this.lbxSpeedRPM.Size = new System.Drawing.Size(132, 95);
            this.lbxSpeedRPM.TabIndex = 20;
            this.lbxSpeedRPM.SelectedIndexChanged += new System.EventHandler(this.lbxSpeedRPM_SelectedIndexChanged);
            // 
            // trkLPcm
            // 
            this.trkLPcm.Location = new System.Drawing.Point(87, 132);
            this.trkLPcm.Maximum = 100;
            this.trkLPcm.Minimum = 20;
            this.trkLPcm.Name = "trkLPcm";
            this.trkLPcm.Size = new System.Drawing.Size(176, 45);
            this.trkLPcm.SmallChange = 2;
            this.trkLPcm.TabIndex = 3;
            this.trkLPcm.Value = 72;
            this.trkLPcm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lines / cm";
            // 
            // lblLPcm
            // 
            this.lblLPcm.AutoSize = true;
            this.lblLPcm.Location = new System.Drawing.Point(283, 143);
            this.lblLPcm.Name = "lblLPcm";
            this.lblLPcm.Size = new System.Drawing.Size(35, 13);
            this.lblLPcm.TabIndex = 23;
            this.lblLPcm.Text = "label2";
            // 
            // prgCreate
            // 
            this.prgCreate.Location = new System.Drawing.Point(158, 504);
            this.prgCreate.Name = "prgCreate";
            this.prgCreate.Size = new System.Drawing.Size(316, 18);
            this.prgCreate.TabIndex = 30;
            // 
            // lblProcessingEnded
            // 
            this.lblProcessingEnded.AutoSize = true;
            this.lblProcessingEnded.Location = new System.Drawing.Point(155, 504);
            this.lblProcessingEnded.Name = "lblProcessingEnded";
            this.lblProcessingEnded.Size = new System.Drawing.Size(14, 13);
            this.lblProcessingEnded.TabIndex = 31;
            this.lblProcessingEnded.Text = "X";
            // 
            // grpDiscData
            // 
            this.grpDiscData.Controls.Add(this.label7);
            this.grpDiscData.Controls.Add(this.trkEndRadiusCm);
            this.grpDiscData.Controls.Add(this.trkStartRadiusCm);
            this.grpDiscData.Controls.Add(this.lblStartRadiusCm);
            this.grpDiscData.Controls.Add(this.lblEndRadiusCm);
            this.grpDiscData.Controls.Add(this.label4);
            this.grpDiscData.Controls.Add(this.label5);
            this.grpDiscData.Controls.Add(this.lbxSpeedRPM);
            this.grpDiscData.Controls.Add(this.trkLPcm);
            this.grpDiscData.Controls.Add(this.label6);
            this.grpDiscData.Controls.Add(this.lblLPcm);
            this.grpDiscData.Location = new System.Drawing.Point(12, 27);
            this.grpDiscData.Name = "grpDiscData";
            this.grpDiscData.Size = new System.Drawing.Size(683, 187);
            this.grpDiscData.TabIndex = 4;
            this.grpDiscData.TabStop = false;
            this.grpDiscData.Text = "Disc Cutting Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Turntable RPM";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 220);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 273);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblBytesPerRow);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.lblRowsReversed);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.lblFileName);
            this.tabPage1.Controls.Add(this.lblColoursInPalette);
            this.tabPage1.Controls.Add(this.lblVertRes);
            this.tabPage1.Controls.Add(this.lblHorizRes);
            this.tabPage1.Controls.Add(this.lblImageSize);
            this.tabPage1.Controls.Add(this.lblCompression);
            this.tabPage1.Controls.Add(this.lblBitsPerPx);
            this.tabPage1.Controls.Add(this.lblColourPlanes);
            this.tabPage1.Controls.Add(this.lblHeightPx);
            this.tabPage1.Controls.Add(this.lblWidthPx);
            this.tabPage1.Controls.Add(this.lblDibHeaderLength);
            this.tabPage1.Controls.Add(this.lblBmpOffset);
            this.tabPage1.Controls.Add(this.lblFileLength);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BMP File Details";
            // 
            // lblRowsReversed
            // 
            this.lblRowsReversed.AutoSize = true;
            this.lblRowsReversed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsReversed.Location = new System.Drawing.Point(113, 188);
            this.lblRowsReversed.Name = "lblRowsReversed";
            this.lblRowsReversed.Size = new System.Drawing.Size(11, 13);
            this.lblRowsReversed.TabIndex = 27;
            this.lblRowsReversed.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 188);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Rows Reversed";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(113, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(10, 13);
            this.lblFileName.TabIndex = 25;
            this.lblFileName.Text = "-";
            // 
            // lblColoursInPalette
            // 
            this.lblColoursInPalette.AutoSize = true;
            this.lblColoursInPalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoursInPalette.Location = new System.Drawing.Point(396, 164);
            this.lblColoursInPalette.Name = "lblColoursInPalette";
            this.lblColoursInPalette.Size = new System.Drawing.Size(11, 13);
            this.lblColoursInPalette.TabIndex = 24;
            this.lblColoursInPalette.Text = "-";
            // 
            // lblVertRes
            // 
            this.lblVertRes.AutoSize = true;
            this.lblVertRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVertRes.Location = new System.Drawing.Point(396, 140);
            this.lblVertRes.Name = "lblVertRes";
            this.lblVertRes.Size = new System.Drawing.Size(11, 13);
            this.lblVertRes.TabIndex = 23;
            this.lblVertRes.Text = "-";
            // 
            // lblHorizRes
            // 
            this.lblHorizRes.AutoSize = true;
            this.lblHorizRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizRes.Location = new System.Drawing.Point(396, 116);
            this.lblHorizRes.Name = "lblHorizRes";
            this.lblHorizRes.Size = new System.Drawing.Size(11, 13);
            this.lblHorizRes.TabIndex = 22;
            this.lblHorizRes.Text = "-";
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSize.Location = new System.Drawing.Point(397, 92);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(11, 13);
            this.lblImageSize.TabIndex = 21;
            this.lblImageSize.Text = "-";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompression.Location = new System.Drawing.Point(397, 68);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(11, 13);
            this.lblCompression.TabIndex = 20;
            this.lblCompression.Text = "-";
            // 
            // lblBitsPerPx
            // 
            this.lblBitsPerPx.AutoSize = true;
            this.lblBitsPerPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitsPerPx.Location = new System.Drawing.Point(397, 44);
            this.lblBitsPerPx.Name = "lblBitsPerPx";
            this.lblBitsPerPx.Size = new System.Drawing.Size(11, 13);
            this.lblBitsPerPx.TabIndex = 19;
            this.lblBitsPerPx.Text = "-";
            // 
            // lblColourPlanes
            // 
            this.lblColourPlanes.AutoSize = true;
            this.lblColourPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourPlanes.Location = new System.Drawing.Point(113, 164);
            this.lblColourPlanes.Name = "lblColourPlanes";
            this.lblColourPlanes.Size = new System.Drawing.Size(11, 13);
            this.lblColourPlanes.TabIndex = 18;
            this.lblColourPlanes.Text = "-";
            // 
            // lblHeightPx
            // 
            this.lblHeightPx.AutoSize = true;
            this.lblHeightPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightPx.Location = new System.Drawing.Point(113, 140);
            this.lblHeightPx.Name = "lblHeightPx";
            this.lblHeightPx.Size = new System.Drawing.Size(11, 13);
            this.lblHeightPx.TabIndex = 17;
            this.lblHeightPx.Text = "-";
            // 
            // lblWidthPx
            // 
            this.lblWidthPx.AutoSize = true;
            this.lblWidthPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthPx.Location = new System.Drawing.Point(113, 116);
            this.lblWidthPx.Name = "lblWidthPx";
            this.lblWidthPx.Size = new System.Drawing.Size(11, 13);
            this.lblWidthPx.TabIndex = 16;
            this.lblWidthPx.Text = "-";
            // 
            // lblDibHeaderLength
            // 
            this.lblDibHeaderLength.AutoSize = true;
            this.lblDibHeaderLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDibHeaderLength.Location = new System.Drawing.Point(113, 92);
            this.lblDibHeaderLength.Name = "lblDibHeaderLength";
            this.lblDibHeaderLength.Size = new System.Drawing.Size(11, 13);
            this.lblDibHeaderLength.TabIndex = 15;
            this.lblDibHeaderLength.Text = "-";
            // 
            // lblBmpOffset
            // 
            this.lblBmpOffset.AutoSize = true;
            this.lblBmpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmpOffset.Location = new System.Drawing.Point(113, 68);
            this.lblBmpOffset.Name = "lblBmpOffset";
            this.lblBmpOffset.Size = new System.Drawing.Size(11, 13);
            this.lblBmpOffset.TabIndex = 14;
            this.lblBmpOffset.Text = "-";
            // 
            // lblFileLength
            // 
            this.lblFileLength.AutoSize = true;
            this.lblFileLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLength.Location = new System.Drawing.Point(113, 44);
            this.lblFileLength.Name = "lblFileLength";
            this.lblFileLength.Size = new System.Drawing.Size(11, 13);
            this.lblFileLength.TabIndex = 13;
            this.lblFileLength.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "File Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Colours in Palette";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(280, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Vertical Resolution";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Horizontal Resolution";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Image Size";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Compression Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Bits per Pixel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Colour Planes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Height (px)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Width (px)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "DIB Header Length";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Bitmap Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Length";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.trkRfreq);
            this.tabPage2.Controls.Add(this.trkGfreq);
            this.tabPage2.Controls.Add(this.trkBfreq);
            this.tabPage2.Controls.Add(this.lblBpcent);
            this.tabPage2.Controls.Add(this.lblRfreq);
            this.tabPage2.Controls.Add(this.lblGpcent);
            this.tabPage2.Controls.Add(this.lblStepsPerRev);
            this.tabPage2.Controls.Add(this.lblGfreq);
            this.tabPage2.Controls.Add(this.lblRpcent);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblBfreq);
            this.tabPage2.Controls.Add(this.trkStepsPerRev);
            this.tabPage2.Controls.Add(this.trkBpcent);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.trkGpcent);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.trkRpcent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resolution and Colours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Red";
            // 
            // trkRfreq
            // 
            this.trkRfreq.LargeChange = 2;
            this.trkRfreq.Location = new System.Drawing.Point(68, 61);
            this.trkRfreq.Maximum = 20;
            this.trkRfreq.Minimum = 1;
            this.trkRfreq.Name = "trkRfreq";
            this.trkRfreq.Size = new System.Drawing.Size(192, 45);
            this.trkRfreq.TabIndex = 6;
            this.trkRfreq.Value = 20;
            this.trkRfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkGfreq
            // 
            this.trkGfreq.LargeChange = 2;
            this.trkGfreq.Location = new System.Drawing.Point(68, 112);
            this.trkGfreq.Maximum = 20;
            this.trkGfreq.Minimum = 1;
            this.trkGfreq.Name = "trkGfreq";
            this.trkGfreq.Size = new System.Drawing.Size(192, 45);
            this.trkGfreq.TabIndex = 7;
            this.trkGfreq.Value = 20;
            this.trkGfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkBfreq
            // 
            this.trkBfreq.LargeChange = 2;
            this.trkBfreq.Location = new System.Drawing.Point(68, 163);
            this.trkBfreq.Maximum = 20;
            this.trkBfreq.Minimum = 1;
            this.trkBfreq.Name = "trkBfreq";
            this.trkBfreq.Size = new System.Drawing.Size(192, 45);
            this.trkBfreq.TabIndex = 8;
            this.trkBfreq.Value = 20;
            this.trkBfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // lblBpcent
            // 
            this.lblBpcent.AutoSize = true;
            this.lblBpcent.Location = new System.Drawing.Point(555, 175);
            this.lblBpcent.Name = "lblBpcent";
            this.lblBpcent.Size = new System.Drawing.Size(35, 13);
            this.lblBpcent.TabIndex = 47;
            this.lblBpcent.Text = "label1";
            // 
            // lblRfreq
            // 
            this.lblRfreq.AutoSize = true;
            this.lblRfreq.Location = new System.Drawing.Point(280, 70);
            this.lblRfreq.Name = "lblRfreq";
            this.lblRfreq.Size = new System.Drawing.Size(35, 13);
            this.lblRfreq.TabIndex = 33;
            this.lblRfreq.Text = "label1";
            // 
            // lblGpcent
            // 
            this.lblGpcent.AutoSize = true;
            this.lblGpcent.Location = new System.Drawing.Point(555, 124);
            this.lblGpcent.Name = "lblGpcent";
            this.lblGpcent.Size = new System.Drawing.Size(35, 13);
            this.lblGpcent.TabIndex = 46;
            this.lblGpcent.Text = "label1";
            // 
            // lblStepsPerRev
            // 
            this.lblStepsPerRev.AutoSize = true;
            this.lblStepsPerRev.Location = new System.Drawing.Point(279, 15);
            this.lblStepsPerRev.Name = "lblStepsPerRev";
            this.lblStepsPerRev.Size = new System.Drawing.Size(35, 13);
            this.lblStepsPerRev.TabIndex = 44;
            this.lblStepsPerRev.Text = "label2";
            // 
            // lblGfreq
            // 
            this.lblGfreq.AutoSize = true;
            this.lblGfreq.Location = new System.Drawing.Point(280, 124);
            this.lblGfreq.Name = "lblGfreq";
            this.lblGfreq.Size = new System.Drawing.Size(35, 13);
            this.lblGfreq.TabIndex = 34;
            this.lblGfreq.Text = "label2";
            // 
            // lblRpcent
            // 
            this.lblRpcent.AutoSize = true;
            this.lblRpcent.Location = new System.Drawing.Point(555, 70);
            this.lblRpcent.Name = "lblRpcent";
            this.lblRpcent.Size = new System.Drawing.Size(35, 13);
            this.lblRpcent.TabIndex = 45;
            this.lblRpcent.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Steps / rev";
            // 
            // lblBfreq
            // 
            this.lblBfreq.AutoSize = true;
            this.lblBfreq.Location = new System.Drawing.Point(280, 175);
            this.lblBfreq.Name = "lblBfreq";
            this.lblBfreq.Size = new System.Drawing.Size(35, 13);
            this.lblBfreq.TabIndex = 35;
            this.lblBfreq.Text = "label3";
            // 
            // trkStepsPerRev
            // 
            this.trkStepsPerRev.LargeChange = 1;
            this.trkStepsPerRev.Location = new System.Drawing.Point(71, 15);
            this.trkStepsPerRev.Maximum = 4;
            this.trkStepsPerRev.Minimum = 1;
            this.trkStepsPerRev.Name = "trkStepsPerRev";
            this.trkStepsPerRev.Size = new System.Drawing.Size(189, 45);
            this.trkStepsPerRev.TabIndex = 5;
            this.trkStepsPerRev.Value = 2;
            this.trkStepsPerRev.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkBpcent
            // 
            this.trkBpcent.Location = new System.Drawing.Point(375, 163);
            this.trkBpcent.Maximum = 100;
            this.trkBpcent.Name = "trkBpcent";
            this.trkBpcent.Size = new System.Drawing.Size(174, 45);
            this.trkBpcent.TabIndex = 11;
            this.trkBpcent.Scroll += new System.EventHandler(this.trkBpcent_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Green";
            // 
            // trkGpcent
            // 
            this.trkGpcent.Location = new System.Drawing.Point(375, 112);
            this.trkGpcent.Maximum = 100;
            this.trkGpcent.Name = "trkGpcent";
            this.trkGpcent.Size = new System.Drawing.Size(174, 45);
            this.trkGpcent.TabIndex = 10;
            this.trkGpcent.Scroll += new System.EventHandler(this.trkGpcent_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Blue";
            // 
            // trkRpcent
            // 
            this.trkRpcent.Location = new System.Drawing.Point(375, 61);
            this.trkRpcent.Maximum = 100;
            this.trkRpcent.Name = "trkRpcent";
            this.trkRpcent.Size = new System.Drawing.Size(174, 45);
            this.trkRpcent.TabIndex = 9;
            this.trkRpcent.Scroll += new System.EventHandler(this.trkRpcent_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(280, 188);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Bytes per Row";
            // 
            // lblBytesPerRow
            // 
            this.lblBytesPerRow.AutoSize = true;
            this.lblBytesPerRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytesPerRow.Location = new System.Drawing.Point(396, 188);
            this.lblBytesPerRow.Name = "lblBytesPerRow";
            this.lblBytesPerRow.Size = new System.Drawing.Size(11, 13);
            this.lblBytesPerRow.TabIndex = 29;
            this.lblBytesPerRow.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpDiscData);
            this.Controls.Add(this.lblProcessingEnded);
            this.Controls.Add(this.prgCreate);
            this.Controls.Add(this.cmdCreateWAVData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vinyl Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRadiusCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRadiusCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLPcm)).EndInit();
            this.grpDiscData.ResumeLayout(false);
            this.grpDiscData.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStepsPerRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBpcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGpcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRpcent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button cmdCreateWAVData;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TrackBar trkStartRadiusCm;
        private System.Windows.Forms.TrackBar trkEndRadiusCm;
        private System.Windows.Forms.Label lblStartRadiusCm;
        private System.Windows.Forms.Label lblEndRadiusCm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxSpeedRPM;
        private System.Windows.Forms.TrackBar trkLPcm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLPcm;
        private System.Windows.Forms.ProgressBar prgCreate;
        private System.Windows.Forms.Label lblProcessingEnded;
        private System.Windows.Forms.GroupBox grpDiscData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkRfreq;
        private System.Windows.Forms.TrackBar trkGfreq;
        private System.Windows.Forms.TrackBar trkBfreq;
        private System.Windows.Forms.Label lblBpcent;
        private System.Windows.Forms.Label lblRfreq;
        private System.Windows.Forms.Label lblGpcent;
        private System.Windows.Forms.Label lblStepsPerRev;
        private System.Windows.Forms.Label lblGfreq;
        private System.Windows.Forms.Label lblRpcent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBfreq;
        private System.Windows.Forms.TrackBar trkStepsPerRev;
        private System.Windows.Forms.TrackBar trkBpcent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkGpcent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkRpcent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblColoursInPalette;
        private System.Windows.Forms.Label lblVertRes;
        private System.Windows.Forms.Label lblHorizRes;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblCompression;
        private System.Windows.Forms.Label lblBitsPerPx;
        private System.Windows.Forms.Label lblColourPlanes;
        private System.Windows.Forms.Label lblHeightPx;
        private System.Windows.Forms.Label lblWidthPx;
        private System.Windows.Forms.Label lblDibHeaderLength;
        private System.Windows.Forms.Label lblBmpOffset;
        private System.Windows.Forms.Label lblFileLength;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblRowsReversed;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblBytesPerRow;
        private System.Windows.Forms.Label label23;
    }
}

