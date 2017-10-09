using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace closest_color
{
    class ClosestColor
    {
        //
        // https://stackoverflow.com/questions/27374550/how-to-compare-color-object-and-get-closest-color-in-an-color
        //
        public float factorHue_ { set; get; }
        public float factorSat_ { set; get; }
        public float factorLum_ { set; get; }

        // sort by RGB distance
        public void sortClosestColorRGB(ref List<Color> colors, Color target)
        {
            colors.Sort(
                (c1, c2) => getRGBDiff(c1, target) - getRGBDiff(c2, target)
            );
        }
        // sort by weighed distance using hue, saturation and brightness
        public void sortClosestColorHSL(ref List<Color> colors, Color target)
        {
            colors.Sort(
                (c1, c2) => (int)
                    (
                        (
                            getDistanceHueSatLum(c1, target) - getDistanceHueSatLum(c2, target)
                        ) * (2 << 16)
                    )
            );
        }

        //
        // helper
        //

        // Brightness considering heuristics
        private float getLuminosity(Color c)
        { 
            return (c.R * 0.298912f + c.G * 0.586611f + c.B * 0.114478f) / 256f; 
        }

        // distance onyl by Hue
        private float getHueDistance(float hue1, float hue2)
        {
            float d = Math.Abs(hue1 - hue2);
            return ((d > 180f) ? 360f - d : d);
        }

        // weighed by hue, saturation and brightness (with factors from TrackBar)
        private float getDistanceHueSatLum(Color c1, Color c2)
        {
            float d =
                getHueDistance(c1.GetHue(), c2.GetHue()) / 180f * factorHue_ // 0.0 <= getHueDistance() <= 180.0
                + Math.Abs(c1.GetSaturation() - c2.GetSaturation()) * factorSat_ // 0.0 <= GetSaturation() <= 1.0
                + Math.Abs(getLuminosity(c1) - getLuminosity(c2)) * factorLum_ //  // 0.0 <= getLuminosity() <= 1.0
            ;
            return d;
        }

        // distance in RGB space
        private int getRGBDiff(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }
    
    }
}
