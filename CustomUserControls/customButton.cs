using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestEme.CustomUserControls
{
    public class customButton : Button
    {
        public int BorderRadius { get; set; } = 12;
        public int BorderSize { get; set; } = 2;
        public Color BorderColor { get; set; }  = Color.Gray; 
        public Color BackgroundColor { get; set; } = Color.White;
        public Color TextColor { get; set; } = Color.Black;
        public Color HoverTextColor { get; set; } = Color.White;
        public Color HoverColor { get; set; } = Color.Green;

        public customButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            BackColor = BackgroundColor;
            ForeColor = TextColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Button shapes
            Rectangle rectSurface = new Rectangle(0, 0, Width, Height);
            Rectangle rectBorder = new Rectangle(1, 1, Width - 3, Height - 3);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, BorderRadius - 1))
            using (SolidBrush brush = new SolidBrush(BackgroundColor))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                // Set rounded clickable region
                this.Region = new Region(pathSurface);

                // Fill background
                e.Graphics.FillPath(brush, pathSurface);

                // Draw border
                if (BorderSize > 0)
                    e.Graphics.DrawPath(penBorder, pathBorder);

                // Draw text centered
                TextRenderer.DrawText(
                    e.Graphics,
                    Text,
                    Font,
                    rectSurface,
                    TextColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackgroundColor = HoverColor;
            TextColor = HoverTextColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackgroundColor = Color.White;
            TextColor = Color.Black;
            Invalidate();
        }
    }
}
