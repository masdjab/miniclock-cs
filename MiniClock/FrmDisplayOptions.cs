using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniClock
{
  public partial class FrmDisplayOptions : Form
  {
    private DisplayOptions Options;

    public DisplayOptions DisplayOptions
    {
      get { return Options; }
    }

    private string FormatDateTime(DateTime time, string format)
    {
      try {
        if(format.Length > 0) {
          return time.ToString(format);
        }
      } catch(Exception e) {
        // do nothing
      }

      return "";
    }

    private void UpdatePreview()
    {
      var text = FormatDateTime(new DateTime(2001, 8, 21, 18, 4, 5), TxtFormat.Text.Trim());

      if (text.Length > 0) {
        LblPreview.Text = text;
        LblPreview.ForeColor = Color.Blue;
      } else {
        LblPreview.Text = "{Invalid format specifier}";
        LblPreview.ForeColor = Color.Red;
      }
    }

    private string RejectInput(Control control, string message)
    {
      control.Select();
      MessageBox.Show(this, message, "Invalid input");
      return message;
    }

    private void TxtFormat_TextChanged(object sender, EventArgs e)
    {
      UpdatePreview();
    }

    private void CmdResetDefault_Click(object sender, EventArgs e)
    {
      var confirm = MessageBox.Show(
        this,
        "Reset display options to default setting?", 
        "Reset Default Confirmation", 
        MessageBoxButtons.YesNoCancel, 
        MessageBoxIcon.Question
      );

      if (confirm == DialogResult.Yes) {
        var options = DisplayOptions.CreateDefaultOptions();
        TxtFormat.Text = options.DisplayFormat;
        TxtPaddingLeft.Text = options.Padding.Left.ToString();
        TxtPaddingRight.Text = options.Padding.Right.ToString();
        TxtPaddingTop.Text = options.Padding.Top.ToString();
        TxtPaddingBottom.Text = options.Padding.Bottom.ToString();
        TxtWidth.Text = options.FormSize.Width.ToString();
        TxtHeight.Text = options.FormSize.Height.ToString();
      }
    }

    private void CmdOK_Click(object sender, EventArgs e)
    {
      var padding_left = 0;
      var padding_right = 0;
      var padding_top = 0;
      var padding_bottom = 0;
      var form_width = 0;
      var form_height = 0;
      var message = "";

      if (FormatDateTime(DateTime.Now, TxtFormat.Text.Trim()).Length == 0) {
        message = RejectInput(TxtFormat, "Invalid format specifier.");
      } else if (!int.TryParse(TxtPaddingLeft.Text, out padding_left)) {
        message = RejectInput(TxtPaddingLeft, "Invalid left padding.");
      } else if (!int.TryParse(TxtPaddingRight.Text, out padding_right)) {
        message = RejectInput(TxtPaddingRight, "Invalid right padding.");
      } else if (!int.TryParse(TxtPaddingTop.Text, out padding_top)) {
        message = RejectInput(TxtPaddingTop, "Invalid top padding.");
      } else if (!int.TryParse(TxtPaddingBottom.Text, out padding_bottom)) {
        message = RejectInput(TxtPaddingBottom, "Invalid bottom padding.");
      } else if (!int.TryParse(TxtWidth.Text, out form_width)) {
        message = RejectInput(TxtWidth, "Invalid form width.");
      } else if (!int.TryParse(TxtHeight.Text, out form_height)) {
        message = RejectInput(TxtHeight, "Invalid form height.");
      } else if(form_width <= 10) {
        message = RejectInput(TxtWidth, "Invalid form width.");
      } else if(form_height <= 10) {
        message = RejectInput(TxtHeight, "Invalid form height.");
      } else {
        Options.DisplayFormat = TxtFormat.Text.Trim();
        Options.Padding = new Padding(padding_left, padding_top, padding_right, padding_bottom);
        Options.FormSize = new Size(form_width, form_height);

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void FrmEditDisplayFormat_Load(object sender, EventArgs e)
    {
      TxtFormat.Text = Options.DisplayFormat;
      TxtPaddingLeft.Text = Options.Padding.Left.ToString();
      TxtPaddingRight.Text = Options.Padding.Right.ToString();
      TxtPaddingTop.Text = Options.Padding.Top.ToString();
      TxtPaddingBottom.Text = Options.Padding.Bottom.ToString();
      TxtWidth.Text = Options.FormSize.Width.ToString();
      TxtHeight.Text = Options.FormSize.Height.ToString();

      FormHelper.DrawHorizontalLine(this.CreateGraphics(), 0, this.ClientRectangle.Width, this.ClientRectangle.Height - 80, 1);
    }

    public FrmDisplayOptions(DisplayOptions options)
    {
      Options = options;
      InitializeComponent();
      LblPreview.Text = "";
    }
  }
}
