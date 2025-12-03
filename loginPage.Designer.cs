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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // roundCornersTextBox1
            // 
            roundCornersTextBox1.BackColor = Color.Black;
            roundCornersTextBox1.BorderColor = Color.Gray;
            roundCornersTextBox1.BorderFocusColor = Color.Black;
            roundCornersTextBox1.BorderRadius = 35;
            roundCornersTextBox1.Location = new Point(1243, 387);
            roundCornersTextBox1.Name = "roundCornersTextBox1";
            roundCornersTextBox1.Padding = new Padding(10, 7, 10, 7);
            roundCornersTextBox1.Size = new Size(325, 59);
            roundCornersTextBox1.TabIndex = 2;
            roundCornersTextBox1.Texts = "";
            // 
            // roundCornersTextBox2
            // 
            roundCornersTextBox2.BackColor = Color.Gray;
            roundCornersTextBox2.BorderColor = Color.Gray;
            roundCornersTextBox2.BorderFocusColor = Color.Black;
            roundCornersTextBox2.BorderRadius = 35;
            roundCornersTextBox2.Location = new Point(1243, 592);
            roundCornersTextBox2.Name = "roundCornersTextBox2";
            roundCornersTextBox2.Padding = new Padding(10, 7, 10, 7);
            roundCornersTextBox2.Size = new Size(325, 59);
            roundCornersTextBox2.TabIndex = 3;
            roundCornersTextBox2.Texts = "";
            // 
            // button1
            // 
            button1.Location = new Point(1293, 337);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(640, 319);
            label1.Name = "label1";
            label1.Size = new Size(511, 67);
            label1.TabIndex = 5;
            label1.Text = "HAHAHAsamokaYASS";
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(roundCornersTextBox2);
            Controls.Add(roundCornersTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginPage";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private roundCornersTextBox roundCornersTextBox1;
        private roundCornersTextBox roundCornersTextBox2;
        private Button button1;
        private Label label1;
    }
}
