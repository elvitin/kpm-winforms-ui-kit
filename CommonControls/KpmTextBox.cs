using System.ComponentModel;

namespace KpmUiKit.CommonControls
{
  [DefaultEvent("_TextChanged")]
  public partial class KpmTextBox : UserControl
  {
    //Fields
    private Color borderColor = Color.FromArgb(153, 153, 153);
    private Color borderFocusColor = Color.FromArgb(30, 133, 111);
    private bool isFocused = false;
    private int borderSize = 1;
    private bool underlinedStyle = false;

    //Events
    public event EventHandler _TextChanged;

    //Constructor
    public KpmTextBox()
    {
      InitializeComponent();
    }

    //Properties
    [Category("Kpm Custom Properties")]
    public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

    [Category("Kpm Custom Properties")]
    public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

    [Category("Kpm Custom Properties")]
    public int BorderSize { get => borderSize; set => borderSize = value; }

    [Category("Kpm Custom Properties")]
    public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }

    [Category("Kpm Custom Properties")]
    public bool PasswordChar { get => TxtBox.UseSystemPasswordChar; set => TxtBox.UseSystemPasswordChar = value; }

    [Category("Kpm Custom Properties")]
    public bool Multiline { get => TxtBox.Multiline; set => TxtBox.Multiline = value; }

    [Category("Kpm Custom Properties")]
    public override Color BackColor
    {
      get => base.BackColor;
      set
      {
        base.BackColor = value;
        TxtBox.BackColor = value;
      }
    }

    [Category("Kpm Custom Properties")]
    public override Color ForeColor
    {
      get => base.ForeColor;
      set
      {
        base.ForeColor = value;
        TxtBox.ForeColor = value;
      }
    }

    [Category("Kpm Custom Properties")]
    public override Font Font
    {
      get => base.Font;
      set
      {
        base.Font = value;
        TxtBox.Font = value;
        if (this.DesignMode)
          UpdateControlHeight();
      }
    }

    [Category("Custom Properties")]
    public string Texts { get => TxtBox.Text; set => TxtBox.Text = value; }


    //Overriden methods
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics graph = e.Graphics;

      //Draw border
      using (Pen penBorder = new(borderColor, borderSize))
      {
        penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

        if (isFocused)
          penBorder.Color = BorderFocusColor;

        if (underlinedStyle) //Line Style
          graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
        else //Normal style
          graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      if (this.DesignMode)
        UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateControlHeight();
    }

    //Private methods
    private void UpdateControlHeight()
    {
      if (TxtBox.Multiline == false)
      {
        int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        TxtBox.Multiline = true;
        TxtBox.MinimumSize = new Size(0, txtHeight);
        TxtBox.Multiline = false;
        this.Height = TxtBox.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }

    private void TxtBox_TextChanged(object sender, EventArgs e)
    {
      _TextChanged?.Invoke(sender, e);
    }

    private void TxtBox_Click(object sender, EventArgs e)
    {
      this.OnClick(e);
    }

    private void TxtBox_MouseEnter(object sender, EventArgs e)
    {
      this.OnMouseEnter(e);
    }

    private void TxtBox_MouseLeave(object sender, EventArgs e)
    {
      this.OnMouseLeave(e);
    }

    private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.OnKeyPress(e);
    }

    private void TxtBox_Enter(object sender, EventArgs e)
    {
      isFocused = true;
      this.Invalidate();
    }

    private void TxtBox_Leave(object sender, EventArgs e)
    {
      isFocused = false;
      this.Invalidate();
    }
    //Anexar outros eventos aqui.
  }
}
