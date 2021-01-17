using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using Praja.Lib;

namespace MiniClock
{
  public class DisplayOptions
  {

    public Size FormSize { get; set; }
    public Color ForeColor { get; set; }
    public Color BackColor { get; set; }
    public Padding Padding { get; set; }
    public Font DisplayFont { get; set; }
    public string DisplayFormat { get; set; }
    public bool LockPosition { get; set; }
    public bool AutoStart { get; set; }

    public static void SetAutoStart(bool value)
    {
      var subkey = @"Software\Microsoft\Windows\CurrentVersion\Run";
      using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey, true)) {
        if (key != null) {
          if(value) {
            key.SetValue("MiniClock", Application.ExecutablePath);
          }
          else {
            key.DeleteValue("MiniClock");
          }
        }
      }
    }

    public static bool GetAutoStart()
    {
      var path = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
      var entry = (string) Registry.GetValue(path, "MiniClock", "");
      return entry == Application.ExecutablePath;
    }

    public static DisplayOptions CreateDefaultOptions()
    {
      var options = new DisplayOptions();
      options.FormSize = new Size(105, 16);
      options.Padding = new Padding(2, 0, 2, 0);
      options.ForeColor = Color.Black;
      options.BackColor = Color.White;
      options.DisplayFont = new Font("Tahoma", 8, FontStyle.Regular);
      options.DisplayFormat = "HH:mm:ss  ddd (dd)";
      options.LockPosition = true;
      options.AutoStart = true;

      return options;
    }

    public static DisplayOptions FromDict(Dictionary<string, object> dict)
    {
      var form_size = (Dictionary<string, object>)dict["form_size"];
      var padding = (Dictionary<string, object>)dict["padding"];
      var font_options = (Dictionary<string, object>)dict["display_font"];
      var font_bold = (bool)font_options["bold"];
      var font_italic = (bool)font_options["italic"];
      var font_underline = (bool)font_options["underline"];
      var font_style =
        (font_bold ? FontStyle.Bold : FontStyle.Regular)
        | (font_italic ? FontStyle.Italic : FontStyle.Regular)
        | (font_underline ? FontStyle.Underline : FontStyle.Regular);

      var options = new DisplayOptions();
      options.FormSize = new Size((int)((double)form_size["width"]), (int)((double)form_size["height"]));
      options.ForeColor = ConversionUtils.ColorFromHex((string)dict["fore_color"]);
      options.BackColor = ConversionUtils.ColorFromHex((string)dict["back_color"]);
      options.Padding = new Padding(
        (int)((double)padding["left"]), 
        (int)((double)padding["top"]), 
        (int)((double)padding["right"]), 
        (int)((double)padding["bottom"])
      );
      options.DisplayFont = new Font((string)font_options["name"], (float)((double)font_options["size"]), font_style);
      options.DisplayFormat = (string)dict["display_format"];
      options.LockPosition = (bool)dict["lock_position"];
      options.AutoStart = (bool)dict["auto_start"];

      return options;
    }

    public static Dictionary<string, object> ToDict(DisplayOptions options)
    {
      var form_size = new Dictionary<string, object>();
      form_size.Add("width", (object)options.FormSize.Width);
      form_size.Add("height", (object)options.FormSize.Height);

      var display_font = new Dictionary<string, object>();
      display_font.Add("name", options.DisplayFont.Name);
      display_font.Add("size", options.DisplayFont.Size);
      display_font.Add("bold", options.DisplayFont.Bold);
      display_font.Add("italic", options.DisplayFont.Italic);
      display_font.Add("underline", options.DisplayFont.Underline);

      var padding = new Dictionary<string, object>();
      padding.Add("left", options.Padding.Left);
      padding.Add("right", options.Padding.Right);
      padding.Add("top", options.Padding.Top);
      padding.Add("bottom", options.Padding.Bottom);

      var dict = new Dictionary<string, object>();
      dict.Add("form_size", (object)form_size);
      dict.Add("display_font", (object)display_font);
      dict.Add("fore_color", (object)ConversionUtils.ColorToHex(options.ForeColor));
      dict.Add("back_color", (object)ConversionUtils.ColorToHex(options.BackColor));
      dict.Add("padding", (object)padding);
      dict.Add("display_format", (object)options.DisplayFormat);
      dict.Add("lock_position", (object)options.LockPosition);
      dict.Add("auto_start", (object)options.AutoStart);

      return dict;
    }
  }
}
