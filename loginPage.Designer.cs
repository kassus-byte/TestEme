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
            roundCornersTextBox1 = new roundCornersTextBox();
            roundCornersTextBox2 = new roundCornersTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundCornersTextBox1
            // 
            roundCornersTextBox1.BackColor = Color.White;
            roundCornersTextBox1.BorderColor = Color.Gray;
            roundCornersTextBox1.BorderFocusColor = Color.Black;
            roundCornersTextBox1.BorderRadius = 35;
            roundCornersTextBox1.Location = new Point(1243, 399);
            roundCornersTextBox1.Name = "roundCornersTextBox1";
            roundCornersTextBox1.Padding = new Padding(10, 7, 10, 7);
            roundCornersTextBox1.Size = new Size(325, 59);
            roundCornersTextBox1.TabIndex = 2;
            roundCornersTextBox1.Texts = "";
            // 
            // roundCornersTextBox2
            // 
            roundCornersTextBox2.BackColor = Color.White;
            roundCornersTextBox2.BorderColor = Color.Gray;
            roundCornersTextBox2.BorderFocusColor = Color.Black;
            roundCornersTextBox2.BorderRadius = 35;
            roundCornersTextBox2.Location = new Point(1243, 586);
            roundCornersTextBox2.Name = "roundCornersTextBox2";
            roundCornersTextBox2.Padding = new Padding(10, 7, 10, 7);
            roundCornersTextBox2.Size = new Size(325, 59);
            roundCornersTextBox2.TabIndex = 3;
            roundCornersTextBox2.Texts = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(588, 190);
            label1.Name = "label1";
            label1.Size = new Size(347, 46);
            label1.TabIndex = 0;
            label1.Text = "THIS IS KAASSUSSSSS";
            label1.Click += label1_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(roundCornersTextBox2);
            Controls.Add(roundCornersTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginPage";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private roundCornersTextBox roundCornersTextBox1;
        private roundCornersTextBox roundCornersTextBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
