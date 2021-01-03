using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace result_analysis_system_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
       private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool validate(string name,string pass)
        {
            //fetch data from database
            //Message Box.Show(name + "    " + pass);
            con.Open();
            String syntax = $"SELECT Value FROM systemTable where Property='{name}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                con.Close();
                return false;
            }
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            if (temp == pass)
                return true;
            return false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            if(validate(name,pass))
            {
                //login
                label4.Hide();
                
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
           else
            {
                //dont login
                label4.Visible=true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
