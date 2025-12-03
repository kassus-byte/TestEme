using System.Windows.Forms;
using System.Drawing;
using System;

namespace TestEme
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundCornersTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void roundCornersTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void roundCornersButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
