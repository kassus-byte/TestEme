using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestEme.CustomUserControls
{
    public class customTextBox : UserControl
    {
        private TextBox innerTextBox = new TextBox();

        public customTextBox()
        {
            BorderColor = Color.Gray;
            BorderSize = 2;
            BorderRadius = 10; //corners
            Padding = new Padding(10);

            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.Font = Font;
            innerTextBox.Location = new Point(Padding.Left, Padding.Top);
            innerTextBox.ForeColor = ForeColor;
            innerTextBox.BackColor = BackColor;
            innerTextBox.Width = Width - Padding.Left - Padding.Right;

            innerTextBox.TextChanged += (s, e) => OnTextChanged(e);

            Controls.Add(innerTextBox);

            Size = new Size(200, 35);
        }

        // Properties
        [Category("Appearance")]
        public int BorderRadius { get; set; }

        [Category("Appearance")]
        public Color BorderColor { get; set; }

        [Category("Appearance")]
        public int BorderSize { get; set; }

        public override string Text
        {
            get => innerTextBox.Text;
            set => innerTextBox.Text = value;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            innerTextBox.Width = Width - Padding.Left - Padding.Right;
            innerTextBox.Height = Height - Padding.Top - Padding.Bottom;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 2, Height - 2);

            using (GraphicsPath path = GetPath(rect, BorderRadius))
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            innerTextBox.Focus();
        }
    }
}
