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
        public const int dfltLPcm = 85;
        public const int dfltSelectedIndex = 6; // 45 rpm
        public const int dfltStartRadiusCm = 10; // NB - refers to TrackBar control. Value is 10 'notches' of 0.25 up from a base of 6.25 - so 8.75
        public const int dfltEndRadiusCm = 23; // As above. Value is 23 notches of 0.1 up from a base of 3 - so 5.3
        public const int dfltSamplesPerPixel = 34; // As above. Value is 34 notches of 2 up from a base of 20 - so 88 
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

    
	public static class BMPAdmin
    {
		public static bmpHeader BMPHdr;
        // List and array for greyscale values
        public static List<short> BMPColourTableGrey;
        public static short[,] BMPImageDataGrey { get; set; }

        /// <summary>
        /// Open and read a BMP file into memory.
        /// </summary>
        /// <param name="iFileName"></param>
		public static void OpenBMPFile(string iFileName)
        {
			byte[] data = new byte[0x36];
			int bytesRead = 0;
			BMPHdr = new bmpHeader();
            short colourGrey;

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
				BMPImageDataGrey = new short[BMPHdr.HeightPx, BMPHdr.WidthPx];
				// If there are fewer than 16 bits per pixel then there should be a colour table comprising
				// four bytes for each colour specified. Only three bytes are used, for R, G and B values.
				if (BMPHdr.BitsPerPx < 16)
                {
                    try
                    {
                        BMPColourTableGrey = new List<short>();
                        fs.Position = 0x0E + BMPHdr.DibHeaderLength; // Set position to start of colour table
                        for (int i = 0; i < BMPHdr.ColoursInPalette; i++)
                        {
                            bytesRead = fs.Read(data, 0, 4);
                            BMPColourTableGrey.Add(CalcGreyData(data[2],data[1],data[0])); // stored as B,G,R 
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
                                // Calculate the greyscale value for the three bytes,
                                // reversing the order for B, G, R, and add this new data to the image.
                                BMPImageDataGrey[iRow, iCol++] = CalcGreyData(data[2], data[1], data[0]);
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
                                    colourGrey = BMPColourTableGrey[data[offset]];
                                    BMPImageDataGrey[iRow, iCol++] = colourGrey;
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
                                    colourGrey = BMPColourTableGrey[(byte)(data[offset] >> 4)];
                                    BMPImageDataGrey[iRow, iCol++] = colourGrey;
                                    // If we're at the RHS of the image, jump out
                                    if (iCol > BMPHdr.WidthPx - 1)
                                        break;
                                   colourGrey = BMPColourTableGrey[(byte)(data[offset] & 0x0F)];
                                    BMPImageDataGrey[iRow, iCol++] = colourGrey;
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
                                        if ((data[offset] & msk) > 0)
                                        {
                                            colourGrey = BMPColourTableGrey[1];
                                        }
                                        // If the bit is clear, use colour 0
                                        else
                                        {
                                            colourGrey = BMPColourTableGrey[0];
                                        }
                                        BMPImageDataGrey[iRow, iCol++] = colourGrey;
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
        /// Calculates greyscale value from the three RGB values.
        /// The 'colours' are inverted first.
        /// </summary>
        /// <param name="iR"></param>
        /// <param name="iG"></param>
        /// <param name="iB"></param>
        /// <returns></returns>
        private static short CalcGreyData(byte iR, byte iG, byte iB)
        {
            // Use NTSC calculation for greyscale from the three R, G, B values. Invert the colours
            short grey = (short)(((0.299 * (byte)~iR) + (0.587 * (byte)~iG) + (0.114 * (byte)~iB)) * 128);
            return grey;
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
		public int samplesPerPixel;
		public int samplesPerStep;
		public double realSamplesPerStep;
		public double realSamplesPerPixel;
		public double errorSamplesPerStep;
		public double errorSamplesPerPixel;
		public double currErrorSamples;
        public double maxAngle;
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
			double idsLPcm, double iTTrpm, 
			int iSamplesPerPixel
			)
        {
			dsOuterRadiusCm = idsOuterRadiusCm;
			dsInnerRadiusCm = idsInnerRadiusCm;
			dsLPcm = idsLPcm;
			TTrpm = iTTrpm;
            samplesPerPixel = iSamplesPerPixel;
			numLines = (dsOuterRadiusCm - dsInnerRadiusCm) * dsLPcm;
            samplesPerRev = (int)(Constants.SampleRate * 60 / TTrpm);
            angStep = 2.0 * Math.PI * samplesPerPixel / samplesPerRev;
            maxAngle = 2.0 * Math.PI * (numLines + 1);
			sampleData = new List<byte>();
	
		}

        /// <summary>
        /// Once the WAVAdmin object has been created, this method is called.
        /// It extracts an annular section of the input BMP, starting from halfway down the
        /// RHS of the image, moving anticlockwise and slowly spiralling inward at the
        /// specified groove pitch until the specified inner radius is reached.
        /// </summary>
		public void PrepareWAV()
        {
			int imCentreX = BMPAdmin.BMPHdr.WidthPx / 2;
			int imCentreY = BMPAdmin.BMPHdr.HeightPx / 2;
			double imStartRadius = Math.Min(imCentreX - 1, imCentreY - 1);
			double imEndRadius = imStartRadius * dsInnerRadiusCm / dsOuterRadiusCm;
			double imStep = (imStartRadius - imEndRadius) / numLines;
			int imRow, imCol;
            double theta = 0;
            double thetaMod2PI = 0;
            double r = imStartRadius;
            // Traverse the image from edge towards the centre
            while (theta <= maxAngle)
            {
				// Calculate the row (y) of the BMP to use. As theta moves from
				// 0 to 2*PI, the radius as calculated in the second term 
				// gradually decreases by one imStep - effectively describing one
				// revolution of a spiral.
				imRow = (int)(Math.Sin(theta) * (r - (thetaMod2PI * imStep / (2 * Math.PI))));
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
				imCol = (int)(imCentreX + Math.Cos(theta) * (r - (thetaMod2PI * imStep / (2 * Math.PI))));

                CreateTone(BMPAdmin.BMPImageDataGrey[imRow, imCol]);

                // Increase angle 
                theta += angStep;
                // Keep a note of angle reduced modulo (2 * PI)
                thetaMod2PI += angStep;
                // If the reduced angle reaches 2 * PI then a full circle has been traversed.
                // Ensure that the reduced angle stays within 0 .. (2 * PI) and reduce the radius 
                // by the calculated step.
                if (thetaMod2PI >= 2 * Math.PI)
                {
                    r -= imStep;
                    thetaMod2PI -= 2 * Math.PI;
                    // Report progress back to the main form
                    FireEventProgressChanged((int)(100 * (imStartRadius - r) / (imStartRadius - imEndRadius)));
                }
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
		public void CreateTone(short iAmplMultiplier)
        {
			// Create the right number of samples 
			for (int iSamp = 0;iSamp < samplesPerPixel;iSamp++)
            {
				// Create a sine wave, calculating the amplitude from the greyscale data held for the specified pixel.
				// The Sine function returns a value in -1...1, which is multiplied by the greyscale value
				// to give a value in the range -32640...32639
				short ampl = (short)(Math.Sin(2.0d * Math.PI * iSamp / samplesPerPixel) * iAmplMultiplier);
 				// Add new data point to WAV data
				sampleData.Add((byte)(ampl & 0xFF));
				sampleData.Add((byte)((ampl >> 8) & 0xFF));
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
