using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace result_analysis_system_2
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            log_in_timer.Start();
        }

        private void log_in_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.25;

            }
            else
            {
                log_in_timer.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void tittlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPannelGUI()
        {
            // gui adjustments for expanding
            booksTabButton.Text = "BOOK";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionTabButton.Text = "TRANSACTIONS";
            AboutTabButton.Text = "ABOUT";

            booksTabButton.Image = null;
            BorrowersTabButton.Image = null;
            TransactionTabButton.Image = null;
            
            AboutTabButton.Image = null;

           
        }

        public void retractSlidingPannelGUI()
        {
            // gui adjustments for retracting
            booksTabButton.Text = "";
            BorrowersTabButton.Text = "";
            TransactionTabButton.Text = "";
            
            AboutTabButton.Text = "";

            booksTabButton.Image = Properties.Resources._519609_108_Bookmark_128;
            BorrowersTabButton.Image = Properties.Resources.icon_ios7_people_1281;
            TransactionTabButton.Image = Properties.Resources.transaction_ecommerce_shop_64;
            
            AboutTabButton.Image = Properties.Resources.about_64;


        }

        bool isSlidingPannelExpanded=true;
        bool t = true;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;


        private void button4_Click(object sender, EventArgs e)
        {
            if (t)
            {
             //   MessageBox.Show("Hello");
                SliddingPannel_Timer.Start();
                retractSlidingPannelGUI();
            }
            else
            {
                SliddingPannel_Timer.Start();
                expandSlidingPannelGUI();

            }
            t = !t;

        }

        private void slidingpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SliddingPannel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract panel
                slidingpanel.Width -= 30;
                if (slidingpanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = false;
                    SliddingPannel_Timer.Stop();

                 //   this.Refresh();
                }

            }
            else
            {
                //expand panel
                if (!isSlidingPannelExpanded)
                {
                    //retract panel
                    slidingpanel.Width += 30;
                    if (slidingpanel.Width >= MaxSliderWidth)
                    {
                        //stop retract
                        isSlidingPannelExpanded = true;
                        SliddingPannel_Timer.Stop();
                        //expandSlidingPannelGUI();

                 //       this.Refresh();
                    }
                }
            }
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(BorrowersUserControl1.Instance))
            {
                ContentPannel.Controls.Add(BorrowersUserControl1.Instance);
                BorrowersUserControl1.Instance.Dock = DockStyle.Fill;
                BorrowersUserControl1.Instance.BringToFront();
            }
            else
            {
                BorrowersUserControl1.Instance.BringToFront();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booksTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPannel.Controls.Contains(BooksUserControl1.Instance))
            {
                ContentPannel.Controls.Add(BooksUserControl1.Instance);
                BooksUserControl1.Instance.Dock = DockStyle.Fill;
                BooksUserControl1.Instance.BringToFront();
            }
            else
            {
                BooksUserControl1.Instance.BringToFront();
            }
        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPannel.Controls.Contains(TransactionUserControl1.Instance))
            {
                ContentPannel.Controls.Add(TransactionUserControl1.Instance);
                TransactionUserControl1.Instance.Dock = DockStyle.Fill;
                TransactionUserControl1.Instance.BringToFront();
            }
            else
            {
                TransactionUserControl1.Instance.BringToFront();
            }
        }

       

        private void AboutTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(AboutUserControl1.Instance))
            {
                ContentPannel.Controls.Add(AboutUserControl1.Instance);
                AboutUserControl1.Instance.Dock = DockStyle.Fill;
                AboutUserControl1.Instance.BringToFront();
            }
            else
            {
                AboutUserControl1.Instance.BringToFront();
            }

        }

        private void tittlebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
