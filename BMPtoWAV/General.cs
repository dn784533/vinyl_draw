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
		public const int dfltRfreq = 500;
		public const int dfltGfreq = 1000;
		public const int dfltBfreq = 2000;
		public const int dfltRpcent = 33;
		public const int dfltGpcent = 33;
		public const int dfltBpcent = 34;
		public const int dfltLPcm = 80;
		public const int dfltAnglePStep = 1;
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
			int height, width, wMod;
			bh.Id = br.ReadInt16();
			bh.FileLength = br.ReadInt32();
			bh.Unused = br.ReadInt32();
			bh.BmpOffset = br.ReadInt32();
			bh.DibHeaderLength = br.ReadInt32();
			width = br.ReadInt32();
			wMod = 4 - (width % 4);
			if (wMod < 4) width += wMod;
			bh.WidthPx = width;
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
    /// Holds R/G/B data for a single point in the image.
    /// A List of bmpRGBData is used to hold the colour table
    /// for sub-16-bit BMPs.
    /// </summary>
	public struct bmpRGBData
    {
		public byte[] values;

		public bmpRGBData(byte[] iData, bool iReverse) : this()
        {
			values = new byte[3];
			if (!iReverse)
			{
				values[0] = iData[0];
				values[1] = iData[1];
				values[2] = iData[2];
			}
			else
            {
				values[0] = iData[2];
				values[1] = iData[1];
				values[2] = iData[0];
			}
        }
		public bmpRGBData(byte iR, byte iG, byte iB)
		{
			values = new byte[3];
			values[0] = iR;
			values[1] = iG;
			values[2] = iB;
		}
	}
	public static class BMPAdmin
    {
		public static bmpHeader BMPHdr;
		public static List<bmpRGBData> BMPColourTable;
		public static bmpRGBData[,] BMPImageData { get; set; }

        /// <summary>
        /// Open and read a BMP file into memory.
        /// </summary>
        /// <param name="iFileName"></param>
		public static void OpenBMPFile(string iFileName)
        {
			byte[] data = new byte[0x36];
			int bytesRead = 0;
			BMPHdr = new bmpHeader();
			using (FileStream fs = new FileStream(iFileName, FileMode.Open))
            {
				// Read the first 0x36 bytes and populate the BMP header struct
				bytesRead = fs.Read(data, 0, 0x36);
				BMPHdr = bmpHeader.Populate(data);

				// Check for errors in file
				if (BMPHdr.Id != 0x4D42) throw new Exception("Not recognised as a BMP file");
				if (BMPHdr.Compression != 0) throw new Exception("Compressed BMPs are not supported at present!");
				// Define image array size now dimensions are known
				BMPImageData = new bmpRGBData[BMPHdr.HeightPx, BMPHdr.WidthPx];
				// If there are fewer than 16 bits per pixel then there should be a colour table comprising
				// four bytes for each colour specified. Only three bytes are used, for R, G and B values.
				if (BMPHdr.BitsPerPx < 16)
                {
                    try
                    {
                        BMPColourTable = new List<bmpRGBData>();
                        fs.Position = 0x0E + BMPHdr.DibHeaderLength; // Set position to start of colour table
                        for (int i = 0; i < BMPHdr.ColoursInPalette; i++)
                        {
                            bytesRead = fs.Read(data, 0, 4);
                            BMPColourTable.Add(new bmpRGBData(data, true));
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
				// each pixel as a bmpRGBData struct
				for (int iRow = 0;iRow < BMPHdr.HeightPx;iRow++)
                {
					for (int iCol = 0; iCol < BMPHdr.WidthPx;)
					{
						switch (BMPHdr.BitsPerPx)
						{
							case 24:
								bytesRead = fs.Read(data, 0, 3);
								// Add the three byte values to the image data, reversing the order for B, G, R
								BMPImageData[iRow, iCol++] = new bmpRGBData(data, true);
								break;
							case 16:
								bytesRead = fs.Read(data, 0, 2);
								// Chop up the 2 bytes read into three sets of 5-bit values. Need explicit casts back to byte because bitwise operators
								// return int types. The two bytes contain data thus: GGGBBBBB, xRRRRRGG.
								BMPImageData[iRow, iCol++] = new bmpRGBData((byte)((data[1] & 0x7C) >> 2), (byte)(((data[1] & 0x03) << 3) & (data[0] >> 5)), (byte)(data[0] & 0x1F));
								break;
							case 8:
								bytesRead = fs.Read(data, 0, 1);
								// Use colour table to retrieve the RGB values
								bmpRGBData colour = BMPColourTable[data[0]];
								BMPImageData[iRow, iCol++] = new bmpRGBData(colour.values[0], colour.values[1], colour.values[2]);
								break;
							case 4:
								bytesRead = fs.Read(data, 0, 1);
								colour = BMPColourTable[(byte)(data[0] >> 4)];
								BMPImageData[iRow, iCol++] = new bmpRGBData(colour.values[0], colour.values[1], colour.values[2]);
								colour = BMPColourTable[(byte)(data[0] & 0x0F)];
								BMPImageData[iRow, iCol++] = new bmpRGBData(colour.values[0], colour.values[1], colour.values[2]);
								break;
							case 1:
								bytesRead = fs.Read(data, 0, 4);
                                // Iterate through each of the four bytes read
                                for (int offset = 0; offset <= 3; offset++)
                                {
                                    // Iterate through each of the 8 bits, starting with the MSB
                                    for (byte msk = 128; msk > 0; msk >>= 1)
                                    {
                                        if (iCol > BMPHdr.WidthPx - 1)
                                            continue;
                                        // If the bit is set, use colour 1
                                        if ((data[offset] & msk) > 0) colour = BMPColourTable[1];
                                        // If the bit is clear, use colour 0
                                        else colour = BMPColourTable[0];
                                        BMPImageData[iRow, iCol++] = new bmpRGBData(colour.values[0], colour.values[1], colour.values[2]);
                                    }
                                }
								break;
                            default:
                                throw new Exception("Bits per BMP pixel must be 1, 4, 8, 16 or 24");
						}
                    }
				}
				fs.Close();
			}

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
		public int[] numSampPerWave;
		public int samplesPerRev;
		public int samplesPerStep;
		public double realSamplesPerStep;
		public double errorSamplesPerStep;
		public double currErrorSamples;
		public int samplesTotal;
		public int sampleBytes;
		public int fileSize;
		public List<byte> sampleData;
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
        /// <param name="iangStepDeg"></param>
        /// <param name="ifR"></param>
        /// <param name="ifG"></param>
        /// <param name="ifB"></param>
        /// <param name="idR"></param>
        /// <param name="idG"></param>
        /// <param name="idB"></param>
		public WAVAdmin(double idsOuterRadiusCm, double idsInnerRadiusCm,
			double idsLPcm, double iTTrpm, int iangStepDeg, 
			int ifR, int ifG, int ifB,
			int idR, int idG, int idB
			)
        {
            amplSign = -1;
			dsOuterRadiusCm = idsOuterRadiusCm;
			dsInnerRadiusCm = idsInnerRadiusCm;
			dsLPcm = idsLPcm;
			TTrpm = iTTrpm;
			numLines = (dsOuterRadiusCm - dsInnerRadiusCm) * dsLPcm;
			stepDuration = (angStep * 30) / (Math.PI * TTrpm);
			stepsPerRev = 360 / iangStepDeg; //iangStepDeg must divide exactly into 360 - this allows 1 to 6 as angular steps, but not 7
			angStep = iangStepDeg * Math.PI / 180.0d;
			samplesPerRev = (int)(Constants.SampleRate * 60 / TTrpm);
			// The 'real' number of samples required for an angular step - may not be an integer
			realSamplesPerStep = angStep * samplesPerRev / (2.0d * Math.PI);
			// Rounded down to nearest integer
			samplesPerStep = (int)realSamplesPerStep;
			// And thus error that will accrue per step
			errorSamplesPerStep = realSamplesPerStep - samplesPerStep;
			sampleData = new List<byte>();
			// For each of the three colours, save the specified frequency
			// in the freq array
			freq = new int[3];
			freq[0] = ifR; 
			freq[1] = ifG; 
			freq[2] = ifB;
			// For each of the three colours, calculate the number of samples required
			// for a single angular step at the specified frequency.
			numSamples = new int[3];
			numSamples[0] = idR * samplesPerStep / 100;
			numSamples[1] = idG * samplesPerStep / 100;
			numSamples[2] = samplesPerStep - numSamples[1] - numSamples[0];
			numSampPerWave = new int[3];
			// For each of the three colours, calculate the number of samples required
			// for a single wavelength at the specified frequency.
			for (int iColour = 0; iColour < 3; iColour++)
			{
				numSampPerWave[iColour] = (int)(Constants.SampleRate / freq[iColour]);
			}

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

					CreateTone(BMPAdmin.BMPImageData[imRow, imCol]);
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
		public void CreateTone(bmpRGBData iData)
        {
            int flip;
			// Iterate through values for three colours
			for (int iColour=0;iColour<3;iColour++)
            {
				// Invert colours so "black" becomes "white" etc.
				byte invColour = (byte)~iData.values[iColour];
                // Invert sign of sine wave, if required, to avoid sudden V-shapes
                //  in waveform when moving from one colour to next
                flip = -amplSign;
				// Create the right number of samples for each colour 
				for (int iSamp=0;iSamp< numSamples[iColour];iSamp++)
                {
					// Create a sine wave, calculating the amplitude from the RGB data held for the specified pixel.
					// The Sine function returns a value in -1...1, which is multiplied by the value held for the colour
					// (0 - 255) and then multiplied by 128 to give a value in the range -32640...32640
					short ampl = (short)(Math.Sin(2.0d * Math.PI * iSamp / numSampPerWave[iColour]) * invColour * 128 * flip);

					// If we have reached the last few samples for this wave, reduce the amplitude progressively 
					// towards zero. This is to avoid sudden jumps in sample values from one wave to the next.
					double portionLeft = (double)1.0d - ((double)iSamp / (double)numSamples[iColour]);
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
