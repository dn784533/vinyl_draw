Disclaimer:
=========== 
This program is provided free and as-is, with no warranty of any kind! No responsibility will be accepted by the author for any mishaps caused by using it.


Sub-directories in this package:
================================
Vinyl Draw - contains the Windows installer (run setup.exe) for the end-user application.
BMPtoWAV - contains the C# source files, except the top-level solution file (VinylDraw.sln) which is in the same directory as this document.
Extras - see next para.

Files in 'Extras' directory:
============================
vinyl_draw_test_image.bmp - a sample BMP for testing.
vinyl_draw_test_record.jpg - a photo of a clear polycarbonate record made from a sound file created by Vinyl Draw using the sample BMP.


Some points:
============
- The source was developed in C# using Visual Studio 2019. It requires .NET framework 4.7.2. 
- If the application is installed using the setup.exe file, .NET framework 4.7.2 will automatically be prompted for and downloaded from Internet and installed, if it is not already present.
- The program has been tested (on Windows 10) using 24-bit RGB uncompressed bitmaps only. Compressed BMPs are not supported.


Brief instructions:
===================
1. Start the program.
2. Load your source image using File->Open BMP. 
3. In the 'Disc Cutting Parameters' group, adjust the values as required. (The default values are for a 7-inch (175mm) 45 rpm record.)
4. The 'Samples / pixel' setting can  be altered to change the resolution of the scanned image. Changing this value alters the frequency of the waveform output. 
5. Click 'Create WAV data'. The data file is created in memory.
6. Save the WAV data file using File->Save WAV.

The file will need EQ, IRIAA, etc applied as usual, as required, before cutting. Try at low volume first! Be aware that these sound files are unpleasant to listen to, sounding like several minutes of old dial-up modem noises.
