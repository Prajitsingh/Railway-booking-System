using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace result_analysis_system_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname="1", Upass="1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                label4.Hide();
                MessageBox.Show("log in is success");
            }
           else
            {
                //dont login
                label4.Show();
            }

        }
    }
}
