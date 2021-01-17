namespace MiniClock
{
  partial class FrmDisplayOptions
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.LblFormat = new System.Windows.Forms.Label();
      this.TxtFormat = new System.Windows.Forms.TextBox();
      this.LblFormatHint = new System.Windows.Forms.Label();
      this.CmdCancel = new System.Windows.Forms.Button();
      this.CmdOK = new System.Windows.Forms.Button();
      this.TxtHeight = new System.Windows.Forms.TextBox();
      this.LblHeight = new System.Windows.Forms.Label();
      this.TxtWidth = new System.Windows.Forms.TextBox();
      this.LblWidth = new System.Windows.Forms.Label();
      this.LblPreview = new System.Windows.Forms.Label();
      this.TxtPaddingRight = new System.Windows.Forms.TextBox();
      this.LblPaddingRight = new System.Windows.Forms.Label();
      this.TxtPaddingLeft = new System.Windows.Forms.TextBox();
      this.LblPaddingLeft = new System.Windows.Forms.Label();
      this.TxtPaddingBottom = new System.Windows.Forms.TextBox();
      this.LblPaddingBottom = new System.Windows.Forms.Label();
      this.TxtPaddingTop = new System.Windows.Forms.TextBox();
      this.LblPaddingTop = new System.Windows.Forms.Label();
      this.LblPadding = new System.Windows.Forms.Label();
      this.CmdResetDefault = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LblFormat
      // 
      this.LblFormat.AutoSize = true;
      this.LblFormat.Location = new System.Drawing.Point(12, 24);
      this.LblFormat.Name = "LblFormat";
      this.LblFormat.Size = new System.Drawing.Size(78, 13);
      this.LblFormat.TabIndex = 0;
      this.LblFormat.Text = "Display &Format";
      // 
      // TxtFormat
      // 
      this.TxtFormat.Location = new System.Drawing.Point(96, 21);
      this.TxtFormat.Name = "TxtFormat";
      this.TxtFormat.Size = new System.Drawing.Size(195, 21);
      this.TxtFormat.TabIndex = 1;
      this.TxtFormat.TextChanged += new System.EventHandler(this.TxtFormat_TextChanged);
      // 
      // LblFormatHint
      // 
      this.LblFormatHint.AutoEllipsis = true;
      this.LblFormatHint.Location = new System.Drawing.Point(93, 69);
      this.LblFormatHint.Name = "LblFormatHint";
      this.LblFormatHint.Size = new System.Drawing.Size(184, 117);
      this.LblFormatHint.TabIndex = 3;
      this.LblFormatHint.Text = "Valid formatter:\r\n- year: yyyy, yy\r\n- month: M, MM, MMM, MMMM\r\n- day: dd, ddd, dd" +
    "dd\r\n- hour: hh, HH\r\n- minute: m, mm\r\n- second: s, ss\r\n- escape: \\";
      // 
      // CmdCancel
      // 
      this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CmdCancel.Location = new System.Drawing.Point(222, 331);
      this.CmdCancel.Name = "CmdCancel";
      this.CmdCancel.Size = new System.Drawing.Size(69, 27);
      this.CmdCancel.TabIndex = 18;
      this.CmdCancel.Text = "Cancel";
      this.CmdCancel.UseVisualStyleBackColor = true;
      // 
      // CmdOK
      // 
      this.CmdOK.Location = new System.Drawing.Point(147, 331);
      this.CmdOK.Name = "CmdOK";
      this.CmdOK.Size = new System.Drawing.Size(69, 27);
      this.CmdOK.TabIndex = 17;
      this.CmdOK.Text = "OK";
      this.CmdOK.UseVisualStyleBackColor = true;
      this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
      // 
      // TxtHeight
      // 
      this.TxtHeight.Location = new System.Drawing.Point(96, 279);
      this.TxtHeight.Name = "TxtHeight";
      this.TxtHeight.Size = new System.Drawing.Size(195, 21);
      this.TxtHeight.TabIndex = 16;
      // 
      // LblHeight
      // 
      this.LblHeight.AutoSize = true;
      this.LblHeight.Location = new System.Drawing.Point(25, 282);
      this.LblHeight.Name = "LblHeight";
      this.LblHeight.Size = new System.Drawing.Size(65, 13);
      this.LblHeight.TabIndex = 15;
      this.LblHeight.Text = "Form &Height";
      // 
      // TxtWidth
      // 
      this.TxtWidth.Location = new System.Drawing.Point(96, 252);
      this.TxtWidth.Name = "TxtWidth";
      this.TxtWidth.Size = new System.Drawing.Size(195, 21);
      this.TxtWidth.TabIndex = 14;
      // 
      // LblWidth
      // 
      this.LblWidth.AutoSize = true;
      this.LblWidth.Location = new System.Drawing.Point(28, 255);
      this.LblWidth.Name = "LblWidth";
      this.LblWidth.Size = new System.Drawing.Size(62, 13);
      this.LblWidth.TabIndex = 13;
      this.LblWidth.Text = "Form &Width";
      // 
      // LblPreview
      // 
      this.LblPreview.AutoSize = true;
      this.LblPreview.Location = new System.Drawing.Point(93, 45);
      this.LblPreview.Name = "LblPreview";
      this.LblPreview.Size = new System.Drawing.Size(55, 13);
      this.LblPreview.TabIndex = 2;
      this.LblPreview.Text = "{Preview}";
      // 
      // TxtPaddingRight
      // 
      this.TxtPaddingRight.Location = new System.Drawing.Point(248, 189);
      this.TxtPaddingRight.Name = "TxtPaddingRight";
      this.TxtPaddingRight.Size = new System.Drawing.Size(43, 21);
      this.TxtPaddingRight.TabIndex = 8;
      this.TxtPaddingRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // LblPaddingRight
      // 
      this.LblPaddingRight.AutoSize = true;
      this.LblPaddingRight.Location = new System.Drawing.Point(212, 192);
      this.LblPaddingRight.Name = "LblPaddingRight";
      this.LblPaddingRight.Size = new System.Drawing.Size(32, 13);
      this.LblPaddingRight.TabIndex = 7;
      this.LblPaddingRight.Text = "&Right";
      // 
      // TxtPaddingLeft
      // 
      this.TxtPaddingLeft.Location = new System.Drawing.Point(132, 189);
      this.TxtPaddingLeft.Name = "TxtPaddingLeft";
      this.TxtPaddingLeft.Size = new System.Drawing.Size(44, 21);
      this.TxtPaddingLeft.TabIndex = 6;
      this.TxtPaddingLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // LblPaddingLeft
      // 
      this.LblPaddingLeft.AutoSize = true;
      this.LblPaddingLeft.Location = new System.Drawing.Point(100, 192);
      this.LblPaddingLeft.Name = "LblPaddingLeft";
      this.LblPaddingLeft.Size = new System.Drawing.Size(26, 13);
      this.LblPaddingLeft.TabIndex = 5;
      this.LblPaddingLeft.Text = "&Left";
      // 
      // TxtPaddingBottom
      // 
      this.TxtPaddingBottom.Location = new System.Drawing.Point(248, 216);
      this.TxtPaddingBottom.Name = "TxtPaddingBottom";
      this.TxtPaddingBottom.Size = new System.Drawing.Size(43, 21);
      this.TxtPaddingBottom.TabIndex = 12;
      this.TxtPaddingBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // LblPaddingBottom
      // 
      this.LblPaddingBottom.AutoSize = true;
      this.LblPaddingBottom.Location = new System.Drawing.Point(201, 219);
      this.LblPaddingBottom.Name = "LblPaddingBottom";
      this.LblPaddingBottom.Size = new System.Drawing.Size(41, 13);
      this.LblPaddingBottom.TabIndex = 11;
      this.LblPaddingBottom.Text = "&Bottom";
      // 
      // TxtPaddingTop
      // 
      this.TxtPaddingTop.Location = new System.Drawing.Point(133, 216);
      this.TxtPaddingTop.Name = "TxtPaddingTop";
      this.TxtPaddingTop.Size = new System.Drawing.Size(43, 21);
      this.TxtPaddingTop.TabIndex = 10;
      this.TxtPaddingTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // LblPaddingTop
      // 
      this.LblPaddingTop.AutoSize = true;
      this.LblPaddingTop.Location = new System.Drawing.Point(102, 219);
      this.LblPaddingTop.Name = "LblPaddingTop";
      this.LblPaddingTop.Size = new System.Drawing.Size(25, 13);
      this.LblPaddingTop.TabIndex = 9;
      this.LblPaddingTop.Text = "&Top";
      // 
      // LblPadding
      // 
      this.LblPadding.AutoSize = true;
      this.LblPadding.Location = new System.Drawing.Point(45, 192);
      this.LblPadding.Name = "LblPadding";
      this.LblPadding.Size = new System.Drawing.Size(45, 13);
      this.LblPadding.TabIndex = 4;
      this.LblPadding.Text = "Padding";
      // 
      // CmdResetDefault
      // 
      this.CmdResetDefault.Location = new System.Drawing.Point(15, 332);
      this.CmdResetDefault.Name = "CmdResetDefault";
      this.CmdResetDefault.Size = new System.Drawing.Size(90, 26);
      this.CmdResetDefault.TabIndex = 19;
      this.CmdResetDefault.Text = "&Reset Default";
      this.CmdResetDefault.UseVisualStyleBackColor = true;
      this.CmdResetDefault.Click += new System.EventHandler(this.CmdResetDefault_Click);
      // 
      // FrmDisplayOptions
      // 
      this.AcceptButton = this.CmdOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CmdCancel;
      this.ClientSize = new System.Drawing.Size(306, 372);
      this.Controls.Add(this.CmdResetDefault);
      this.Controls.Add(this.LblPadding);
      this.Controls.Add(this.TxtPaddingBottom);
      this.Controls.Add(this.LblPaddingBottom);
      this.Controls.Add(this.TxtPaddingTop);
      this.Controls.Add(this.LblPaddingTop);
      this.Controls.Add(this.TxtPaddingRight);
      this.Controls.Add(this.LblPaddingRight);
      this.Controls.Add(this.TxtPaddingLeft);
      this.Controls.Add(this.LblPaddingLeft);
      this.Controls.Add(this.LblPreview);
      this.Controls.Add(this.CmdCancel);
      this.Controls.Add(this.CmdOK);
      this.Controls.Add(this.TxtHeight);
      this.Controls.Add(this.LblHeight);
      this.Controls.Add(this.TxtWidth);
      this.Controls.Add(this.LblWidth);
      this.Controls.Add(this.LblFormatHint);
      this.Controls.Add(this.TxtFormat);
      this.Controls.Add(this.LblFormat);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmDisplayOptions";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Form Size and Display Format";
      this.Load += new System.EventHandler(this.FrmEditDisplayFormat_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblFormat;
    private System.Windows.Forms.TextBox TxtFormat;
    private System.Windows.Forms.Label LblFormatHint;
    private System.Windows.Forms.Button CmdCancel;
    private System.Windows.Forms.Button CmdOK;
    private System.Windows.Forms.TextBox TxtHeight;
    private System.Windows.Forms.Label LblHeight;
    private System.Windows.Forms.TextBox TxtWidth;
    private System.Windows.Forms.Label LblWidth;
    private System.Windows.Forms.Label LblPreview;
    private System.Windows.Forms.TextBox TxtPaddingRight;
    private System.Windows.Forms.Label LblPaddingRight;
    private System.Windows.Forms.TextBox TxtPaddingLeft;
    private System.Windows.Forms.Label LblPaddingLeft;
    private System.Windows.Forms.TextBox TxtPaddingBottom;
    private System.Windows.Forms.Label LblPaddingBottom;
    private System.Windows.Forms.TextBox TxtPaddingTop;
    private System.Windows.Forms.Label LblPaddingTop;
    private System.Windows.Forms.Label LblPadding;
    private System.Windows.Forms.Button CmdResetDefault;
  }
}