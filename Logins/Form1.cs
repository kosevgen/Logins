using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK(object sender, EventArgs e)
        {
            
        }

        private void CLOSE(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
            
        }

        private void ABOUT(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            
            about.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
