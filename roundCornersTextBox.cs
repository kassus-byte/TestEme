using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TestEme
{
    public class roundCornersTextBox : UserControl
    {
        private TextBox textBox = new TextBox();

        public int BorderRadius { get; set; } = 50;  //TO CHANGE BORDER RADIUS
        public Color BorderColor { get; set; } =Color.Gray;
        public Color BorderFocusColor { get; set; } = Color.Black; //color
        private bool isFocused = false;

        public string Texts
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public roundCornersTextBox()
        {
            // Textbox setup
            textBox.BorderStyle = BorderStyle.None;
            textBox.Multiline = false;
            textBox.Location = new Point(10, 7);
            textBox.Width = this.Width - 20;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            textBox.Enter += (s, e) => { isFocused = true; Invalidate(); };
            textBox.Leave += (s, e) => { isFocused = false; Invalidate(); };

            Controls.Add(textBox);

            this.Padding = new Padding(10, 7, 10, 7);
            this.BackColor = Color.White;
            this.Size = new Size(200, 35);

            this.Resize += (s, e) =>
            {
                textBox.Width = this.Width - 20;
                textBox.Location = new Point(10, this.Height / 2 - textBox.Height / 2);
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundPath(BorderRadius))
            {
                this.Region = new Region(path);

                Color currentBorderColor = isFocused ? BorderFocusColor : BorderColor;
                using (Pen pen = new Pen(currentBorderColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
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