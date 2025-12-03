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

        private void button1_Click(object sender, EventArgs e)
        {
            testForm nextForm = new testForm();
            nextForm.FormClosed += (s, args) => Application.Exit(); // exits the form when clicking x
            nextForm.Show(); // Show the second form
            this.Hide();// hide first form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
