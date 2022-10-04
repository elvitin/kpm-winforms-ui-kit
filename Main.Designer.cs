namespace KpmUiKit
{
  partial class Main
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.kpmTextBox1 = new KpmUiKit.CommonControls.KpmTextBox();
      this.kpmTextBox2 = new KpmUiKit.CommonControls.KpmTextBox();
      this.kpmTextBox3 = new KpmUiKit.CommonControls.KpmTextBox();
      this.SuspendLayout();
      // 
      // kpmTextBox1
      // 
      this.kpmTextBox1.BackColor = System.Drawing.SystemColors.Window;
      this.kpmTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.kpmTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.kpmTextBox1.BorderSize = 3;
      this.kpmTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.kpmTextBox1.ForeColor = System.Drawing.Color.DimGray;
      this.kpmTextBox1.Location = new System.Drawing.Point(244, 83);
      this.kpmTextBox1.Margin = new System.Windows.Forms.Padding(0);
      this.kpmTextBox1.Multiline = false;
      this.kpmTextBox1.Name = "kpmTextBox1";
      this.kpmTextBox1.Padding = new System.Windows.Forms.Padding(7);
      this.kpmTextBox1.PasswordChar = false;
      this.kpmTextBox1.Size = new System.Drawing.Size(312, 35);
      this.kpmTextBox1.TabIndex = 0;
      this.kpmTextBox1.Texts = "";
      this.kpmTextBox1.UnderlinedStyle = false;
      // 
      // kpmTextBox2
      // 
      this.kpmTextBox2.BackColor = System.Drawing.SystemColors.Window;
      this.kpmTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.kpmTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.kpmTextBox2.BorderSize = 3;
      this.kpmTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.kpmTextBox2.ForeColor = System.Drawing.Color.DimGray;
      this.kpmTextBox2.Location = new System.Drawing.Point(315, 189);
      this.kpmTextBox2.Margin = new System.Windows.Forms.Padding(0);
      this.kpmTextBox2.Multiline = false;
      this.kpmTextBox2.Name = "kpmTextBox2";
      this.kpmTextBox2.Padding = new System.Windows.Forms.Padding(7);
      this.kpmTextBox2.PasswordChar = false;
      this.kpmTextBox2.Size = new System.Drawing.Size(312, 35);
      this.kpmTextBox2.TabIndex = 1;
      this.kpmTextBox2.Texts = "";
      this.kpmTextBox2.UnderlinedStyle = false;
      // 
      // kpmTextBox3
      // 
      this.kpmTextBox3.BackColor = System.Drawing.SystemColors.Window;
      this.kpmTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.kpmTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.kpmTextBox3.BorderSize = 3;
      this.kpmTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.kpmTextBox3.ForeColor = System.Drawing.Color.DimGray;
      this.kpmTextBox3.Location = new System.Drawing.Point(412, 267);
      this.kpmTextBox3.Margin = new System.Windows.Forms.Padding(0);
      this.kpmTextBox3.Multiline = false;
      this.kpmTextBox3.Name = "kpmTextBox3";
      this.kpmTextBox3.Padding = new System.Windows.Forms.Padding(7);
      this.kpmTextBox3.PasswordChar = false;
      this.kpmTextBox3.Size = new System.Drawing.Size(312, 35);
      this.kpmTextBox3.TabIndex = 2;
      this.kpmTextBox3.Texts = "";
      this.kpmTextBox3.UnderlinedStyle = false;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.kpmTextBox3);
      this.Controls.Add(this.kpmTextBox2);
      this.Controls.Add(this.kpmTextBox1);
      this.Name = "Main";
      this.Text = "Main";
      this.ResumeLayout(false);

    }

    #endregion

    private CommonControls.KpmTextBox kpmTextBox1;
    private CommonControls.KpmTextBox kpmTextBox2;
    private CommonControls.KpmTextBox kpmTextBox3;
  }
}