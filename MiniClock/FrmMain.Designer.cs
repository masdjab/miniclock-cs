namespace MiniClock
{
    partial class FrmMain
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
            if (disposing && (components != null))
            {
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
      this.components = new System.ComponentModel.Container();
      this.TmrTime = new System.Windows.Forms.Timer(this.components);
      this.MnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MnuChangeFont = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuChangeForeColor = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuChangeBackColor = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MnuDisplayOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.MnuLockPosition = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuAutoStart = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.MnuContext.SuspendLayout();
      this.SuspendLayout();
      // 
      // TmrTime
      // 
      this.TmrTime.Enabled = true;
      this.TmrTime.Interval = 1000;
      this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
      // 
      // MnuContext
      // 
      this.MnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuChangeFont,
            this.MnuChangeForeColor,
            this.MnuChangeBackColor,
            this.toolStripSeparator1,
            this.MnuDisplayOptions,
            this.toolStripSeparator2,
            this.MnuAutoStart,
            this.toolStripSeparator4,
            this.MnuLockPosition,
            this.toolStripSeparator3,
            this.MnuExit});
      this.MnuContext.Name = "MnuContext";
      this.MnuContext.Size = new System.Drawing.Size(185, 182);
      // 
      // MnuChangeFont
      // 
      this.MnuChangeFont.Name = "MnuChangeFont";
      this.MnuChangeFont.Size = new System.Drawing.Size(184, 22);
      this.MnuChangeFont.Text = "Change F&ont...";
      this.MnuChangeFont.Click += new System.EventHandler(this.MnuChangeFont_Click);
      // 
      // MnuChangeForeColor
      // 
      this.MnuChangeForeColor.Name = "MnuChangeForeColor";
      this.MnuChangeForeColor.Size = new System.Drawing.Size(184, 22);
      this.MnuChangeForeColor.Text = "Change &Fore Color...";
      this.MnuChangeForeColor.Click += new System.EventHandler(this.MnuChangeForeColor_Click);
      // 
      // MnuChangeBackColor
      // 
      this.MnuChangeBackColor.Name = "MnuChangeBackColor";
      this.MnuChangeBackColor.Size = new System.Drawing.Size(184, 22);
      this.MnuChangeBackColor.Text = "Change &Back Color...";
      this.MnuChangeBackColor.Click += new System.EventHandler(this.MnuChangeBackColor_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
      // 
      // MnuDisplayOptions
      // 
      this.MnuDisplayOptions.Name = "MnuDisplayOptions";
      this.MnuDisplayOptions.Size = new System.Drawing.Size(184, 22);
      this.MnuDisplayOptions.Text = "&Display Options...";
      this.MnuDisplayOptions.Click += new System.EventHandler(this.MnuDisplayOptions_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
      // 
      // MnuLockPosition
      // 
      this.MnuLockPosition.Name = "MnuLockPosition";
      this.MnuLockPosition.Size = new System.Drawing.Size(184, 22);
      this.MnuLockPosition.Text = "&Lock Position";
      this.MnuLockPosition.Click += new System.EventHandler(this.MnuLockPosition_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
      // 
      // MnuExit
      // 
      this.MnuExit.Name = "MnuExit";
      this.MnuExit.Size = new System.Drawing.Size(184, 22);
      this.MnuExit.Text = "E&xit";
      this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
      // 
      // MnuAutoStart
      // 
      this.MnuAutoStart.Name = "MnuAutoStart";
      this.MnuAutoStart.Size = new System.Drawing.Size(184, 22);
      this.MnuAutoStart.Text = "&Auto Start";
      this.MnuAutoStart.Click += new System.EventHandler(this.MnuAutoStart_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(91, 18);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MinimumSize = new System.Drawing.Size(10, 10);
      this.Name = "FrmMain";
      this.Text = "MiniClock";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
      this.MnuContext.ResumeLayout(false);
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Timer TmrTime;
    private System.Windows.Forms.ContextMenuStrip MnuContext;
    private System.Windows.Forms.ToolStripMenuItem MnuChangeFont;
    private System.Windows.Forms.ToolStripMenuItem MnuChangeForeColor;
    private System.Windows.Forms.ToolStripMenuItem MnuChangeBackColor;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem MnuDisplayOptions;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem MnuLockPosition;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem MnuExit;
    private System.Windows.Forms.ToolStripMenuItem MnuAutoStart;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  }
}

