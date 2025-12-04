using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEme
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();  
        }

        private void userTextBox_Load(object sender, EventArgs e)
        {

        }

        private void passTextBox_Load(object sender, EventArgs e)
        {

        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            string[] validUsers = { "brynt", "kass", "aiks", "admin" };
            string password = passTextBox.Text.Trim();
            string username = userTextBox.Text.Trim();

            //checks if username exists in array AND password is correct
            if (Array.Exists(validUsers, u => u == username) && password == "1234")
            {
                MessageBox.Show("Login successful!", "LOST AND FOUND SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //opens dashboard
                dashBoard dashboardForm = new dashBoard();
                dashboardForm.Show();

                this.Hide();//hides previous form ( login form )

                dashboardForm.FormClosed += (s, args) => Application.Exit();//app wont stay on memory
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "LOST AND FOUND SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passTextBox.Text = "";
                passTextBox.Focus();
            }
        }

        private void loginImage_Click(object sender, EventArgs e)
        {

        }
    }
}
