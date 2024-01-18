namespace TimeTabler.Models
{
    public class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public string HexValue { get; set; }

        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;

            HexValue = $"#{r:X2}{g:X2}{b:X2}";
        }

        public Color(string hexValue)
        {
            HexValue = hexValue;

            if (hexValue.StartsWith("#"))
            {
                hexValue = hexValue.Substring(1);
            }
            R = int.Parse(hexValue.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            G = int.Parse(hexValue.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            B = int.Parse(hexValue.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

        }

        public static Color White => new(255, 255, 255);
        public static Color Black => new(0, 0, 0);
        public static Color Red => new(255, 0, 0);
        public static Color Blue => new(0, 0, 255);
        public static Color Green => new(0, 255, 0);
        public static Color Yellow => new(255, 255, 0);
    }
}
