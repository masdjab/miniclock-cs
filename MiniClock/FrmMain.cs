using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniClock
{
  public partial class FrmMain : Form
  {
    private DisplayOptions DisplayOptions;
    private bool IsMouseDown = false;
    private Point MoveFrom = new Point(0, 0);

    private void MnuChangeFont_Click(object sender, EventArgs e)
    {
      var dlg = new FontDialog();
      dlg.Font = this.Font;
      var result = dlg.ShowDialog(this);

      if(result == DialogResult.OK) {
        DisplayOptions.DisplayFont = dlg.Font;
        SaveConfig(DisplayOptions);
        this.Refresh();
      }
    }

    private void MnuChangeForeColor_Click(object sender, EventArgs e)
    {
      var dlg = new ColorDialog();
      dlg.Color = DisplayOptions.ForeColor;
      var result = dlg.ShowDialog();

      if (result == DialogResult.OK) {
        DisplayOptions.ForeColor = dlg.Color;
        SaveConfig(DisplayOptions);
        this.Refresh();
      }
    }

    private void MnuChangeBackColor_Click(object sender, EventArgs e)
    {
      var dlg = new ColorDialog();
      dlg.Color = this.BackColor;
      var result = dlg.ShowDialog();

      if (result == DialogResult.OK) {
        DisplayOptions.BackColor = dlg.Color;
        SaveConfig(DisplayOptions);
        this.BackColor = dlg.Color;
        this.Refresh();
      }
    }


    private void MnuDisplayOptions_Click(object sender, EventArgs e)
    {
      var dlg = new FrmDisplayOptions(DisplayOptions);

      dlg.ShowDialog(this);

      if (dlg.DialogResult == DialogResult.OK) {
        DisplayOptions.FormSize = dlg.DisplayOptions.FormSize;
        DisplayOptions.Padding = dlg.DisplayOptions.Padding;
        DisplayOptions.DisplayFormat = dlg.DisplayOptions.DisplayFormat;
        SaveConfig(DisplayOptions);
        this.Size = DisplayOptions.FormSize;
        this.Refresh();
      }
    }

    private void MnuAutoStart_Click(object sender, EventArgs e)
    {
      MnuAutoStart.Checked = !MnuAutoStart.Checked;
      DisplayOptions.SetAutoStart(MnuAutoStart.Checked);
    }

    private void MnuLockPosition_Click(object sender, EventArgs e)
    {
      MnuLockPosition.Checked = !MnuLockPosition.Checked;
    }

    private void MnuExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FrmMain_Paint(object sender, PaintEventArgs e)
    {
      string time_info;

      try {
        time_info = DateTime.Now.ToString(DisplayOptions.DisplayFormat);
      } catch(Exception exc) {
        time_info = "{Invalid format}";
      }

      var draw_rect = new RectangleF(
        (float)DisplayOptions.Padding.Left, 
        (float)DisplayOptions.Padding.Top, 
        (float)(this.Width - DisplayOptions.Padding.Left - DisplayOptions.Padding.Right), 
        (float)(this.Height - DisplayOptions.Padding.Top - DisplayOptions.Padding.Bottom)
      );

      var sf = new StringFormat();
      sf.FormatFlags = StringFormatFlags.NoWrap;
      e.Graphics.DrawString(time_info, DisplayOptions.DisplayFont, new SolidBrush(DisplayOptions.ForeColor), draw_rect, sf);
    }

    private void TmrTime_Tick(object sender, EventArgs e)
    {
      this.Refresh();
    }

    private void FrmMain_MouseDown(object sender, MouseEventArgs e)
    {
      if(e.Button == MouseButtons.Left) {
        if(!MnuLockPosition.Checked) {
          MoveFrom = e.Location;
          IsMouseDown = true;
        }
      } else if(e.Button == MouseButtons.Right) {
        MnuContext.Show(this, e.Location);
      }
    }

    private void FormMain_MouseMove(object sender, MouseEventArgs e)
    {
      if(IsMouseDown) {
        this.Location = new Point(this.Left + e.X - MoveFrom.X, this.Top + e.Y - MoveFrom.Y);
      }
    }

    private void FrmMain_MouseUp(object sender, MouseEventArgs e)
    {
      IsMouseDown = false;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      FormHelper.SetWindowPos(this.Handle, FormHelper.HWND_TOPMOST, 0, 0, 0, 0, FormHelper.TOPMOST_FLAGS);
    }

    private DisplayOptions LoadConfig()
    {
      var default_options = DisplayOptions.ToDict(DisplayOptions.CreateDefaultOptions());
      var options_dict = (new AppConfig()).LoadConfig("config.json", default_options);
      return DisplayOptions.FromDict(options_dict);
    }

    private void SaveConfig(DisplayOptions options)
    {
      (new AppConfig()).SaveConfig("config.json", DisplayOptions.ToDict(options));
    }

    public FrmMain()
    {
      InitializeComponent();

      DisplayOptions = LoadConfig();
      DisplayOptions.AutoStart = DisplayOptions.GetAutoStart();

      this.Top = 0;
      this.Location = new Point((Screen.GetWorkingArea(this).Width - this.Width) / 2, 0);
      this.Size = DisplayOptions.FormSize;
      this.Font = DisplayOptions.DisplayFont;
      this.BackColor = DisplayOptions.BackColor;

      MnuAutoStart.Checked = DisplayOptions.AutoStart;
      MnuLockPosition.Checked = DisplayOptions.LockPosition;
    }
  }
}
