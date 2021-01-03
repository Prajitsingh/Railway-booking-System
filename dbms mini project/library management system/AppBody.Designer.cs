namespace result_analysis_system_2
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.log_in_timer = new System.Windows.Forms.Timer(this.components);
            this.tittlebar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.booksTabButton = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SliddingPannel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.tittlebar.SuspendLayout();
            this.slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_in_timer
            // 
            this.log_in_timer.Interval = 50;
            this.log_in_timer.Tick += new System.EventHandler(this.log_in_timer_Tick);
            // 
            // tittlebar
            // 
            this.tittlebar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tittlebar.Controls.Add(this.button3);
            this.tittlebar.Controls.Add(this.button2);
            this.tittlebar.Controls.Add(this.button1);
            this.tittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tittlebar.Location = new System.Drawing.Point(0, 0);
            this.tittlebar.Name = "tittlebar";
            this.tittlebar.Size = new System.Drawing.Size(1176, 33);
            this.tittlebar.TabIndex = 0;
            this.tittlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.tittlebar_Paint);
            this.tittlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tittlebar_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Turquoise;
            this.button3.Location = new System.Drawing.Point(1116, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 33);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(1086, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 33);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(1146, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.slidingpanel.Controls.Add(this.booksTabButton);
            this.slidingpanel.Controls.Add(this.BorrowersTabButton);
            this.slidingpanel.Controls.Add(this.TransactionTabButton);
            this.slidingpanel.Controls.Add(this.AboutTabButton);
            this.slidingpanel.Controls.Add(this.button4);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Location = new System.Drawing.Point(0, 33);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(300, 601);
            this.slidingpanel.TabIndex = 1;
            this.slidingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slidingpanel_Paint);
            // 
            // booksTabButton
            // 
            this.booksTabButton.BackColor = System.Drawing.Color.Transparent;
            this.booksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksTabButton.Image = ((System.Drawing.Image)(resources.GetObject("booksTabButton.Image")));
            this.booksTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksTabButton.Location = new System.Drawing.Point(0, 76);
            this.booksTabButton.Name = "booksTabButton";
            this.booksTabButton.Size = new System.Drawing.Size(299, 86);
            this.booksTabButton.TabIndex = 7;
            this.booksTabButton.Text = "BOOKS";
            this.booksTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.booksTabButton.UseVisualStyleBackColor = false;
            this.booksTabButton.Click += new System.EventHandler(this.booksTabButton_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowersTabButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrowersTabButton.Image")));
            this.BorrowersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowersTabButton.Location = new System.Drawing.Point(0, 268);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(300, 104);
            this.BorrowersTabButton.TabIndex = 6;
            this.BorrowersTabButton.Text = "BORROWERS";
            this.BorrowersTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrowersTabButton.UseVisualStyleBackColor = false;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTabButton.Image = global::result_analysis_system_2.Properties.Resources.transaction_ecommerce_shop_64;
            this.TransactionTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionTabButton.Location = new System.Drawing.Point(0, 162);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(300, 107);
            this.TransactionTabButton.TabIndex = 5;
            this.TransactionTabButton.Text = "TRANSACTION";
            this.TransactionTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransactionTabButton.UseVisualStyleBackColor = false;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutTabButton.Image")));
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(0, 371);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(300, 99);
            this.AboutTabButton.TabIndex = 4;
            this.AboutTabButton.Text = "REPORT";
            this.AboutTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::result_analysis_system_2.Properties.Resources.double_arrow_left_64;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 77);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SliddingPannel_Timer
            // 
            this.SliddingPannel_Timer.Tick += new System.EventHandler(this.SliddingPannel_Timer_Tick);
            // 
            // ContentPannel
            // 
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPannel.Location = new System.Drawing.Point(299, 33);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(877, 601);
            this.ContentPannel.TabIndex = 2;
            this.ContentPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 634);
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.slidingpanel);
            this.Controls.Add(this.tittlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.tittlebar.ResumeLayout(false);
            this.slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer log_in_timer;
        private System.Windows.Forms.Panel tittlebar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer SliddingPannel_Timer;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button booksTabButton;
        private System.Windows.Forms.Panel ContentPannel;
    }
}