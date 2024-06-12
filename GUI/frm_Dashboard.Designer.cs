using ReadingCommicBook.DAL;

namespace ReadingCommicBook

{
    partial class frm_Dashboard
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
            this.txt_find = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pn_Dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_contentParent = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_content = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_FindResult = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Manage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Dashboard.SuspendLayout();
            this.pn_contentParent.SuspendLayout();
            this.pn_FindResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_find
            // 
            this.txt_find.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_find.Location = new System.Drawing.Point(3, 3);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(286, 22);
            this.txt_find.TabIndex = 5;
            this.txt_find.Text = "Find book";
            this.txt_find.Click += new System.EventHandler(this.textBox1_Click);
            this.txt_find.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pn_Dashboard
            // 
            this.pn_Dashboard.Controls.Add(this.pn_contentParent);
            this.pn_Dashboard.Location = new System.Drawing.Point(4, 57);
            this.pn_Dashboard.Name = "pn_Dashboard";
            this.pn_Dashboard.Size = new System.Drawing.Size(1299, 864);
            this.pn_Dashboard.TabIndex = 5;
            this.pn_Dashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // pn_contentParent
            // 
            this.pn_contentParent.Controls.Add(this.label2);
            this.pn_contentParent.Controls.Add(this.panel1);
            this.pn_contentParent.Controls.Add(this.pn_content);
            this.pn_contentParent.Location = new System.Drawing.Point(3, 3);
            this.pn_contentParent.Name = "pn_contentParent";
            this.pn_contentParent.Size = new System.Drawing.Size(1290, 861);
            this.pn_contentParent.TabIndex = 3;
            this.pn_contentParent.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_contentParent_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Truyện mới cập nhật";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(137, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 24);
            this.panel1.TabIndex = 4;
            // 
            // pn_content
            // 
            this.pn_content.AutoScroll = true;
            this.pn_content.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pn_content.Location = new System.Drawing.Point(3, 33);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1261, 828);
            this.pn_content.TabIndex = 1;
            this.pn_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_content_Paint_1);
            // 
            // pn_FindResult
            // 
            this.pn_FindResult.Controls.Add(this.txt_find);
            this.pn_FindResult.Location = new System.Drawing.Point(505, 2);
            this.pn_FindResult.Name = "pn_FindResult";
            this.pn_FindResult.Size = new System.Drawing.Size(289, 49);
            this.pn_FindResult.TabIndex = 8;
            this.pn_FindResult.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_2);
            // 
            // btn_Manage
            // 
            this.btn_Manage.Location = new System.Drawing.Point(1191, 2);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(112, 49);
            this.btn_Manage.TabIndex = 9;
            this.btn_Manage.Text = "Quản lý";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "KAT_TRUYỆN.VN";
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 933);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Manage);
            this.Controls.Add(this.pn_FindResult);
            this.Controls.Add(this.pn_Dashboard);
            this.Name = "frm_Dashboard";
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.pn_Dashboard.ResumeLayout(false);
            this.pn_contentParent.ResumeLayout(false);
            this.pn_contentParent.PerformLayout();
            this.pn_FindResult.ResumeLayout(false);
            this.pn_FindResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel pn_Dashboard;
        private System.Windows.Forms.FlowLayoutPanel pn_contentParent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel pn_content;
        public System.Windows.Forms.FlowLayoutPanel pn_FindResult;
        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Label label1;
    }
}