using ReadingCommicBook.DAL;

namespace ReadingCommicBook.GUI
{
    partial class frm_BookDisplay
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Pervious = new System.Windows.Forms.Button();
            this.com_chapter = new System.Windows.Forms.ComboBox();
            this.labk_Dashboard = new System.Windows.Forms.LinkLabel();
            this.labk_BInf = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labk_Chap = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1299, 823);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1209, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(78, 31);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = ">>";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Pervious
            // 
            this.btn_Pervious.Location = new System.Drawing.Point(1001, 5);
            this.btn_Pervious.Name = "btn_Pervious";
            this.btn_Pervious.Size = new System.Drawing.Size(78, 31);
            this.btn_Pervious.TabIndex = 2;
            this.btn_Pervious.Text = "<<";
            this.btn_Pervious.UseVisualStyleBackColor = true;
            this.btn_Pervious.Click += new System.EventHandler(this.btn_Pervious_Click);
            // 
            // com_chapter
            // 
            this.com_chapter.FormattingEnabled = true;
            this.com_chapter.Location = new System.Drawing.Point(1075, 9);
            this.com_chapter.Name = "com_chapter";
            this.com_chapter.Size = new System.Drawing.Size(134, 24);
            this.com_chapter.TabIndex = 3;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.labk_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.labk_BInf);
            this.flowLayoutPanel1.Controls.Add(this.labk_Chap);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 29);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // labk_Chap
            // 
            this.labk_Chap.AutoSize = true;
            this.labk_Chap.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_Chap.Location = new System.Drawing.Point(242, 0);
            this.labk_Chap.Name = "labk_Chap";
            this.labk_Chap.Size = new System.Drawing.Size(49, 16);
            this.labk_Chap.TabIndex = 13;
            this.labk_Chap.TabStop = true;
            this.labk_Chap.Text = "Chap 1";
            // 
            // frm_BookDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 864);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.com_chapter);
            this.Controls.Add(this.btn_Pervious);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frm_BookDisplay";
            this.Text = "BookDisplay";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button btn_Next;
        public System.Windows.Forms.Button btn_Pervious;
        public System.Windows.Forms.ComboBox com_chapter;
        public System.Windows.Forms.LinkLabel labk_Dashboard;
        public System.Windows.Forms.LinkLabel labk_BInf;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.LinkLabel labk_Chap;
    }
}