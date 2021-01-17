using System.Drawing;

namespace Praja.Lib
{
  public class ConversionUtils
  {
    public static Color ColorFromHex(string hex)
    {
      var red = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
      var green = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
      var blue = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
      return Color.FromArgb(red, green, blue);
    }

    public static string ColorToHex(Color color)
    {
      var rgb = color.ToArgb();
      var red = (rgb & 0xff0000) / 0x10000;
      var green = (rgb & 0xff00) / 0x100;
      var blue = rgb & 0xFF;
      return string.Format("{0:x2}{1:x2}{2:X2}", red, green, blue);
    }
  }
}
