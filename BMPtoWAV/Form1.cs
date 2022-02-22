// This file is part of Vinyl Draw.
//
// Vinyl Draw is free software: you can redistribute it and/or modify it under the
// terms of the GNU General Public License as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.
//
// Vinyl Draw is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with Vinyl Draw.
// If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VinylDraw
{

    public partial class Form1 : Form
    {
        public WAVAdmin wav;
        public int H0;
        public int H360;
        public bool LumForAmpl;
        public double StartRadiusCm;
        public double EndRadiusCm;
        public int LPcm;
        public int StepsPerRev;
        public double TTSpeedRPM;
        public List<SpeedRPM> Speeds;


        /// <summary>
        /// Draw form and controls.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            cmdCreateWAVData.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            lblProcessingEnded.Visible = false;
            prgCreate.Visible = false;
            Speeds = new List<SpeedRPM> {
                new SpeedRPM("8⅓", 50.0d / 6),
                new SpeedRPM("16⅔", 100.0d/6),
                new SpeedRPM("22½", 22.5),
                new SpeedRPM("33⅓", 100.0d/3),
                new SpeedRPM("39", 39),
                new SpeedRPM("45", 45),
                new SpeedRPM("78", 78)};
            lbxSpeedRPM.DisplayMember = "Text";
            lbxSpeedRPM.DataSource = Speeds;
            lbxSpeedRPM.SelectedIndex = 5;
            trkHue0.Value = Constants.dfltH0;
            trkHue360.Value = Constants.dfltH360;
            rdoLuminosity.Checked = Constants.dfltLumForAmpl;
            trkLPcm.Value = Constants.dfltLPcm;
            trkStepsPerRev.Value = Constants.dfltStepsPerRev;
            trkStartRadiusCm.Value = Constants.dfltStartRadiusCm;
            trkEndRadiusCm.Value = Constants.dfltEndRadiusCm;
            CollectValues();
        }

        /// <summary>
        /// Copy values from panel controls to working storage.
        /// </summary>
        private void CollectValues()
        {
            H0 = trkHue0.Value * 250;
            H360 = trkHue360.Value * 250;
            LumForAmpl = (rdoLuminosity.Checked) ? true : false;
            StartRadiusCm = 6.25d + trkStartRadiusCm.Value / 4.0d;
            EndRadiusCm = 3.0d + trkEndRadiusCm.Value / 10.0d;
            LPcm = trkLPcm.Value;
            StepsPerRev = 180 * trkStepsPerRev.Value;
            lblH0.Text = H0.ToString() + " Hz";
            lblH360.Text = H360.ToString() + " Hz";
            lblStartRadiusCm.Text = StartRadiusCm.ToString() + " cm";
            lblEndRadiusCm.Text = EndRadiusCm.ToString() + " cm";
            lblLPcm.Text = LPcm.ToString();
            lblStepsPerRev.Text = StepsPerRev.ToString();
        }

        /// <summary>
        /// Open a BMP file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Title = "Select BMP file";
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "bmp";
            ofd.Filter = "BMP files (*.bmp)|*.bmp";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = false;
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                try
                {
                    BMPAdmin.OpenBMPFile(ofd.FileName);
                    cmdCreateWAVData.Enabled = true;
                    lblProcessingEnded.Visible = false;
                    // Show all the details of the BMP file.
                    lblFileName.Text = ofd.FileName;
                    lblFileLength.Text = BMPAdmin.BMPHdr.FileLength.ToString();
                    lblBmpOffset.Text = BMPAdmin.BMPHdr.BmpOffset.ToString();
                    lblDibHeaderLength.Text = BMPAdmin.BMPHdr.DibHeaderLength.ToString();
                    lblWidthPx.Text = BMPAdmin.BMPHdr.WidthPx.ToString();
                    lblHeightPx.Text = BMPAdmin.BMPHdr.HeightPx.ToString();
                    lblColourPlanes.Text = BMPAdmin.BMPHdr.ColourPlanes.ToString();
                    lblRowsReversed.Text = (BMPAdmin.BMPHdr.RowsReversed) ? "Yes" : "No";
                    lblBitsPerPx.Text = BMPAdmin.BMPHdr.BitsPerPx.ToString();
                    lblCompression.Text = BMPAdmin.BMPHdr.Compression.ToString();
                    lblImageSize.Text = BMPAdmin.BMPHdr.ImageSize.ToString();
                    lblHorizRes.Text = BMPAdmin.BMPHdr.HorizRes.ToString();
                    lblVertRes.Text = BMPAdmin.BMPHdr.VertRes.ToString();
                    lblColoursInPalette.Text = BMPAdmin.BMPHdr.ColoursInPalette.ToString();
                    lblBytesPerRow.Text = BMPAdmin.BMPHdr.BytesPerRow.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error has occurred while opening the BMP file.");
                }
            }
                

        }

        /// <summary>
        /// Process BMP file and produce WAV output in working storage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            lblProcessingEnded.Visible = false;
            prgCreate.Value = 0;
            prgCreate.Visible = true;
            CollectValues();
            wav = new WAVAdmin(StartRadiusCm, EndRadiusCm, LPcm,
               TTSpeedRPM, StepsPerRev, H0, H360, LumForAmpl);
            wav.ProgressChanged += (o, ex) =>
            {
                prgCreate.Value = ex.Progress;
            };
            wav.ProcessingEnded += (o, ex) =>
            {
                prgCreate.Visible = false;
                lblProcessingEnded.Text = ex.Message;
                lblProcessingEnded.Visible = true;
            };
            wav.PrepareWAV();
            lblProcessingEnded.Visible = true;
            saveToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Write working storage copy of WAV data to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wav != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Title = "Save WAV file";
                sfd.CheckPathExists = true;
                sfd.DefaultExt = "wav";
                sfd.Filter = "WAV files (*.wav)|*.wav";
                sfd.FilterIndex = 0;
                sfd.RestoreDirectory = false;
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    wav.WriteWAVFile(sfd.FileName);
                }
            }
        }
        /// <summary>
        /// Wrapper for event. Called from several controls on panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectValues(object sender, EventArgs e)
        {
            CollectValues();
        }

 
        private void lbxSpeedRPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            TTSpeedRPM = (lbxSpeedRPM.SelectedItem as SpeedRPM).Value;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Vinyl Draw - Help")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                Help helpForm = new Help();
                helpForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trkHue0_Scroll(object sender, EventArgs e)
        {
            if (trkHue0.Value > trkHue360.Value)
            {
                trkHue0.Value = trkHue360.Value;
            }
            CollectValues();
        }

        private void trkHue360_Scroll(object sender, EventArgs e)
        {
            if (trkHue360.Value < trkHue0.Value)
            {
                trkHue360.Value = trkHue0.Value;
            }
            CollectValues();
        }
    }
    public class SpeedRPM
    {
        public SpeedRPM(string iText, double iValue)
        {
            Text = iText;
            Value = iValue;
        }
        public string Text { get; set; }
        public double Value { get; set; }
    }
}
