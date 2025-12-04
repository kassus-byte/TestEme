namespace TestEme
{
    partial class loginPage
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
            loginButton = new TestEme.CustomUserControls.customButton();
            passTextBox = new TestEme.CustomUserControls.customTextBox();
            userTextBox = new TestEme.CustomUserControls.customTextBox();
            loginImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginImage).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.BackgroundColor = Color.White;
            loginButton.BorderColor = Color.Gray;
            loginButton.BorderRadius = 12;
            loginButton.BorderSize = 2;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(1335, 752);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(138, 41);
            loginButton.TabIndex = 3;
            loginButton.Text = "ENTER";
            loginButton.TextColor = Color.Black;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton1_Click;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = Color.Transparent;
            passTextBox.BorderColor = Color.Gray;
            passTextBox.BorderRadius = 10;
            passTextBox.BorderSize = 2;
            passTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passTextBox.Location = new Point(1258, 607);
            passTextBox.Name = "passTextBox";
            passTextBox.Padding = new Padding(8);
            passTextBox.Size = new Size(292, 53);
            passTextBox.TabIndex = 4;
            passTextBox.Load += passTextBox_Load;
            // 
            // userTextBox
            // 
            userTextBox.BorderColor = Color.Gray;
            userTextBox.BorderRadius = 10;
            userTextBox.BorderSize = 2;
            userTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTextBox.Location = new Point(1258, 424);
            userTextBox.Name = "userTextBox";
            userTextBox.Padding = new Padding(8);
            userTextBox.Size = new Size(292, 53);
            userTextBox.TabIndex = 5;
            userTextBox.Load += userTextBox_Load;
            // 
            // loginImage
            // 
            loginImage.Dock = DockStyle.Fill;
            loginImage.Image = Properties.Resources.login;
            loginImage.Location = new Point(0, 0);
            loginImage.Name = "loginImage";
            loginImage.Size = new Size(1920, 1080);
            loginImage.TabIndex = 6;
            loginImage.TabStop = false;
            loginImage.Click += loginImage_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(userTextBox);
            Controls.Add(passTextBox);
            Controls.Add(loginButton);
            Controls.Add(loginImage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginPage";
            Text = "loginPage";
            Load += loginPage_Load;
            ((System.ComponentModel.ISupportInitialize)loginImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomUserControls.customButton loginButton;
        private CustomUserControls.customTextBox passTextBox;
        private CustomUserControls.customTextBox userTextBox;
        private PictureBox loginImage;
    }
}