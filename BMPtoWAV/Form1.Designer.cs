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
            this.trkRfreq = new System.Windows.Forms.TrackBar();
            this.trkGfreq = new System.Windows.Forms.TrackBar();
            this.trkBfreq = new System.Windows.Forms.TrackBar();
            this.lblRfreq = new System.Windows.Forms.Label();
            this.lblGfreq = new System.Windows.Forms.Label();
            this.lblBfreq = new System.Windows.Forms.Label();
            this.trkStartRadiusCm = new System.Windows.Forms.TrackBar();
            this.trkEndRadiusCm = new System.Windows.Forms.TrackBar();
            this.lblStartRadiusCm = new System.Windows.Forms.Label();
            this.lblEndRadiusCm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trkRpcent = new System.Windows.Forms.TrackBar();
            this.trkGpcent = new System.Windows.Forms.TrackBar();
            this.trkBpcent = new System.Windows.Forms.TrackBar();
            this.lbxSpeedRPM = new System.Windows.Forms.ListBox();
            this.trkLPcm = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLPcm = new System.Windows.Forms.Label();
            this.lblAnglePStep = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trkAnglePStep = new System.Windows.Forms.TrackBar();
            this.lblRpcent = new System.Windows.Forms.Label();
            this.lblGpcent = new System.Windows.Forms.Label();
            this.lblBpcent = new System.Windows.Forms.Label();
            this.prgCreate = new System.Windows.Forms.ProgressBar();
            this.lblProcessingEnded = new System.Windows.Forms.Label();
            this.grpDiscData = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpColourData = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRadiusCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRpcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGpcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBpcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnglePStep)).BeginInit();
            this.grpDiscData.SuspendLayout();
            this.grpColourData.SuspendLayout();
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open BMP...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save WAV...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmdCreateWAVData
            // 
            this.cmdCreateWAVData.Location = new System.Drawing.Point(15, 480);
            this.cmdCreateWAVData.Name = "cmdCreateWAVData";
            this.cmdCreateWAVData.Size = new System.Drawing.Size(106, 23);
            this.cmdCreateWAVData.TabIndex = 1;
            this.cmdCreateWAVData.Text = "Create WAV data";
            this.cmdCreateWAVData.UseVisualStyleBackColor = true;
            this.cmdCreateWAVData.Click += new System.EventHandler(this.button1_Click);
            // 
            // trkRfreq
            // 
            this.trkRfreq.Location = new System.Drawing.Point(71, 76);
            this.trkRfreq.Maximum = 5000;
            this.trkRfreq.Minimum = 250;
            this.trkRfreq.Name = "trkRfreq";
            this.trkRfreq.Size = new System.Drawing.Size(192, 45);
            this.trkRfreq.TabIndex = 2;
            this.trkRfreq.Value = 250;
            this.trkRfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkGfreq
            // 
            this.trkGfreq.Location = new System.Drawing.Point(71, 127);
            this.trkGfreq.Maximum = 5000;
            this.trkGfreq.Minimum = 250;
            this.trkGfreq.Name = "trkGfreq";
            this.trkGfreq.Size = new System.Drawing.Size(192, 45);
            this.trkGfreq.TabIndex = 3;
            this.trkGfreq.Value = 250;
            this.trkGfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkBfreq
            // 
            this.trkBfreq.Location = new System.Drawing.Point(71, 178);
            this.trkBfreq.Maximum = 5000;
            this.trkBfreq.Minimum = 250;
            this.trkBfreq.Name = "trkBfreq";
            this.trkBfreq.Size = new System.Drawing.Size(192, 45);
            this.trkBfreq.TabIndex = 4;
            this.trkBfreq.Value = 250;
            this.trkBfreq.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // lblRfreq
            // 
            this.lblRfreq.AutoSize = true;
            this.lblRfreq.Location = new System.Drawing.Point(283, 85);
            this.lblRfreq.Name = "lblRfreq";
            this.lblRfreq.Size = new System.Drawing.Size(35, 13);
            this.lblRfreq.TabIndex = 5;
            this.lblRfreq.Text = "label1";
            // 
            // lblGfreq
            // 
            this.lblGfreq.AutoSize = true;
            this.lblGfreq.Location = new System.Drawing.Point(283, 139);
            this.lblGfreq.Name = "lblGfreq";
            this.lblGfreq.Size = new System.Drawing.Size(35, 13);
            this.lblGfreq.TabIndex = 6;
            this.lblGfreq.Text = "label2";
            // 
            // lblBfreq
            // 
            this.lblBfreq.AutoSize = true;
            this.lblBfreq.Location = new System.Drawing.Point(283, 190);
            this.lblBfreq.Name = "lblBfreq";
            this.lblBfreq.Size = new System.Drawing.Size(35, 13);
            this.lblBfreq.TabIndex = 7;
            this.lblBfreq.Text = "label3";
            // 
            // trkStartRadiusCm
            // 
            this.trkStartRadiusCm.LargeChange = 4;
            this.trkStartRadiusCm.Location = new System.Drawing.Point(87, 27);
            this.trkStartRadiusCm.Maximum = 35;
            this.trkStartRadiusCm.Name = "trkStartRadiusCm";
            this.trkStartRadiusCm.Size = new System.Drawing.Size(178, 45);
            this.trkStartRadiusCm.TabIndex = 8;
            this.trkStartRadiusCm.Value = 10;
            this.trkStartRadiusCm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // trkEndRadiusCm
            // 
            this.trkEndRadiusCm.Location = new System.Drawing.Point(87, 68);
            this.trkEndRadiusCm.Maximum = 30;
            this.trkEndRadiusCm.Name = "trkEndRadiusCm";
            this.trkEndRadiusCm.Size = new System.Drawing.Size(176, 45);
            this.trkEndRadiusCm.SmallChange = 2;
            this.trkEndRadiusCm.TabIndex = 9;
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
            this.lblEndRadiusCm.Location = new System.Drawing.Point(283, 80);
            this.lblEndRadiusCm.Name = "lblEndRadiusCm";
            this.lblEndRadiusCm.Size = new System.Drawing.Size(35, 13);
            this.lblEndRadiusCm.TabIndex = 11;
            this.lblEndRadiusCm.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Blue";
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
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "End Radius";
            // 
            // trkRpcent
            // 
            this.trkRpcent.Location = new System.Drawing.Point(378, 76);
            this.trkRpcent.Maximum = 100;
            this.trkRpcent.Name = "trkRpcent";
            this.trkRpcent.Size = new System.Drawing.Size(174, 45);
            this.trkRpcent.TabIndex = 17;
            this.trkRpcent.Scroll += new System.EventHandler(this.trkRpcent_Scroll);
            // 
            // trkGpcent
            // 
            this.trkGpcent.Location = new System.Drawing.Point(378, 127);
            this.trkGpcent.Maximum = 100;
            this.trkGpcent.Name = "trkGpcent";
            this.trkGpcent.Size = new System.Drawing.Size(174, 45);
            this.trkGpcent.TabIndex = 18;
            this.trkGpcent.Scroll += new System.EventHandler(this.trkGpcent_Scroll);
            // 
            // trkBpcent
            // 
            this.trkBpcent.Location = new System.Drawing.Point(378, 178);
            this.trkBpcent.Maximum = 100;
            this.trkBpcent.Name = "trkBpcent";
            this.trkBpcent.Size = new System.Drawing.Size(174, 45);
            this.trkBpcent.TabIndex = 19;
            this.trkBpcent.Scroll += new System.EventHandler(this.trkBpcent_Scroll);
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
            this.trkLPcm.Location = new System.Drawing.Point(87, 109);
            this.trkLPcm.Maximum = 100;
            this.trkLPcm.Minimum = 20;
            this.trkLPcm.Name = "trkLPcm";
            this.trkLPcm.Size = new System.Drawing.Size(176, 45);
            this.trkLPcm.SmallChange = 2;
            this.trkLPcm.TabIndex = 21;
            this.trkLPcm.Value = 72;
            this.trkLPcm.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lines / cm";
            // 
            // lblLPcm
            // 
            this.lblLPcm.AutoSize = true;
            this.lblLPcm.Location = new System.Drawing.Point(283, 120);
            this.lblLPcm.Name = "lblLPcm";
            this.lblLPcm.Size = new System.Drawing.Size(35, 13);
            this.lblLPcm.TabIndex = 23;
            this.lblLPcm.Text = "label2";
            // 
            // lblAnglePStep
            // 
            this.lblAnglePStep.AutoSize = true;
            this.lblAnglePStep.Location = new System.Drawing.Point(286, 39);
            this.lblAnglePStep.Name = "lblAnglePStep";
            this.lblAnglePStep.Size = new System.Drawing.Size(35, 13);
            this.lblAnglePStep.TabIndex = 26;
            this.lblAnglePStep.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Angle / step";
            // 
            // trkAnglePStep
            // 
            this.trkAnglePStep.LargeChange = 2;
            this.trkAnglePStep.Location = new System.Drawing.Point(74, 30);
            this.trkAnglePStep.Maximum = 6;
            this.trkAnglePStep.Minimum = 1;
            this.trkAnglePStep.Name = "trkAnglePStep";
            this.trkAnglePStep.Size = new System.Drawing.Size(189, 45);
            this.trkAnglePStep.SmallChange = 2;
            this.trkAnglePStep.TabIndex = 24;
            this.trkAnglePStep.Value = 2;
            this.trkAnglePStep.Scroll += new System.EventHandler(this.CollectValues);
            // 
            // lblRpcent
            // 
            this.lblRpcent.AutoSize = true;
            this.lblRpcent.Location = new System.Drawing.Point(558, 85);
            this.lblRpcent.Name = "lblRpcent";
            this.lblRpcent.Size = new System.Drawing.Size(35, 13);
            this.lblRpcent.TabIndex = 27;
            this.lblRpcent.Text = "label1";
            // 
            // lblGpcent
            // 
            this.lblGpcent.AutoSize = true;
            this.lblGpcent.Location = new System.Drawing.Point(558, 139);
            this.lblGpcent.Name = "lblGpcent";
            this.lblGpcent.Size = new System.Drawing.Size(35, 13);
            this.lblGpcent.TabIndex = 28;
            this.lblGpcent.Text = "label1";
            // 
            // lblBpcent
            // 
            this.lblBpcent.AutoSize = true;
            this.lblBpcent.Location = new System.Drawing.Point(558, 190);
            this.lblBpcent.Name = "lblBpcent";
            this.lblBpcent.Size = new System.Drawing.Size(35, 13);
            this.lblBpcent.TabIndex = 29;
            this.lblBpcent.Text = "label1";
            // 
            // prgCreate
            // 
            this.prgCreate.Location = new System.Drawing.Point(158, 485);
            this.prgCreate.Name = "prgCreate";
            this.prgCreate.Size = new System.Drawing.Size(316, 18);
            this.prgCreate.TabIndex = 30;
            // 
            // lblProcessingEnded
            // 
            this.lblProcessingEnded.AutoSize = true;
            this.lblProcessingEnded.Location = new System.Drawing.Point(155, 485);
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
            this.grpDiscData.Size = new System.Drawing.Size(673, 168);
            this.grpDiscData.TabIndex = 32;
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
            // grpColourData
            // 
            this.grpColourData.Controls.Add(this.label1);
            this.grpColourData.Controls.Add(this.trkRfreq);
            this.grpColourData.Controls.Add(this.trkGfreq);
            this.grpColourData.Controls.Add(this.trkBfreq);
            this.grpColourData.Controls.Add(this.lblBpcent);
            this.grpColourData.Controls.Add(this.lblRfreq);
            this.grpColourData.Controls.Add(this.lblGpcent);
            this.grpColourData.Controls.Add(this.lblAnglePStep);
            this.grpColourData.Controls.Add(this.lblGfreq);
            this.grpColourData.Controls.Add(this.lblRpcent);
            this.grpColourData.Controls.Add(this.label8);
            this.grpColourData.Controls.Add(this.lblBfreq);
            this.grpColourData.Controls.Add(this.trkAnglePStep);
            this.grpColourData.Controls.Add(this.trkBpcent);
            this.grpColourData.Controls.Add(this.label2);
            this.grpColourData.Controls.Add(this.trkGpcent);
            this.grpColourData.Controls.Add(this.label3);
            this.grpColourData.Controls.Add(this.trkRpcent);
            this.grpColourData.Location = new System.Drawing.Point(12, 225);
            this.grpColourData.Name = "grpColourData";
            this.grpColourData.Size = new System.Drawing.Size(670, 218);
            this.grpColourData.TabIndex = 33;
            this.grpColourData.TabStop = false;
            this.grpColourData.Text = "Resolution and Colours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.grpColourData);
            this.Controls.Add(this.grpDiscData);
            this.Controls.Add(this.lblProcessingEnded);
            this.Controls.Add(this.prgCreate);
            this.Controls.Add(this.cmdCreateWAVData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vinyl Draw";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRadiusCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRadiusCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRpcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGpcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBpcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAnglePStep)).EndInit();
            this.grpDiscData.ResumeLayout(false);
            this.grpDiscData.PerformLayout();
            this.grpColourData.ResumeLayout(false);
            this.grpColourData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button cmdCreateWAVData;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TrackBar trkRfreq;
        private System.Windows.Forms.TrackBar trkGfreq;
        private System.Windows.Forms.TrackBar trkBfreq;
        private System.Windows.Forms.Label lblRfreq;
        private System.Windows.Forms.Label lblGfreq;
        private System.Windows.Forms.Label lblBfreq;
        private System.Windows.Forms.TrackBar trkStartRadiusCm;
        private System.Windows.Forms.TrackBar trkEndRadiusCm;
        private System.Windows.Forms.Label lblStartRadiusCm;
        private System.Windows.Forms.Label lblEndRadiusCm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trkRpcent;
        private System.Windows.Forms.TrackBar trkGpcent;
        private System.Windows.Forms.TrackBar trkBpcent;
        private System.Windows.Forms.ListBox lbxSpeedRPM;
        private System.Windows.Forms.TrackBar trkLPcm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLPcm;
        private System.Windows.Forms.Label lblAnglePStep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trkAnglePStep;
        private System.Windows.Forms.Label lblRpcent;
        private System.Windows.Forms.Label lblGpcent;
        private System.Windows.Forms.Label lblBpcent;
        private System.Windows.Forms.ProgressBar prgCreate;
        private System.Windows.Forms.Label lblProcessingEnded;
        private System.Windows.Forms.GroupBox grpDiscData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpColourData;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

