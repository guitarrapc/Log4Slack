using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Log4Slack
{
    public struct Colors
    {
        public static Color Empty => new Color(0x00000000);
        public static Color AliceBlue = new Color(0xFFF0F8FF);
        public static Color AntiqueWhite = new Color(0xFFFAEBD7);
        public static Color Aqua = new Color(0xFF00FFFF);
        public static Color Aquamarine = new Color(0xFF7FFFD4);
        public static Color Azure = new Color(0xFFF0FFFF);
        public static Color Beige = new Color(0xFFF5F5DC);
        public static Color Bisque = new Color(0xFFFFE4C4);
        public static Color Black = new Color(0xFF000000);
        public static Color BlanchedAlmond = new Color(0xFFFFEBCD);
        public static Color Blue = new Color(0xFF0000FF);
        public static Color BlueViolet = new Color(0xFF8A2BE2);
        public static Color Brown = new Color(0xFFA52A2A);
        public static Color BurlyWood = new Color(0xFFDEB887);
        public static Color CadetBlue = new Color(0xFF5F9EA0);
        public static Color Chartreuse = new Color(0xFF7FFF00);
        public static Color Chocolate = new Color(0xFFD2691E);
        public static Color Coral = new Color(0xFFFF7F50);
        public static Color CornflowerBlue = new Color(0xFF6495ED);
        public static Color Cornsilk = new Color(0xFFFFF8DC);
        public static Color Crimson = new Color(0xFFDC143C);
        public static Color Cyan = new Color(0xFF00FFFF);
        public static Color DarkBlue = new Color(0xFF00008B);
        public static Color DarkCyan = new Color(0xFF008B8B);
        public static Color DarkGoldenrod = new Color(0xFFB8860B);
        public static Color DarkGray = new Color(0xFFA9A9A9);
        public static Color DarkGreen = new Color(0xFF006400);
        public static Color DarkKhaki = new Color(0xFFBDB76B);
        public static Color DarkMagenta = new Color(0xFF8B008B);
        public static Color DarkOliveGreen = new Color(0xFF556B2F);
        public static Color DarkOrange = new Color(0xFFFF8C00);
        public static Color DarkOrchid = new Color(0xFF9932CC);
        public static Color DarkRed = new Color(0xFF8B0000);
        public static Color DarkSalmon = new Color(0xFFE9967A);
        public static Color DarkSeaGreen = new Color(0xFF8FBC8B);
        public static Color DarkSlateBlue = new Color(0xFF483D8B);
        public static Color DarkSlateGray = new Color(0xFF2F4F4F);
        public static Color DarkTurquoise = new Color(0xFF00CED1);
        public static Color DarkViolet = new Color(0xFF9400D3);
        public static Color DeepPink = new Color(0xFFFF1493);
        public static Color DeepyBlue = new Color(0xFF00BFFF);
        public static Color DimGray = new Color(0xFF696969);
        public static Color DodgerBlue = new Color(0xFF1E90FF);
        public static Color Firebrick = new Color(0xFFB22222);
        public static Color FloralWhite = new Color(0xFFFFFAF0);
        public static Color ForestGreen = new Color(0xFF228B22);
        public static Color Fuchsia = new Color(0xFFFF00FF);
        public static Color Gainsboro = new Color(0xFFDCDCDC);
        public static Color GhostWhite = new Color(0xFFF8F8FF);
        public static Color Gold = new Color(0xFFFFD700);
        public static Color Goldenrod = new Color(0xFFDAA520);
        public static Color Gray = new Color(0xFF808080);
        public static Color Green = new Color(0xFF008000);
        public static Color GreenYellow = new Color(0xFFADFF2F);
        public static Color Honeydew = new Color(0xFFF0FFF0);
        public static Color HotPink = new Color(0xFFFF69B4);
        public static Color IndianRed = new Color(0xFFCD5C5C);
        public static Color Indigo = new Color(0xFF4B0082);
        public static Color Ivory = new Color(0xFFFFFFF0);
        public static Color Khaki = new Color(0xFFF0E68C);
        public static Color Lavender = new Color(0xFFE6E6FA);
        public static Color LavenderBlush = new Color(0xFFFFF0F5);
        public static Color LawnGreen = new Color(0xFF7CFC00);
        public static Color LemonChiffon = new Color(0xFFFFFACD);
        public static Color LightBlue = new Color(0xFFADD8E6);
        public static Color LightCoral = new Color(0xFFF08080);
        public static Color LightCyan = new Color(0xFFE0FFFF);
        public static Color LightGoldenrodYellow = new Color(0xFFFAFAD2);
        public static Color LightGray = new Color(0xFFD3D3D3);
        public static Color LightGreen = new Color(0xFF90EE90);
        public static Color LightPink = new Color(0xFFFFB6C1);
        public static Color LightSalmon = new Color(0xFFFFA07A);
        public static Color LightSeaGreen = new Color(0xFF20B2AA);
        public static Color LightyBlue = new Color(0xFF87CEFA);
        public static Color LightSlateGray = new Color(0xFF778899);
        public static Color LightSteelBlue = new Color(0xFFB0C4DE);
        public static Color LightYellow = new Color(0xFFFFFFE0);
        public static Color Lime = new Color(0xFF00FF00);
        public static Color LimeGreen = new Color(0xFF32CD32);
        public static Color Linen = new Color(0xFFFAF0E6);
        public static Color Magenta = new Color(0xFFFF00FF);
        public static Color Maroon = new Color(0xFF800000);
        public static Color MediumAquamarine = new Color(0xFF66CDAA);
        public static Color MediumBlue = new Color(0xFF0000CD);
        public static Color MediumOrchid = new Color(0xFFBA55D3);
        public static Color MediumPurple = new Color(0xFF9370DB);
        public static Color MediumSeaGreen = new Color(0xFF3CB371);
        public static Color MediumSlateBlue = new Color(0xFF7B68EE);
        public static Color MediumSpringGreen = new Color(0xFF00FA9A);
        public static Color MediumTurquoise = new Color(0xFF48D1CC);
        public static Color MediumVioletRed = new Color(0xFFC71585);
        public static Color MidnightBlue = new Color(0xFF191970);
        public static Color MintCream = new Color(0xFFF5FFFA);
        public static Color MistyRose = new Color(0xFFFFE4E1);
        public static Color Moccasin = new Color(0xFFFFE4B5);
        public static Color NavajoWhite = new Color(0xFFFFDEAD);
        public static Color Navy = new Color(0xFF000080);
        public static Color OldLace = new Color(0xFFFDF5E6);
        public static Color Olive = new Color(0xFF808000);
        public static Color OliveDrab = new Color(0xFF6B8E23);
        public static Color Orange = new Color(0xFFFFA500);
        public static Color OrangeRed = new Color(0xFFFF4500);
        public static Color Orchid = new Color(0xFFDA70D6);
        public static Color PaleGoldenrod = new Color(0xFFEEE8AA);
        public static Color PaleGreen = new Color(0xFF98FB98);
        public static Color PaleTurquoise = new Color(0xFFAFEEEE);
        public static Color PaleVioletRed = new Color(0xFFDB7093);
        public static Color PapayaWhip = new Color(0xFFFFEFD5);
        public static Color PeachPuff = new Color(0xFFFFDAB9);
        public static Color Peru = new Color(0xFFCD853F);
        public static Color Pink = new Color(0xFFFFC0CB);
        public static Color Plum = new Color(0xFFDDA0DD);
        public static Color PowderBlue = new Color(0xFFB0E0E6);
        public static Color Purple = new Color(0xFF800080);
        public static Color Red = new Color(0xFFFF0000);
        public static Color RosyBrown = new Color(0xFFBC8F8F);
        public static Color RoyalBlue = new Color(0xFF4169E1);
        public static Color SaddleBrown = new Color(0xFF8B4513);
        public static Color Salmon = new Color(0xFFFA8072);
        public static Color SandyBrown = new Color(0xFFF4A460);
        public static Color SeaGreen = new Color(0xFF2E8B57);
        public static Color SeaShell = new Color(0xFFFFF5EE);
        public static Color Sienna = new Color(0xFFA0522D);
        public static Color Silver = new Color(0xFFC0C0C0);
        public static Color yBlue = new Color(0xFF87CEEB);
        public static Color SlateBlue = new Color(0xFF6A5ACD);
        public static Color SlateGray = new Color(0xFF708090);
        public static Color Snow = new Color(0xFFFFFAFA);
        public static Color SpringGreen = new Color(0xFF00FF7F);
        public static Color SteelBlue = new Color(0xFF4682B4);
        public static Color Tan = new Color(0xFFD2B48C);
        public static Color Teal = new Color(0xFF008080);
        public static Color Thistle = new Color(0xFFD8BFD8);
        public static Color Tomato = new Color(0xFFFF6347);
        public static Color Turquoise = new Color(0xFF40E0D0);
        public static Color Violet = new Color(0xFFEE82EE);
        public static Color Wheat = new Color(0xFFF5DEB3);
        public static Color White = new Color(0xFFFFFFFF);
        public static Color WhiteSmoke = new Color(0xFFF5F5F5);
        public static Color Yellow = new Color(0xFFFFFF00);
        public static Color YellowGreen = new Color(0xFF9ACD32);
        public static Color Transparent = new Color(0x00FFFFFF);
    }

    public struct Color
    {
        private const float EPSILON = 0.001f;

        public static readonly Color Empty;
        private uint color;
        public byte Alpha => (byte)((color >> 24) & 0xff);
        public byte Red => (byte)((color >> 16) & 0xff);
        public byte Green => (byte)((color >> 8) & 0xff);
        public byte Blue => (byte)((color) & 0xff);
        public float Hue
        {
            get
            {
                ToHsv(out var h, out var s, out var v);
                return h;
            }
        }

        /// <summary>
        /// ARGB
        /// </summary>
        /// <param name="value"></param>
        public Color(uint value) => color = value;
        /// <summary>
        /// RGBA
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        public Color(byte red, byte green, byte blue, byte alpha) => color = (uint)((alpha << 24) | (red << 16) | (green << 8) | blue);
        /// <summary>
        /// RGB (A == 0xFF)
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Color(byte red, byte green, byte blue) => color = (0xff000000u | (uint)(red << 16) | (uint)(green << 8) | blue);

        // Hsl
        public void ToHsl(out float h, out float s, out float l)
        {
            // RGB from 0 to 255
            var r = (Red / 255f);
            var g = (Green / 255f);
            var b = (Blue / 255f);

            var min = Math.Min(Math.Min(r, g), b); // min value of RGB
            var max = Math.Max(Math.Max(r, g), b); // max value of RGB
            var delta = max - min; // delta RGB value

            // default to a gray, no chroma...
            h = 0f;
            s = 0f;
            l = (max + min) / 2f;

            // chromatic data...
            if (Math.Abs(delta) > EPSILON)
            {
                s = l < 0.5f ? delta / (max + min) : delta / (2f - max - min);

                var deltaR = (((max - r) / 6f) + (delta / 2f)) / delta;
                var deltaG = (((max - g) / 6f) + (delta / 2f)) / delta;
                var deltaB = (((max - b) / 6f) + (delta / 2f)) / delta;

                if (Math.Abs(r - max) < EPSILON)
                {
                    // r == max
                    h = deltaB - deltaG;
                }
                else if (Math.Abs(g - max) < EPSILON)
                {
                    // g == max
                    h = (1f / 3f) + deltaR - deltaB;
                }
                else
                {
                    // b == max
                    h = (2f / 3f) + deltaG - deltaR;
                }

                if (h < 0f)
                    h += 1f;
                if (h > 1f)
                    h -= 1f;
            }

            // convert to percentages
            h = h * 360f;
            s = s * 100f;
            l = l * 100f;
        }

        public static Color FromHsl(float h, float s, float l, byte a = 255)
        {
            // convert from percentages
            h = h / 360f;
            s = s / 100f;
            l = l / 100f;

            // RGB results from 0 to 255
            var r = l * 255f;
            var g = l * 255f;
            var b = l * 255f;

            // HSL from 0 to 1
            if (Math.Abs(s) > EPSILON)
            {
                var v2 = l < 0.5f ? l * (1f + s) : (l + s) - (s * l);
                var v1 = 2f * l - v2;

                r = 255 * HueToRgb(v1, v2, h + (1f / 3f));
                g = 255 * HueToRgb(v1, v2, h);
                b = 255 * HueToRgb(v1, v2, h - (1f / 3f));
            }

            return new Color((byte)r, (byte)g, (byte)b, a);
        }

        private static float HueToRgb(float v1, float v2, float vH)
        {
            if (vH < 0f)
                vH += 1f;
            if (vH > 1f)
                vH -= 1f;

            if ((6f * vH) < 1f)
            {
                return (v1 + (v2 - v1) * 6f * vH);
            }
            if ((2f * vH) < 1f)
            {
                return (v2);
            }
            if ((3f * vH) < 2f)
            {
                return (v1 + (v2 - v1) * ((2f / 3f) - vH) * 6f);
            }

            return (v1);
        }

        // Hsv
        public void ToHsv(out float h, out float s, out float v)
        {
            // RGB from 0 to 255
            var r = (Red / 255f);
            var g = (Green / 255f);
            var b = (Blue / 255f);

            var min = Math.Min(Math.Min(r, g), b); // min value of RGB
            var max = Math.Max(Math.Max(r, g), b); // max value of RGB
            var delta = max - min; // delta RGB value 

            // default to a gray, no chroma...
            h = 0;
            s = 0;
            v = max;

            // chromatic data...
            if (Math.Abs(delta) > EPSILON)
            {
                s = delta / max;

                var deltaR = (((max - r) / 6f) + (delta / 2f)) / delta;
                var deltaG = (((max - g) / 6f) + (delta / 2f)) / delta;
                var deltaB = (((max - b) / 6f) + (delta / 2f)) / delta;

                if (Math.Abs(r - max) < EPSILON)
                {
                    // r == max
                    h = deltaB - deltaG;
                }
                else if (Math.Abs(g - max) < EPSILON)
                {
                    // g == max
                    h = (1f / 3f) + deltaR - deltaB;
                }
                else
                {
                    // b == max
                    h = (2f / 3f) + deltaG - deltaR;
                }

                if (h < 0f)
                {
                    h += 1f;
                }
                if (h > 1f)
                {
                    h -= 1f;
                }
            }

            // convert to percentages
            h = h * 360f;
            s = s * 100f;
            v = v * 100f;
        }

        public static Color FromHsv(float h, float s, float v, byte a = 255)
        {
            // convert from percentages
            h = h / 360f;
            s = s / 100f;
            v = v / 100f;

            // RGB results from 0 to 255
            var r = v;
            var g = v;
            var b = v;

            // HSL from 0 to 1
            if (Math.Abs(s) > EPSILON)
            {
                h = h * 6f;
                if (Math.Abs(h - 6f) < EPSILON)
                    h = 0f; // H must be < 1

                var hInt = (int)h;
                var v1 = v * (1f - s);
                var v2 = v * (1f - s * (h - hInt));
                var v3 = v * (1f - s * (1f - (h - hInt)));

                switch (hInt)
                {
                    case 0:
                        r = v;
                        g = v3;
                        b = v1;
                        break;
                    case 1:
                        r = v2;
                        g = v;
                        b = v1;
                        break;
                    case 2:
                        r = v1;
                        g = v;
                        b = v3;
                        break;
                    case 3:
                        r = v1;
                        g = v2;
                        b = v;
                        break;
                    case 4:
                        r = v3;
                        g = v1;
                        b = v;
                        break;
                    default:
                        r = v;
                        g = v1;
                        b = v2;
                        break;
                }
            }

            // RGB results from 0 to 255
            r = r * 255f;
            g = g * 255f;
            b = b * 255f;

            return new Color((byte)r, (byte)g, (byte)b, a);
        }
        public static bool operator ==(Color left, Color right) => left.color == right.color;

        public static bool operator !=(Color left, Color right) => !(left == right);

        public override string ToString() => string.Format(CultureInfo.InvariantCulture, "#{0:x2}{1:x2}{2:x2}{3:x2}", Alpha, Red, Green, Blue);

        public override bool Equals(object other)
        {
            if (!(other is Color))
                return false;

            var c = (Color)other;
            return c.color == this.color;
        }
        public override int GetHashCode() => (int)color;
    }


    public static class ColorKnown
    {
        private static Lazy<Dictionary<string, Color>> knownColors = new Lazy<Dictionary<string, Color>>(() => typeof(Colors)
            .GetFields(BindingFlags.Static | BindingFlags.Public)
            .ToDictionary(kv => kv.Name, kv => (Color)kv.GetValue(null)));

        public static Color FromName(string nameOrHex) => FromName(nameOrHex, Color.Empty);
        public static Color FromName(string nameOrHex, Color defaultColor)
        {
            if (knownColors.Value.TryGetValue(nameOrHex, out var color))
            {
                return color;
            }
            else
            {
                var hex = nameOrHex.StartsWith("#")
                    ? nameOrHex.Substring(1, nameOrHex.Length - 1)
                    : nameOrHex;
                try
                {
                    return new Color(Convert.ToUInt32(hex, 16));
                }
                catch (Exception)
                {
                    return defaultColor;
                }
            }
        }
        public static bool IsKnownColor(this Color color) => color != Color.Empty;
    }
}
