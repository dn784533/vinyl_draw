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
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VinylDraw
{

    public partial class Form1 : Form
    {
        public WAVAdmin wav;
        public int SamplesPerPixel;
        public int H360;
        public bool LumForAmpl;
        public double StartRadiusCm;
        public double EndRadiusCm;
        public int LPcm;
        public int StepsPerRev;
        public double TTSpeedRPM;
        public List<SpeedRPM> Speeds;
        public int squareSize;
        public Bitmap bmpOrig, bmpCrop;
        public Image imCrop;


        /// <summary>
        /// Draw form and controls.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // The next statement uses reflection to prevents flicker when redrawing the image with circles.
            // Thanks to https://stackoverflow.com/questions/8046560
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlPreview, new object[] { true });
            cmdCreateWAVData.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            lblProcessingEnded.Visible = false;
            lblDuration.Visible = false;
            prgCreate.Visible = false;
            Speeds = new List<SpeedRPM> {
                new SpeedRPM("8⅓", 50.0d / 6),
                new SpeedRPM("16⅔", 100.0d/6),
                new SpeedRPM("22½", 22.5),
                new SpeedRPM("33.33", 33.33),
                new SpeedRPM("33⅓", 100.0d/3),
                new SpeedRPM("39", 39),
                new SpeedRPM("45", 45),
                new SpeedRPM("78", 78)};
            lbxSpeedRPM.DisplayMember = "Text";
            lbxSpeedRPM.DataSource = Speeds;
            lbxSpeedRPM.SelectedIndex = Constants.dfltSelectedIndex;
            trkSamplesPerPixel.Value = Constants.dfltSamplesPerPixel;
            trkLPcm.Value = Constants.dfltLPcm;
            trkStartRadiusCm.Value = Constants.dfltStartRadiusCm;
            trkEndRadiusCm.Value = Constants.dfltEndRadiusCm;
            CollectValues();
        }

        /// <summary>
        /// Copy values from panel controls to working storage.
        /// </summary>
        private void CollectValues()
        {
            SamplesPerPixel = 2 * trkSamplesPerPixel.Value + 20;
            StartRadiusCm = 6.25d + trkStartRadiusCm.Value / 4.0d;
            EndRadiusCm = 3.0d + trkEndRadiusCm.Value / 10.0d;
            LPcm = trkLPcm.Value;
            lblSamplesPerPixel.Text = SamplesPerPixel.ToString() + " samples: " +
                Math.Round(1.0 * Constants.SampleRate / SamplesPerPixel, 2).ToString() + " Hz";
            lblPixelInfo.Text = Math.Round(60.0 / TTSpeedRPM * Constants.SampleRate / SamplesPerPixel, 1) +
                " pixels per revolution";
            lblSampleInfo.Text = Math.Round(60.0 / TTSpeedRPM * Constants.SampleRate, 1) +
                " samples per revolution";
            lblStartRadiusCm.Text = StartRadiusCm.ToString() + " cm (" + 
                Math.Round(StartRadiusCm / 2.54, 2).ToString() + " in.)";
            lblEndRadiusCm.Text = EndRadiusCm.ToString() + " cm (" +
                Math.Round(EndRadiusCm / 2.54, 2).ToString() + " in.)";
            lblLPcm.Text = LPcm.ToString() + " lines/cm (" + Math.Round(LPcm * 2.54, 0).ToString() + " lines/in.)";
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
                    lblDuration.Visible = false;
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
                    squareSize = Math.Min(BMPAdmin.BMPHdr.WidthPx, BMPAdmin.BMPHdr.HeightPx);
                    int startX = (BMPAdmin.BMPHdr.WidthPx - squareSize) / 2;
                    int startY = (BMPAdmin.BMPHdr.HeightPx - squareSize) / 2;
                    bmpOrig = new Bitmap(Image.FromFile(ofd.FileName));
                    imCrop = new Bitmap(bmpOrig.Clone(
                        new Rectangle(startX, startY, squareSize, squareSize), bmpOrig.PixelFormat));
                    CollectValues();
                    pnlPreview.Invalidate();
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
            lblDuration.Visible = false;
            cmdCreateWAVData.Enabled = false;
            prgCreate.Value = 0;
            prgCreate.Visible = true;
            CollectValues();
            wav = new WAVAdmin(StartRadiusCm, EndRadiusCm, LPcm,
               TTSpeedRPM, SamplesPerPixel);
            wav.ProgressChanged += (o, ex) =>
            {
                prgCreate.Value = ex.Progress;
            };
            wav.ProcessingEnded += (o, ex) =>
            {
                prgCreate.Visible = false;
                lblProcessingEnded.Text = ex.Message;
                lblProcessingEnded.Visible = true;
                lblDuration.Text = ex.Duration;
                lblDuration.Visible = true;
            };
            wav.PrepareWAV();
            lblProcessingEnded.Visible = true;
            lblDuration.Visible = true;
            saveToolStripMenuItem.Enabled = true;
            cmdCreateWAVData.Enabled = true;
        }

        /// <summary>
        /// Write working storage copy of WAV data to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wav != null)
                try
                { 
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error has occurred while saving the WAV file.");
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
            CollectValues();
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

        private void trkSamplesPerPixel_Scroll(object sender, EventArgs e)
        {
            CollectValues();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// (Re)draw the preview panel with the selected bitmap and the
        /// two boundary circles. The outer boundary will always extend
        /// to the shorter of the rectangular dimensions of the bitmap.
        /// The bitmap may be square or oblong; if oblong, the bitmap will
        /// be cropped so that only the central square section is presented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPreview_Paint(object sender, PaintEventArgs e)
        {
            int innerCircleStart = (int)(0.5 * (StartRadiusCm - EndRadiusCm) * pnlPreview.Width / StartRadiusCm);
            int innerCircleSize = (int)(1.0 * EndRadiusCm * pnlPreview.Width / StartRadiusCm);
            if (imCrop != null) e.Graphics.DrawImage(imCrop, 0, 0, pnlPreview.Width, pnlPreview.Height);
            e.Graphics.DrawEllipse(new Pen(Color.Green, 2),
                new RectangleF(0, 0, pnlPreview.Width - 1, pnlPreview.Height - 1));
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2),
                new RectangleF(innerCircleStart, innerCircleStart, innerCircleSize, innerCircleSize));
        }

        private void trkStartRadiusCm_Scroll(object sender, EventArgs e)
        {
            CollectValues();
            pnlPreview.Invalidate();
        }

        private void trkEndRadiusCm_Scroll(object sender, EventArgs e)
        {
            CollectValues();
            pnlPreview.Invalidate();
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
