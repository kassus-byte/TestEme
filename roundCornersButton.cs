using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestEme
{
    public class roundCornersButton : Button
    {
        public int BorderRadius { get; set; } = 30; // corner radius
        public Color BorderColor { get; set; } = Color.Gray;
        public Color BackgroundColor { get; set; } = Color.White;
        public Color HoverColor { get; set; } = Color.LightGray;
        public Color BorderFocusColor { get; set; } = Color.Black;

        private bool isHovered = false;
        private bool isFocused = false;

        public roundCornersButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = BackgroundColor;

            MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            MouseLeave += (s, e) => { isHovered = false; Invalidate(); };
            GotFocus += (s, e) => { isFocused = true; Invalidate(); };
            LostFocus += (s, e) => { isFocused = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Rounded shape
            using (GraphicsPath path = GetRoundPath(BorderRadius))
            using (Pen borderPen = new Pen(isFocused ? BorderFocusColor : BorderColor, 2))
            using (SolidBrush brush = new SolidBrush(isHovered ? HoverColor : BackgroundColor))
            {
                // Fill button
                e.Graphics.FillPath(brush, path);

                // Draw border
                e.Graphics.DrawPath(borderPen, path);

                // Draw text centered
                TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
                    this.ClientRectangle, this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            this.Region = new Region(GetRoundPath(BorderRadius));
        }

        private GraphicsPath GetRoundPath(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius;

            path.StartFigure();
            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(this.Width - r, 0, r, r, 270, 90);
            path.AddArc(this.Width - r, this.Height - r, r, r, 0, 90);
            path.AddArc(0, this.Height - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}