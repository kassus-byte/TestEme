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
            string username = userTextBox.Text.Trim();
            string password = passTextBox.Text.Trim();

            // Simple hardcoded check
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open dashBoard form
                dashBoard dashboardForm = new dashBoard();
                dashboardForm.Show();

                // Hide login form
                this.Hide();
                dashboardForm.FormClosed += (s, args) => Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passTextBox.Text = "";
                passTextBox.Focus();
            }
        }
    }
}
