using ReadingCommicBook.DAL;
using System.Windows.Forms;

namespace ReadingCommicBook.GUI
{
    partial class frm_BookInfo
    {
        BaseClass baseClass = new BaseClass();
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
            this.pc_avatar = new System.Windows.Forms.PictureBox();
            this.txt_Title = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.Label();
            this.txt_Lenght = new System.Windows.Forms.Label();
            this.btn_FirstChap = new System.Windows.Forms.Button();
            this.btn_LastChap = new System.Windows.Forms.Button();
            this.richtxt_intro = new System.Windows.Forms.RichTextBox();
            this.txt_Introduce = new System.Windows.Forms.Label();
            this.txt_Intro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labk_Dashboard = new System.Windows.Forms.LinkLabel();
            this.labk_BInf = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pc_avatar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pc_avatar
            // 
            this.pc_avatar.Location = new System.Drawing.Point(22, 50);
            this.pc_avatar.Name = "pc_avatar";
            this.pc_avatar.Size = new System.Drawing.Size(454, 673);
            this.pc_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_avatar.TabIndex = 0;
            this.pc_avatar.TabStop = false;
            this.pc_avatar.Click += new System.EventHandler(this.pc_avatar_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.AutoSize = true;
            this.txt_Title.Location = new System.Drawing.Point(532, 50);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(189, 16);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.Text = "ĐẠI QUẢN GIA LÀ MA HOÀNG";
            // 
            // txt_author
            // 
            this.txt_author.AutoSize = true;
            this.txt_author.Location = new System.Drawing.Point(531, 84);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(57, 16);
            this.txt_author.TabIndex = 2;
            this.txt_author.Text = " Dạ Kiêu";
            // 
            // txt_category
            // 
            this.txt_category.AutoSize = true;
            this.txt_category.Location = new System.Drawing.Point(533, 113);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(56, 16);
            this.txt_category.TabIndex = 3;
            this.txt_category.Text = "Thể loại";
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Location = new System.Drawing.Point(531, 141);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(67, 16);
            this.txt_Status.TabIndex = 4;
            this.txt_Status.Text = "Trạng thái";
            // 
            // txt_Lenght
            // 
            this.txt_Lenght.AutoSize = true;
            this.txt_Lenght.Location = new System.Drawing.Point(533, 166);
            this.txt_Lenght.Name = "txt_Lenght";
            this.txt_Lenght.Size = new System.Drawing.Size(46, 16);
            this.txt_Lenght.TabIndex = 5;
            this.txt_Lenght.Text = "Độ dài";
            this.txt_Lenght.Click += new System.EventHandler(this.txt_Lenght_Click);
            // 
            // btn_FirstChap
            // 
            this.btn_FirstChap.Location = new System.Drawing.Point(22, 748);
            this.btn_FirstChap.Name = "btn_FirstChap";
            this.btn_FirstChap.Size = new System.Drawing.Size(231, 52);
            this.btn_FirstChap.TabIndex = 6;
            this.btn_FirstChap.Text = "Đọc từ đầu";
            this.btn_FirstChap.UseVisualStyleBackColor = true;
            this.btn_FirstChap.Click += new System.EventHandler(this.btn_FirstChap_Click);
            // 
            // btn_LastChap
            // 
            this.btn_LastChap.Location = new System.Drawing.Point(259, 748);
            this.btn_LastChap.Name = "btn_LastChap";
            this.btn_LastChap.Size = new System.Drawing.Size(217, 52);
            this.btn_LastChap.TabIndex = 7;
            this.btn_LastChap.Text = "Chap mới nhất";
            this.btn_LastChap.UseVisualStyleBackColor = true;
            this.btn_LastChap.Click += new System.EventHandler(this.btn_LastChap_Click);
            // 
            // richtxt_intro
            // 
            this.richtxt_intro.Location = new System.Drawing.Point(482, 309);
            this.richtxt_intro.Name = "richtxt_intro";
            this.richtxt_intro.Size = new System.Drawing.Size(805, 345);
            this.richtxt_intro.TabIndex = 8;
            this.richtxt_intro.Text = "";
            // 
            // txt_Introduce
            // 
            this.txt_Introduce.AutoSize = true;
            this.txt_Introduce.Location = new System.Drawing.Point(492, 267);
            this.txt_Introduce.Name = "txt_Introduce";
            this.txt_Introduce.Size = new System.Drawing.Size(0, 16);
            this.txt_Introduce.TabIndex = 9;
            // 
            // txt_Intro
            // 
            this.txt_Intro.AutoSize = true;
            this.txt_Intro.Location = new System.Drawing.Point(479, 276);
            this.txt_Intro.Name = "txt_Intro";
            this.txt_Intro.Size = new System.Drawing.Size(101, 16);
            this.txt_Intro.TabIndex = 10;
            this.txt_Intro.Text = "Thông tin truyện";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.labk_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.labk_BInf);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1302, 29);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // labk_Dashboard
            // 
            this.labk_Dashboard.AutoSize = true;
            this.labk_Dashboard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_Dashboard.Location = new System.Drawing.Point(3, 0);
            this.labk_Dashboard.Name = "labk_Dashboard";
            this.labk_Dashboard.Size = new System.Drawing.Size(49, 16);
            this.labk_Dashboard.TabIndex = 0;
            this.labk_Dashboard.TabStop = true;
            this.labk_Dashboard.Text = "Truyện";
            this.labk_Dashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labk_Dashboard_LinkClicked);
            // 
            // labk_BInf
            // 
            this.labk_BInf.AutoSize = true;
            this.labk_BInf.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_BInf.Location = new System.Drawing.Point(58, 0);
            this.labk_BInf.Name = "labk_BInf";
            this.labk_BInf.Size = new System.Drawing.Size(178, 16);
            this.labk_BInf.TabIndex = 1;
            this.labk_BInf.TabStop = true;
            this.labk_BInf.Text = "Đại Quảng Gia Là Ma Hoàng";
            this.labk_BInf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labk_BInf_LinkClicked);
            // 
            // frm_BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 823);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pc_avatar);
            this.Controls.Add(this.txt_Intro);
            this.Controls.Add(this.txt_Introduce);
            this.Controls.Add(this.richtxt_intro);
            this.Controls.Add(this.btn_LastChap);
            this.Controls.Add(this.btn_FirstChap);
            this.Controls.Add(this.txt_Lenght);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_Title);
            this.Name = "frm_BookInfo";
            this.Text = "BookInfo";
            this.Load += new System.EventHandler(this.BookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_avatar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pc_avatar;
        public System.Windows.Forms.Label txt_Title;
        public System.Windows.Forms.Label txt_author;
        public System.Windows.Forms.Label txt_category;
        public System.Windows.Forms.Label txt_Status;
        public System.Windows.Forms.Label txt_Lenght;
        public System.Windows.Forms.Button btn_FirstChap;
        public System.Windows.Forms.Button btn_LastChap;
        public System.Windows.Forms.RichTextBox richtxt_intro;
        public System.Windows.Forms.Label txt_Introduce;
        public System.Windows.Forms.Label txt_Intro;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.LinkLabel labk_Dashboard;
        public System.Windows.Forms.LinkLabel labk_BInf;
    }
}