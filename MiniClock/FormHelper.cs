using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MiniClock
{
  public class FormHelper
  {
    public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    public const UInt32 SWP_NOSIZE = 0x0001;
    public const UInt32 SWP_NOMOVE = 0x0002;
    public const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    public static void DrawHorizontalLine(Graphics graphics, int x1, int x2, int y, int style)
    {
      Pen PenUpper;
      Pen PenLower;
      var PenLight = new Pen(Color.FromArgb(0, 0, 0));
      var PenDark = new Pen(Color.FromArgb(0, 0, 0));

      if(style == 1) {
        PenUpper = PenLight;
        PenLower = PenDark;
      } else {
        PenUpper = PenDark;
        PenLower = PenLight;
      }

      graphics.DrawLine(PenUpper, new Point(x1, y), new Point(x2, y));
      graphics.DrawLine(PenLower, new Point(x1, y + 1), new Point(x2, y + 1));
    }
  }
}
