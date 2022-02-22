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
            "of the ring is determined by the disc cutting parameters listed below.";
        public const string help2 = "Disc Cutting parameters:\r\n\r\nStart Radius - on the blank disc, the radius " +
            "at which the inscription will start.\r\n\r\nEnd Radius - on the blank disc, the radius at which the inscription will end. This should be the end of " +
            "the recorded programme material, not the locked groove.\r\n\r\nLines / cm - the number of windings of the groove that will occupy each " +
            "linear centimetre of radius.\r\n\r\nTurntable RPM - the speed of the recording lathe platter.";
        public const string help3 = "BMP File Details\r\n\r\n" +
            "The details on this panel are filled in when the selected BMP file has successfully loaded.";
        public const string help4 = "Resolution and Colours\r\n\r\n" +
            "Steps / rev - the annular part of the image that will be inscribed is processed in a spiral, starting at the edge and moving gradually inward, the "+
            "tightness of the spiral being determined by the 'Lines / cm' setting above. Within each winding of the spiral, the image will be sampled at data points " +
            "at the rate specified here. Allowed values are 180, 360, 540 and 720.\r\n\r\n" +
            "An attempt is made to represent colour by calculating hue, saturation and luminosity for each point. The hue value - a circular scale running from 0 to 360 - " +
            "is used to determine the frequency of the waveform that will be created for that point. The frequencies for 0 and 360 can be set on this panel, and the intermediate " +
            "frequency values are interpolated logarithmically. The amplitude of the recorded wave can be set to depend on luminosity (recommended) or saturation. " +
            "Bear in mind that although this allows (in theory) images of 16.7 million colours to " +
            "be used as input material, such images may not translate well when reduced to just one colour (i.e. black)!";
        public string help5 = "This version built " + BMPtoWAV.Properties.Resources.BuildDate + "Copyright © David Nelson, 2022.";

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
