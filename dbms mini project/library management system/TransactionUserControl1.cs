using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace result_analysis_system_2
{
    public partial class TransactionUserControl1 : UserControl
    {
        private static TransactionUserControl1 _instance;

        public static TransactionUserControl1 Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new TransactionUserControl1();

                }
                return _instance;
            }
        }
        public TransactionUserControl1()
        {
            InitializeComponent();
        }

        private void TransactionUserControl1_Load(object sender, EventArgs e)
        {

        }
        public string Book1, Book2, Borrower;
        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            if(Borrower!="")
            {
                MessageBox.Show("Book is already borrowed by some other borrower with borrower id:\n" + Borrower);
                return;
            }
            button2.PerformClick();
            if((Book1!="")&&(Book2!=""))
            {
                MessageBox.Show("Borrower has already borrowed maximum no. of books");
                return;
            }

            try
            {
                if(Book1=="")
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);

                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno",textBox1.Text);
                cmd.Parameters.AddWithValue("@brid", maskedTextBox1.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("          <<<<<<INVALID SQL OPERATION>>>>>>\n" + ex);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", textBox1.Text);
            cmd.Parameters.AddWithValue("@brid", maskedTextBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("      <<<<<<<INVALID SQL OPERATION>>>>>\n" + ex);
            }
            con.Close();

            cmd = new SqlCommand("transaction_insert_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", textBox1.Text);
            cmd.Parameters.AddWithValue("@brid", maskedTextBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("     <<<<<<INVALID SQL OPERATION>>>>>  \n" + ex);
            }
            con.Close();
            button1.PerformClick();
            button2.PerformClick();
            MessageBox.Show("Successfully issued");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            button2.PerformClick();
            if ((textBox1.Text!=Book1)&&(textBox1.Text!=Book2))
            {
                MessageBox.Show("the inputed borrower has not borrowed the book inputed");
                return;
            }
            try
            {
                if (Book1 == textBox1.Text)
                {
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);

                }
                else
                {
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno",(object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brid", maskedTextBox1.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("          <<<<<<INVALID SQL OPERATION>>>>>>\n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", textBox1.Text);
            cmd.Parameters.AddWithValue("@brid",(object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("      <<<<<<<INVALID SQL OPERATION>>>>>\n" + ex);
            }
            con.Close();



            
            button1.PerformClick();
            button2.PerformClick();
            MessageBox.Show("Successfully returned");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowTransactionLog_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<INVALID SQL OPERATION \n" + ex);

                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT borrower FROM books where accNo='" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label4.Text = Borrower = dr[0].ToString();
            con.Close();
        }

         

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT Book1 FROM Borrowers where Brid='" + maskedTextBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label8.Text = Book1 = dr[0].ToString();
            con.Close();

            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where Brid='" + maskedTextBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            label6.Text = Book2 = dr[0].ToString();
            con.Close();
        }
    }
}
