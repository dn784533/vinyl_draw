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
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblPixelInfo = new System.Windows.Forms.Label();
            this.lblSampleInfo = new System.Windows.Forms.Label();
            this.lblSamplesPerPixel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trkSamplesPerPixel = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBytesPerRow = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
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
            this.lblDuration = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLPcm)).BeginInit();
            this.grpDiscData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSamplesPerPixel)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.cmdCreateWAVData.Location = new System.Drawing.Point(11, 499);
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
            this.trkStartRadiusCm.Location = new System.Drawing.Point(91, 23);
            this.trkStartRadiusCm.Maximum = 35;
            this.trkStartRadiusCm.Name = "trkStartRadiusCm";
            this.trkStartRadiusCm.Size = new System.Drawing.Size(192, 45);
            this.trkStartRadiusCm.TabIndex = 1;
            this.trkStartRadiusCm.Value = 10;
            this.trkStartRadiusCm.Scroll += new System.EventHandler(this.trkStartRadiusCm_Scroll);
            // 
            // trkEndRadiusCm
            // 
            this.trkEndRadiusCm.Location = new System.Drawing.Point(91, 77);
            this.trkEndRadiusCm.Maximum = 30;
            this.trkEndRadiusCm.Name = "trkEndRadiusCm";
            this.trkEndRadiusCm.Size = new System.Drawing.Size(190, 45);
            this.trkEndRadiusCm.SmallChange = 2;
            this.trkEndRadiusCm.TabIndex = 2;
            this.trkEndRadiusCm.Value = 18;
            this.trkEndRadiusCm.Scroll += new System.EventHandler(this.trkEndRadiusCm_Scroll);
            // 
            // lblStartRadiusCm
            // 
            this.lblStartRadiusCm.AutoSize = true;
            this.lblStartRadiusCm.Location = new System.Drawing.Point(302, 36);
            this.lblStartRadiusCm.Name = "lblStartRadiusCm";
            this.lblStartRadiusCm.Size = new System.Drawing.Size(35, 13);
            this.lblStartRadiusCm.TabIndex = 10;
            this.lblStartRadiusCm.Text = "label1";
            // 
            // lblEndRadiusCm
            // 
            this.lblEndRadiusCm.AutoSize = true;
            this.lblEndRadiusCm.Location = new System.Drawing.Point(301, 90);
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
            this.lbxSpeedRPM.Location = new System.Drawing.Point(437, 36);
            this.lbxSpeedRPM.Name = "lbxSpeedRPM";
            this.lbxSpeedRPM.Size = new System.Drawing.Size(132, 121);
            this.lbxSpeedRPM.TabIndex = 20;
            this.lbxSpeedRPM.SelectedIndexChanged += new System.EventHandler(this.lbxSpeedRPM_SelectedIndexChanged);
            // 
            // trkLPcm
            // 
            this.trkLPcm.Location = new System.Drawing.Point(91, 131);
            this.trkLPcm.Maximum = 100;
            this.trkLPcm.Minimum = 20;
            this.trkLPcm.Name = "trkLPcm";
            this.trkLPcm.Size = new System.Drawing.Size(190, 45);
            this.trkLPcm.SmallChange = 2;
            this.trkLPcm.TabIndex = 3;
            this.trkLPcm.Value = 72;
            this.trkLPcm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Groove pitch";
            // 
            // lblLPcm
            // 
            this.lblLPcm.AutoSize = true;
            this.lblLPcm.Location = new System.Drawing.Point(301, 144);
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
            this.lblProcessingEnded.Size = new System.Drawing.Size(309, 13);
            this.lblProcessingEnded.TabIndex = 31;
            this.lblProcessingEnded.Text = "The WAV data has been generated successfully. File duration is";
            // 
            // grpDiscData
            // 
            this.grpDiscData.Controls.Add(this.pnlPreview);
            this.grpDiscData.Controls.Add(this.lblPixelInfo);
            this.grpDiscData.Controls.Add(this.lblSampleInfo);
            this.grpDiscData.Controls.Add(this.lblSamplesPerPixel);
            this.grpDiscData.Controls.Add(this.label7);
            this.grpDiscData.Controls.Add(this.label1);
            this.grpDiscData.Controls.Add(this.trkSamplesPerPixel);
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
            this.grpDiscData.Size = new System.Drawing.Size(854, 248);
            this.grpDiscData.TabIndex = 4;
            this.grpDiscData.TabStop = false;
            this.grpDiscData.Text = "Disc Cutting Parameters";
            // 
            // pnlPreview
            // 
            this.pnlPreview.Location = new System.Drawing.Point(618, 23);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(216, 216);
            this.pnlPreview.TabIndex = 70;
            this.pnlPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPreview_Paint);
            // 
            // lblPixelInfo
            // 
            this.lblPixelInfo.AutoSize = true;
            this.lblPixelInfo.Location = new System.Drawing.Point(301, 217);
            this.lblPixelInfo.Name = "lblPixelInfo";
            this.lblPixelInfo.Size = new System.Drawing.Size(35, 13);
            this.lblPixelInfo.TabIndex = 68;
            this.lblPixelInfo.Text = "label2";
            // 
            // lblSampleInfo
            // 
            this.lblSampleInfo.AutoSize = true;
            this.lblSampleInfo.Location = new System.Drawing.Point(434, 160);
            this.lblSampleInfo.Name = "lblSampleInfo";
            this.lblSampleInfo.Size = new System.Drawing.Size(35, 13);
            this.lblSampleInfo.TabIndex = 49;
            this.lblSampleInfo.Text = "label2";
            // 
            // lblSamplesPerPixel
            // 
            this.lblSamplesPerPixel.AutoSize = true;
            this.lblSamplesPerPixel.Location = new System.Drawing.Point(301, 198);
            this.lblSamplesPerPixel.Name = "lblSamplesPerPixel";
            this.lblSamplesPerPixel.Size = new System.Drawing.Size(35, 13);
            this.lblSamplesPerPixel.TabIndex = 67;
            this.lblSamplesPerPixel.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Turntable RPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Samples / pixel";
            // 
            // trkSamplesPerPixel
            // 
            this.trkSamplesPerPixel.LargeChange = 2;
            this.trkSamplesPerPixel.Location = new System.Drawing.Point(91, 185);
            this.trkSamplesPerPixel.Maximum = 40;
            this.trkSamplesPerPixel.Minimum = 1;
            this.trkSamplesPerPixel.Name = "trkSamplesPerPixel";
            this.trkSamplesPerPixel.Size = new System.Drawing.Size(192, 45);
            this.trkSamplesPerPixel.TabIndex = 65;
            this.trkSamplesPerPixel.Value = 20;
            this.trkSamplesPerPixel.Scroll += new System.EventHandler(this.trkSamplesPerPixel_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBytesPerRow);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.lblRowsReversed);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.lblColoursInPalette);
            this.groupBox1.Controls.Add(this.lblVertRes);
            this.groupBox1.Controls.Add(this.lblHorizRes);
            this.groupBox1.Controls.Add(this.lblImageSize);
            this.groupBox1.Controls.Add(this.lblCompression);
            this.groupBox1.Controls.Add(this.lblBitsPerPx);
            this.groupBox1.Controls.Add(this.lblColourPlanes);
            this.groupBox1.Controls.Add(this.lblHeightPx);
            this.groupBox1.Controls.Add(this.lblWidthPx);
            this.groupBox1.Controls.Add(this.lblDibHeaderLength);
            this.groupBox1.Controls.Add(this.lblBmpOffset);
            this.groupBox1.Controls.Add(this.lblFileLength);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 150);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMP File Details";
            // 
            // lblBytesPerRow
            // 
            this.lblBytesPerRow.AutoSize = true;
            this.lblBytesPerRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytesPerRow.Location = new System.Drawing.Point(763, 97);
            this.lblBytesPerRow.Name = "lblBytesPerRow";
            this.lblBytesPerRow.Size = new System.Drawing.Size(11, 13);
            this.lblBytesPerRow.TabIndex = 94;
            this.lblBytesPerRow.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(647, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 93;
            this.label23.Text = "Bytes per Row";
            // 
            // lblRowsReversed
            // 
            this.lblRowsReversed.AutoSize = true;
            this.lblRowsReversed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowsReversed.Location = new System.Drawing.Point(316, 121);
            this.lblRowsReversed.Name = "lblRowsReversed";
            this.lblRowsReversed.Size = new System.Drawing.Size(11, 13);
            this.lblRowsReversed.TabIndex = 92;
            this.lblRowsReversed.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(211, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 91;
            this.label22.Text = "Rows Reversed";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(111, 25);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(10, 13);
            this.lblFileName.TabIndex = 90;
            this.lblFileName.Text = "-";
            // 
            // lblColoursInPalette
            // 
            this.lblColoursInPalette.AutoSize = true;
            this.lblColoursInPalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoursInPalette.Location = new System.Drawing.Point(763, 73);
            this.lblColoursInPalette.Name = "lblColoursInPalette";
            this.lblColoursInPalette.Size = new System.Drawing.Size(11, 13);
            this.lblColoursInPalette.TabIndex = 89;
            this.lblColoursInPalette.Text = "-";
            // 
            // lblVertRes
            // 
            this.lblVertRes.AutoSize = true;
            this.lblVertRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVertRes.Location = new System.Drawing.Point(763, 49);
            this.lblVertRes.Name = "lblVertRes";
            this.lblVertRes.Size = new System.Drawing.Size(11, 13);
            this.lblVertRes.TabIndex = 88;
            this.lblVertRes.Text = "-";
            // 
            // lblHorizRes
            // 
            this.lblHorizRes.AutoSize = true;
            this.lblHorizRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizRes.Location = new System.Drawing.Point(562, 121);
            this.lblHorizRes.Name = "lblHorizRes";
            this.lblHorizRes.Size = new System.Drawing.Size(11, 13);
            this.lblHorizRes.TabIndex = 87;
            this.lblHorizRes.Text = "-";
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSize.Location = new System.Drawing.Point(563, 97);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(11, 13);
            this.lblImageSize.TabIndex = 86;
            this.lblImageSize.Text = "-";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompression.Location = new System.Drawing.Point(563, 73);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(11, 13);
            this.lblCompression.TabIndex = 85;
            this.lblCompression.Text = "-";
            // 
            // lblBitsPerPx
            // 
            this.lblBitsPerPx.AutoSize = true;
            this.lblBitsPerPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitsPerPx.Location = new System.Drawing.Point(563, 49);
            this.lblBitsPerPx.Name = "lblBitsPerPx";
            this.lblBitsPerPx.Size = new System.Drawing.Size(11, 13);
            this.lblBitsPerPx.TabIndex = 84;
            this.lblBitsPerPx.Text = "-";
            // 
            // lblColourPlanes
            // 
            this.lblColourPlanes.AutoSize = true;
            this.lblColourPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourPlanes.Location = new System.Drawing.Point(316, 97);
            this.lblColourPlanes.Name = "lblColourPlanes";
            this.lblColourPlanes.Size = new System.Drawing.Size(11, 13);
            this.lblColourPlanes.TabIndex = 83;
            this.lblColourPlanes.Text = "-";
            // 
            // lblHeightPx
            // 
            this.lblHeightPx.AutoSize = true;
            this.lblHeightPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightPx.Location = new System.Drawing.Point(316, 73);
            this.lblHeightPx.Name = "lblHeightPx";
            this.lblHeightPx.Size = new System.Drawing.Size(11, 13);
            this.lblHeightPx.TabIndex = 82;
            this.lblHeightPx.Text = "-";
            // 
            // lblWidthPx
            // 
            this.lblWidthPx.AutoSize = true;
            this.lblWidthPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthPx.Location = new System.Drawing.Point(316, 49);
            this.lblWidthPx.Name = "lblWidthPx";
            this.lblWidthPx.Size = new System.Drawing.Size(11, 13);
            this.lblWidthPx.TabIndex = 81;
            this.lblWidthPx.Text = "-";
            // 
            // lblDibHeaderLength
            // 
            this.lblDibHeaderLength.AutoSize = true;
            this.lblDibHeaderLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDibHeaderLength.Location = new System.Drawing.Point(111, 97);
            this.lblDibHeaderLength.Name = "lblDibHeaderLength";
            this.lblDibHeaderLength.Size = new System.Drawing.Size(11, 13);
            this.lblDibHeaderLength.TabIndex = 80;
            this.lblDibHeaderLength.Text = "-";
            // 
            // lblBmpOffset
            // 
            this.lblBmpOffset.AutoSize = true;
            this.lblBmpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmpOffset.Location = new System.Drawing.Point(111, 73);
            this.lblBmpOffset.Name = "lblBmpOffset";
            this.lblBmpOffset.Size = new System.Drawing.Size(11, 13);
            this.lblBmpOffset.TabIndex = 79;
            this.lblBmpOffset.Text = "-";
            // 
            // lblFileLength
            // 
            this.lblFileLength.AutoSize = true;
            this.lblFileLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLength.Location = new System.Drawing.Point(111, 49);
            this.lblFileLength.Name = "lblFileLength";
            this.lblFileLength.Size = new System.Drawing.Size(11, 13);
            this.lblFileLength.TabIndex = 78;
            this.lblFileLength.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 77;
            this.label21.Text = "File Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(647, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 76;
            this.label20.Text = "Colours in Palette";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(647, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Vertical Resolution";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(446, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Horizontal Resolution";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(446, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Image Size";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(446, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Compression Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Bits per Pixel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "Colour Planes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Height (px)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Width (px)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "DIB Header Length";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Bitmap Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "File Length";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(465, 502);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(16, 15);
            this.lblDuration.TabIndex = 67;
            this.lblDuration.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trkSamplesPerPixel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblSampleInfo;
        private System.Windows.Forms.Label lblPixelInfo;
        private System.Windows.Forms.Label lblSamplesPerPixel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkSamplesPerPixel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBytesPerRow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblRowsReversed;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblFileName;
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
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblDuration;
    }
}

