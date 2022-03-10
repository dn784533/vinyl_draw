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

using System.Reflection;
using System.Windows.Forms;

namespace VinylDraw
{
    public partial class Help : Form
    {
        public const string help1 = "This program takes as input a graphic file in BMP format and produces as output a sound file in WAV format. " +
            "If the sound file is inscribed on to a disc record using a lathe, an approximation of the original image should (if things are working " +
            "well) be presented as visible sound wave patterns in the inscribed surface. The portion of the original image that will be inscribed " +
            "is limited to a circular ring section whose outer diameter is the same as the shorter of the rectangular dimensions of the image. The thickness " +
            "of the ring is determined by the disc cutting parameters listed below.\r\n\r\n24-bit BMPs are supported. 16- and 32-bit BMPs are NOT supported. Lower " +
            "bit-rates (1, 4, 8) may work, but are not guaranteed to.";
        public const string help2 = "Disc Cutting parameters:\r\n\r\nStart Radius - on the blank disc, the radius " +
            "at which the inscription will start.\r\n\r\nEnd Radius - on the blank disc, the radius at which the inscription will end. This should be the end of " +
            "the recorded programme material, not the locked groove.\r\n\r\nLines / cm - the number of windings of the groove that will occupy each " +
            "linear centimetre of radius.\r\n\r\nTurntable RPM - the speed of the recording lathe platter.\r\n\r\n" +
            "Samples / pixel - the number of WAV file samples that will be used to represent each pixel of the image. " +
            "This number is divided in to the sample rate (usually 44100) to determine the frequency of the output waveform.";
        public const string help3 = "BMP File Details\r\n\r\n" +
            "These details are filled in when the selected BMP file has successfully loaded.";
        public const string help4 = "Resolution and Colours\r\n\r\n" +
            "An attempt is made to represent colour by calculating a greyscale value for each point, using the NTSC standard weightings " +
            "for R, G and B values. The frequency of the output waveform is constant, based on the user setting of 'Samples / pixel' above, " +
            "but the amplitude varies depending on the greyscale value calculated for each point. " +
            "Bear in mind that although this allows (in theory) images of 16.7 million colours to " +
            "be used as input material, such images may not translate well when reduced to just one colour (i.e. black)!";
        public string help5 = "This version built " + BMPtoWAV.Properties.Resources.BuildDate + "Copyright © David Nelson, 2022." +
            " Acknowledgement: Markrob at Lathe Trolls for the NTSC greyscale calculation.";

        public Help()
        {
            InitializeComponent();
            txtHelp1.Text = help1;
            txtHelp2.Text = help2;
            txtHelp3.Text = help3;
            txtHelp4.Text = help4;
            txtHelp5.Text = help5;
         }


    }
}
