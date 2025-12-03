namespace TestEme
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            roundCornersTextBox1 = new roundCornersTextBox();
            roundCornersTextBox2 = new roundCornersTextBox();
            roundCornersButton1 = new roundCornersButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 79);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "DIRI IBUTANG AND NEW";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // roundCornersTextBox1
            // 
            roundCornersTextBox1.BackColor = Color.White;
            roundCornersTextBox1.BorderColor = Color.Gray;
            roundCornersTextBox1.BorderFocusColor = Color.Black;
            roundCornersTextBox1.BorderRadius = 35;
            roundCornersTextBox1.Location = new Point(1332, 417);
            roundCornersTextBox1.Margin = new Padding(3, 2, 3, 2);
            roundCornersTextBox1.Name = "roundCornersTextBox1";
            roundCornersTextBox1.Padding = new Padding(9, 5, 9, 5);
            roundCornersTextBox1.Size = new Size(306, 53);
            roundCornersTextBox1.TabIndex = 2;
            roundCornersTextBox1.Texts = "";
            roundCornersTextBox1.Load += roundCornersTextBox1_Load;
            // 
            // roundCornersTextBox2
            // 
            roundCornersTextBox2.BackColor = Color.White;
            roundCornersTextBox2.BorderColor = Color.Gray;
            roundCornersTextBox2.BorderFocusColor = Color.Black;
            roundCornersTextBox2.BorderRadius = 35;
            roundCornersTextBox2.Location = new Point(1332, 600);
            roundCornersTextBox2.Margin = new Padding(3, 2, 3, 2);
            roundCornersTextBox2.Name = "roundCornersTextBox2";
            roundCornersTextBox2.Padding = new Padding(9, 5, 9, 5);
            roundCornersTextBox2.Size = new Size(306, 53);
            roundCornersTextBox2.TabIndex = 3;
            roundCornersTextBox2.Texts = "";
            // 
            // roundCornersButton1
            // 
            roundCornersButton1.BackColor = Color.White;
            roundCornersButton1.BackgroundColor = Color.White;
            roundCornersButton1.BorderColor = Color.Gray;
            roundCornersButton1.BorderFocusColor = Color.Black;
            roundCornersButton1.BorderRadius = 30;
            roundCornersButton1.FlatAppearance.BorderSize = 0;
            roundCornersButton1.FlatStyle = FlatStyle.Flat;
            roundCornersButton1.HoverColor = Color.LightGray;
            roundCornersButton1.Location = new Point(1401, 752);
            roundCornersButton1.Name = "roundCornersButton1";
            roundCornersButton1.Size = new Size(166, 56);
            roundCornersButton1.TabIndex = 5;
            roundCornersButton1.Text = "roundCornersButton1";
            roundCornersButton1.UseVisualStyleBackColor = false;
            roundCornersButton1.Click += roundCornersButton1_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(roundCornersButton1);
            Controls.Add(roundCornersTextBox2);
            Controls.Add(roundCornersTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "loginPage";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private roundCornersTextBox roundCornersTextBox1;
        private roundCornersTextBox roundCornersTextBox2;
        private roundCornersButton roundCornersButton1;
    }
}
