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
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(565, 358);
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
            passTextBox.BorderColor = Color.Gray;
            passTextBox.BorderRadius = 10;
            passTextBox.BorderSize = 2;
            passTextBox.Location = new Point(534, 279);
            passTextBox.Name = "passTextBox";
            passTextBox.Padding = new Padding(8);
            passTextBox.Size = new Size(200, 35);
            passTextBox.TabIndex = 4;
            passTextBox.Load += passTextBox_Load;
            // 
            // userTextBox
            // 
            userTextBox.BorderColor = Color.Gray;
            userTextBox.BorderRadius = 10;
            userTextBox.BorderSize = 2;
            userTextBox.Location = new Point(534, 217);
            userTextBox.Name = "userTextBox";
            userTextBox.Padding = new Padding(8);
            userTextBox.Size = new Size(200, 35);
            userTextBox.TabIndex = 5;
            userTextBox.Load += userTextBox_Load;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 596);
            Controls.Add(userTextBox);
            Controls.Add(passTextBox);
            Controls.Add(loginButton);
            Name = "loginPage";
            Text = "loginPage";
            Load += loginPage_Load;
            ResumeLayout(false);
        }

        #endregion
        private CustomUserControls.customButton loginButton;
        private CustomUserControls.customTextBox passTextBox;
        private CustomUserControls.customTextBox userTextBox;
    }
}