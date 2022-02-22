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
using System.IO;

namespace VinylDraw
{
    public static class Constants
    {
        public const int SampleRate = 44100;
        public const int dfltH0 = 2;
        public const int dfltH360 = 8;
        public const bool dfltLumForAmpl = true;

        public const int dfltLPcm = 80;
        public const int dfltSelectedIndex = 5; // 45 rpm
        public const int dfltStepsPerRev = 2;
        public const int dfltStartRadiusCm = 10; // NB - refers to TrackBar control. Value is 10 'notches' of 0.25 up from a base of 6.25 - so 8.75
        public const int dfltEndRadiusCm = 23; // As above. Value is 18 notches of 0.1 up from a base of 3 - so 5.3
    }

    public class wavHeader
    {

    }

    [Serializable]
    public struct bmpHeader
    {
        public short Id;
        public int FileLength;
        public int Unused;
        public int BmpOffset;
        public int DibHeaderLength;
        public int WidthPx;
        public int HeightPx;
        public short ColourPlanes;
        public short BitsPerPx;
        public int BytesPerRow;
        public int Compression;
        public int ImageSize;
        public int HorizRes;
        public int VertRes;
        public int ColoursInPalette;
        public int ImportantColours;
        public int ColourTableHeader;

        public bool RowsReversed;

        /// <summary>
        /// Populates the fields of the BMP header by name with data read from the file.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bmpHeader Populate(byte[] data)
        {
            var br = new BinaryReader(new MemoryStream(data));
            var bh = default(bmpHeader);
            int height;
            bh.Id = br.ReadInt16();
            bh.FileLength = br.ReadInt32();
            bh.Unused = br.ReadInt32();
            bh.BmpOffset = br.ReadInt32();
            bh.DibHeaderLength = br.ReadInt32();
            bh.WidthPx = br.ReadInt32();

            height = br.ReadInt32();
            if (height < 0)
            {
                bh.HeightPx = -height;
                bh.RowsReversed = true;
            }
            else
            {
                bh.HeightPx = height;
                bh.RowsReversed = false;
            }
            bh.ColourPlanes = br.ReadInt16();
            bh.BitsPerPx = br.ReadInt16();
            bh.BytesPerRow = (bh.BitsPerPx * bh.WidthPx + 31) / 32 * 4;
            bh.Compression = br.ReadInt32();
            bh.ImageSize = br.ReadInt32();
            bh.HorizRes = br.ReadInt32();
            bh.VertRes = br.ReadInt32();
            bh.ColoursInPalette = br.ReadInt32();
            bh.ImportantColours = br.ReadInt32();
            return bh;
        }

    }

    /// <summary>
    /// Holds H/S/L data for a single point in the image.
    /// A List of bmpHSLdata is used to hold the colour table values
    /// for sub-16-bit BMPs.
    /// </summary>
    public struct bmpHSLdata
    {
        public short Hue;
        public byte Saturation;
        public byte Luminosity;
        public bmpHSLdata(short iH, byte iS, byte iL) : this()
        {
            Hue = iH;
            Saturation = iS;
            Luminosity = iL;
        }
    }
	public static class BMPAdmin
    {
		public static bmpHeader BMPHdr;
        public static List<bmpHSLdata> BMPColourTableHSL;
        public static bmpHSLdata[,] BMPImageDataHSL { get; set; }

        /// <summary>
        /// Open and read a BMP file into memory.
        /// </summary>
        /// <param name="iFileName"></param>
		public static void OpenBMPFile(string iFileName)
        {
			byte[] data = new byte[0x36];
			int bytesRead = 0;
			BMPHdr = new bmpHeader();
            bmpHSLdata colourHSL;

            using (FileStream fs = new FileStream(iFileName, FileMode.Open))
            {
				// Read the first 0x36 bytes and populate the BMP header struct
				bytesRead = fs.Read(data, 0, 0x36);
				BMPHdr = bmpHeader.Populate(data);

				// Check for errors in file
				if (BMPHdr.Id != 0x4D42) throw new Exception("Not recognised as a BMP file");
                if (BMPHdr.BitsPerPx == 16) throw new Exception("Vinyl Draw supports 1-, 4-, 8- and 24-bit BMPs but NOT 16-bit.");
				if (BMPHdr.Compression != 0) throw new Exception("Compressed BMPs are not supported at present!");
				// Define image array size now dimensions are known
				BMPImageDataHSL = new bmpHSLdata[BMPHdr.HeightPx, BMPHdr.WidthPx];
				// If there are fewer than 16 bits per pixel then there should be a colour table comprising
				// four bytes for each colour specified. Only three bytes are used, for R, G and B values.
				if (BMPHdr.BitsPerPx < 16)
                {
                    try
                    {
                        BMPColourTableHSL = new List<bmpHSLdata>();
                        fs.Position = 0x0E + BMPHdr.DibHeaderLength; // Set position to start of colour table
                        for (int i = 0; i < BMPHdr.ColoursInPalette; i++)
                        {
                            bytesRead = fs.Read(data, 0, 4);
                            BMPColourTableHSL.Add(CalcHSLData(data[2],data[1],data[0])); // stored as B,G,R 
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error in BMP colour table");
                    }
                }
				// Move to start of bitmap data
				fs.Position = BMPHdr.BmpOffset;
		
				// Process the bitmap data, expanding where the colour table is used, and store
				// each pixel as a bmpHSLdata struct
				for (int iRow = 0;iRow < BMPHdr.HeightPx;iRow++)
                {
                    bytesRead = 0;
                    int iCol = 0;
                    while (bytesRead < BMPHdr.BytesPerRow)
					{
                        switch (BMPHdr.BitsPerPx)
                        {
                            case 24:
                                // If we're at the RHS of the image, read any padding bytes
                                if (iCol > BMPHdr.WidthPx - 1)
                                { 
                                    bytesRead += fs.Read(data, 0, BMPHdr.BytesPerRow - bytesRead);
                                    break;
                                }
								bytesRead += fs.Read(data, 0, 3);
								// Calculate the hue, saturation and luminosity from the three bytes,
                                // reversing the order for B, G, R, and add this new data to the image.
								BMPImageDataHSL[iRow, iCol++] = CalcHSLData(data[2], data[1], data[0]);
								break;
							case 8:
								bytesRead += fs.Read(data, 0, 4);
                                // Iterate through each of the four bytes read
                                for (int offset = 0; offset <= 3; offset++)
                                {
                                    // If we're at the RHS of the image, jump out
                                    if (iCol > BMPHdr.WidthPx - 1)
                                        break;  
                                    // Use colour table to retrieve the HSL values
                                    colourHSL = BMPColourTableHSL[data[offset]];
                                    BMPImageDataHSL[iRow, iCol++] = new bmpHSLdata(colourHSL.Hue, colourHSL.Saturation, colourHSL.Luminosity);
                                }
								break;
							case 4:
                                bytesRead += fs.Read(data, 0, 4);
                                // Iterate through each of the four bytes read
                                for (int offset = 0; offset <= 3; offset++)
                                {
                                    // If we're at the RHS of the image, jump out
                                    if (iCol > BMPHdr.WidthPx - 1)
                                        break;
                                    colourHSL = BMPColourTableHSL[(byte)(data[offset] >> 4)];
                                    BMPImageDataHSL[iRow, iCol++] = new bmpHSLdata(colourHSL.Hue, colourHSL.Saturation, colourHSL.Luminosity);
                                    // If we're at the RHS of the image, jump out
                                    if (iCol > BMPHdr.WidthPx - 1)
                                        break;
                                    colourHSL = BMPColourTableHSL[(byte)(data[offset] & 0x0F)];
                                    BMPImageDataHSL[iRow, iCol++] = new bmpHSLdata(colourHSL.Hue, colourHSL.Saturation, colourHSL.Luminosity);
                                }
                                break;
							case 1:
								bytesRead += fs.Read(data, 0, 4);
                                // Iterate through each of the four bytes read
                                for (int offset = 0; offset <= 3; offset++)
                                {
                                    // Iterate through each of the 8 bits, starting with the MSB
                                    for (byte msk = 128; msk > 0; msk >>= 1)
                                    {
                                        // If we're at the RHS of the image, jump out
                                        if (iCol > BMPHdr.WidthPx - 1)
                                            break;
                                        // If the bit is set, use colour 1
                                        if ((data[offset] & msk) > 0) colourHSL = BMPColourTableHSL[1];
                                        // If the bit is clear, use colour 0
                                        else colourHSL = BMPColourTableHSL[0];
                                        BMPImageDataHSL[iRow, iCol++] = new bmpHSLdata(colourHSL.Hue, colourHSL.Saturation, colourHSL.Luminosity);
                                    }
                                }
								break;
                            default:
                                throw new Exception("Bits per BMP pixel must be 1, 4, 8 or 24");
						}
                    }
				}
				fs.Close();
			}

		}
        /// <summary>
        /// Calculates hue, saturation and luminosity from the three RGB values.
        /// The 'colours' are inverted first.
        /// </summary>
        /// <param name="iR"></param>
        /// <param name="iG"></param>
        /// <param name="iB"></param>
        /// <returns></returns>
        private static bmpHSLdata CalcHSLData(byte iR, byte iG, byte iB)
        {
            // Convert bytes to doubles, flipping bit-values so that colours are inverted
            // (so 'black' becomes 'white' etc)
            byte bR = (byte)~iR;
            byte bG = (byte)~iG;
            byte bB = (byte)~iB;
            double dR = bR;
            double dG = bG;
            double dB = bB;
            double hue;
            double saturation;
            double luminosity;
            // Calculate hue, luminosity and saturation for each of the
            // six orderings of R, G, B components
            if (dR >= dG)
            {
                if (dG >= dB)
                {
                    hue = 60 * ((dG - dB) / (dR - dB));               // R >= G >= B
                    luminosity = (dR + dB) / 510;
                    saturation = (luminosity >= 1) ? 0 : (dR - dB) / (255 * (1 - Math.Abs(2 * luminosity - 1)));
                }
                else
                {
                    if (dR >= dB)
                    {
                        hue = 60 * (6 - (dB - dG) / (dR - dG));       // R >= B >  G
                        luminosity = (dR + dG) / 510;
                        saturation = (luminosity >= 1) ? 0 : (dR - dG) / (255 * (1 - Math.Abs(2 * luminosity - 1)));
                    }
                    else
                    {
                        hue = 60 * (4 + (dR - dG) / (dB - dG));       // B >  R >= G
                        luminosity = (dB + dG) / 510;
                        saturation = (luminosity >= 1) ? 0 : (dB - dG) / (255 * (1 - Math.Abs(2 * luminosity - 1)));

                    }
                }
            }
            else
            {
                if (dR >= dB)
                {
                    hue = 60 * (2 - (dR - dB) / (dG - dB));           // G >  R >= B
                    luminosity = (dG + dB) / 510;
                    saturation = (luminosity >= 1) ? 0 : (dG - dB) / (255 * (1 - Math.Abs(2 * luminosity - 1)));
                }
                else
                {
                    if (dG >= dB)
                    {
                        hue = 60 * (2 + (dB - dR) / (dG - dR));       // G >= B >  R
                        luminosity = (dG + dR) / 510;
                        saturation = (luminosity >= 1) ? 0 : (dG - dR) / (255 * (1 - Math.Abs(2 * luminosity - 1)));
                    }
                    else
                    {
                        hue = 60 * (4 - (dG - dR) / (dB - dR));       // B >  G >  R
                        luminosity = (dB + dR) / 510;
                        saturation = (luminosity >= 1) ? 0 : (dB - dR) / (255 * (1 - Math.Abs(2 * luminosity - 1)));
                    }
                }
            }
            return new bmpHSLdata((short)Math.Round(hue, 0), 
                                   (byte)Math.Round(100 * saturation, 0),
                                   (byte)Math.Round(100 * luminosity, 0));
        }
    }

	public class WAVAdmin
    {
        public int amplSign;
		public double dsOuterRadiusCm;
		public double dsInnerRadiusCm;
		public double dsLPcm;
		public double TTrpm;
		public int stepsPerRev;
		public double angStep;
		public double stepDuration;
		public double numLines;
		public int[] freq;
		public int[] numSamples;
		public int samplesPerRev;
		public int samplesPerStep;
		public double realSamplesPerStep;
		public double errorSamplesPerStep;
		public double currErrorSamples;
		public int samplesTotal;
		public int sampleBytes;
		public int fileSize;
		public List<byte> sampleData;
        public List<int> hueFreq;
        public List<int> numSampPerWave;
        public bool lumForAmpl;
		public byte[] HeaderBytes = { 0x52, 0x49, 0x46, 0x46, 0x00, 0x00, 0x00, 0x00, 0x57, 0x41, 0x56, 0x45, 0x66, 0x6D, 0x74, 0x20,
									  0x10, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x00, 0x44, 0xAC, 0x00, 0x00, 0x88, 0x58, 0x01, 0x00,
									  0x02, 0x00, 0x10, 0x00, 0x64, 0x61, 0x74, 0x61, 0x00, 0x00, 0x00, 0x00};
		public EventHandler<ProgressEventArgs> ProgressChanged;
		public EventHandler<ProcessingEndedEventArgs> ProcessingEnded;


        /// <summary>
        /// Constructor for WAV file. Parameter values are lifted from the 
        /// settings specified by the user on the main panel.
        /// </summary>
        /// <param name="idsOuterRadiusCm"></param>
        /// <param name="idsInnerRadiusCm"></param>
        /// <param name="idsLPcm"></param>
        /// <param name="iTTrpm"></param>
        /// <param name="iStepsPerRev"></param>
        /// <param name="ih0"></param>
        /// <param name="ih360"></param>
        /// <param name="iLum"></param>
        /// <param name="iInvert"></param>
        public WAVAdmin(double idsOuterRadiusCm, double idsInnerRadiusCm,
			double idsLPcm, double iTTrpm, int iStepsPerRev, 
			int iH0, int iH360, bool iLumForAmpl
			)
        {
            double dH0 = iH0;
            double dH360 = iH360;
            hueFreq = new List<int>();
            numSampPerWave = new List<int>();
            // Create look-up table from Hue to Frequency
            double freqExp = Math.Pow((dH360 / dH0), (1.0d / 359));
            for (short h = 0; h < 360; h++)
            {
                hueFreq.Add((int)(dH0 * Math.Pow(freqExp, h)));
                numSampPerWave.Add((int)(Constants.SampleRate / hueFreq[h]));
            }

            lumForAmpl = iLumForAmpl;

            amplSign = -1;
			dsOuterRadiusCm = idsOuterRadiusCm;
			dsInnerRadiusCm = idsInnerRadiusCm;
			dsLPcm = idsLPcm;
			TTrpm = iTTrpm;
			numLines = (dsOuterRadiusCm - dsInnerRadiusCm) * dsLPcm;
			stepDuration = (angStep * 30) / (Math.PI * TTrpm);
            stepsPerRev = iStepsPerRev; 
            angStep = (360.0d / stepsPerRev) * Math.PI / 180.0d;
            samplesPerRev = (int)(Constants.SampleRate * 60 / TTrpm);
			// The 'real' number of samples required for an angular step - may not be an integer
			realSamplesPerStep = angStep * samplesPerRev / (2.0d * Math.PI);
			// Rounded down to nearest integer
			samplesPerStep = (int)realSamplesPerStep;
			// And thus error that will accrue per step
			errorSamplesPerStep = realSamplesPerStep - samplesPerStep;
			sampleData = new List<byte>();
	
		}
		public double Duration { 
			get
			{
				return (numLines * (60 / TTrpm));
			}
		}

        /// <summary>
        /// Once the WAVAdmin object has been created, this method is called.
        /// It extracts an annular section of the input BMP, starting from halfway down the
        /// RHS of the image, moving anticlockwise and slowly spiralling inward at the
        /// specified groove pitch until the specified inner radius is reached.
        /// </summary>
		public void PrepareWAV()
        {
			double theta;
			int stepsMade;
			int imCentreX = BMPAdmin.BMPHdr.WidthPx / 2;
			int imCentreY = BMPAdmin.BMPHdr.HeightPx / 2;
			double imStartRadius = Math.Min(imCentreX - 1, imCentreY - 1);
			double imEndRadius = imStartRadius * dsInnerRadiusCm / dsOuterRadiusCm;
			double imStep = (imStartRadius - imEndRadius) / numLines;
			int imRow, imCol;
			// Traverse the image from edge towards the centre
			for (double r = imStartRadius; r > imEndRadius; r -= imStep)
            {
				for (theta = 0, stepsMade = 0; stepsMade < stepsPerRev; theta +=angStep, stepsMade++)
                {
					// Calculate the row (y) of the BMP to use. As theta moves from
					// 0 to 2*PI, the radius as calculated in the second term 
					// gradually decreases by one imStep - effectively describing one
					// revolution of a spiral.
					imRow = (int)(Math.Sin(theta) * (r - (theta * imStep / (2 * Math.PI))));
					// If the rows are *not* reversed, flip the sign of imRow - in a normal
					// BMP with positive height, the rows appear in the file in reverse order.
					// If the height is negative, the rows are in top-to-bottom order already.
					if (!BMPAdmin.BMPHdr.RowsReversed)
					{
						imRow = imCentreY + imRow;
					}
                    else
                    {
						imRow = imCentreY - imRow;
                    }
					// Calculate the column (x) of the BMP to use in a similar manner.
					imCol = (int)(imCentreX + Math.Cos(theta) * (r - (theta * imStep / (2 * Math.PI))));
   
					CreateTone(BMPAdmin.BMPImageDataHSL[imRow, imCol].Hue, 
                        lumForAmpl
                            ? BMPAdmin.BMPImageDataHSL[imRow, imCol].Luminosity 
                            : BMPAdmin.BMPImageDataHSL[imRow, imCol].Saturation);
				}
				// Report progress back to the main form
				FireEventProgressChanged((int)(100 * (imStartRadius - r) / (imStartRadius - imEndRadius)));
            }
			// Store number of samples and file length
			sampleBytes = samplesTotal << 1;
			fileSize = sampleBytes + 36;
			HeaderBytes[40] = (byte)(sampleBytes & 0xFF);
			HeaderBytes[41] = (byte)((sampleBytes >> 8) & 0xFF);
			HeaderBytes[42] = (byte)((sampleBytes >> 16) & 0xFF);
			HeaderBytes[43] = (byte)((sampleBytes >> 24) & 0xFF);
			HeaderBytes[4] = (byte)(fileSize & 0xFF);
			HeaderBytes[5] = (byte)((fileSize >> 8) & 0xFF);
			HeaderBytes[6] = (byte)((fileSize >> 16) & 0xFF);
			HeaderBytes[7] = (byte)((fileSize >> 24) & 0xFF);
			FireEventProcessingEnded("The WAV data has been generated successfully.");
        }

        /// <summary>
        /// Generates a single "point" in the WAV file, taking as input RGB data 
        /// for that point.
        /// </summary>
        /// <param name="iData"></param>
		public void CreateTone(short iHue, byte iAmplMultiplier)
        {
            int flip;

            // Invert sign of sine wave, if required, to avoid sudden V-shapes
            //  in waveform 
            flip = -amplSign;
			// Create the right number of samples 
			for (int iSamp=0;iSamp< samplesPerStep;iSamp++)
            {
				// Create a sine wave, calculating the amplitude from the hue data held for the specified pixel.
				// The Sine function returns a value in -1...1, which is multiplied by the value held for the luminosity or saturation
				// (0 - 100) and then multiplied by 326 to give a value in the range -32600...32600
				short ampl = (short)(Math.Sin(2.0d * Math.PI * iSamp / numSampPerWave[iHue]) * iAmplMultiplier * 326 * flip);

				// If we have reached the last few samples for this wave, reduce the amplitude progressively 
				// towards zero. This is to avoid sudden jumps in sample values from one wave to the next.
				double portionLeft = (double)1.0d - ((double)iSamp / (double)samplesPerStep);
				if (portionLeft <= 0.1)
                {
					ampl = (short)(ampl * 10 * portionLeft);
                    // Get the sign of the waveform just finishing, if its value is non-zero.
                    if ((portionLeft != 0) && (ampl != 0))
                    {
                        amplSign = Math.Sign(ampl);
                    }
                }
				// Add new data point to WAV data
				sampleData.Add((byte)(ampl & 0xFF));
				sampleData.Add((byte)((ampl >> 8) & 0xFF));
				samplesTotal++;
            }
			// If the cumulative deficit in the sample count has reached 1, write out a single silent sample
			currErrorSamples += errorSamplesPerStep;
			if (currErrorSamples>=1)
            {
				currErrorSamples--; // reduce cumulative error
				sampleData.Add((byte)0x00);
				sampleData.Add((byte)0x00);
				samplesTotal++;
            }
        }
		public void WriteWAVFile(string iFileName)
		{
			using (FileStream fs = new FileStream(iFileName, FileMode.Create))
			{
				// The 44 bytes of the header
				fs.Write(HeaderBytes, 0, 44);
				// The bytes of actual data (which will number twice the number of samples).
				fs.Write(sampleData.ToArray(), 0, sampleBytes);
				// End gracefully.
				fs.Close();
			}
		}

        /// <summary>
        /// Update main panel with progress information.
        /// </summary>
        /// <param name="iProgress"></param>
		public void FireEventProgressChanged(int iProgress)
        {
			ProgressChanged?.Invoke(this, new ProgressEventArgs(iProgress));
        }

        /// <summary>
        /// Update main panel when processing has finished.
        /// </summary>
        /// <param name="iMessage"></param>
		public void FireEventProcessingEnded(string iMessage)
		{
			ProcessingEnded?.Invoke(this, new ProcessingEndedEventArgs(iMessage));
		}
	}
	public class ProgressEventArgs : EventArgs
    {
		public int Progress { get; set; }
		public ProgressEventArgs(int iProgress)
        {
			Progress = iProgress;
        }
    }
	public class ProcessingEndedEventArgs : EventArgs
    {
		public string Message { get; set; }
		public ProcessingEndedEventArgs(string iMessage)
        {
			Message = iMessage;
        }
    }
}
