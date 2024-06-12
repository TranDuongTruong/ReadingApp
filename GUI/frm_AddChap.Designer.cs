namespace ReadingCommicBook.GUI
{
    partial class frm_AddChap
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.labk_Dashboard = new System.Windows.Forms.LinkLabel();
            this.labk_BInf = new System.Windows.Forms.LinkLabel();
            this.labk_Chap = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1339, 707);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1213, 770);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 36);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1077, 770);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(584, 20);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(49, 16);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Chap 1";
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
            this.labk_BInf.Size = new System.Drawing.Size(91, 16);
            this.labk_BInf.TabIndex = 1;
            this.labk_BInf.TabStop = true;
            this.labk_BInf.Text = "Quản lý truyện";
            this.labk_BInf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labk_BInf_LinkClicked);
            // 
            // labk_Chap
            // 
            this.labk_Chap.AutoSize = true;
            this.labk_Chap.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_Chap.Location = new System.Drawing.Point(155, 0);
            this.labk_Chap.Name = "labk_Chap";
            this.labk_Chap.Size = new System.Drawing.Size(106, 16);
            this.labk_Chap.TabIndex = 13;
            this.labk_Chap.TabStop = true;
            this.labk_Chap.Text = "Thêm truyện mới";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.labk_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.labk_BInf);
            this.flowLayoutPanel1.Controls.Add(this.labk_Chap);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 29);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // frm_AddChap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 818);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frm_AddChap";
            this.Text = "frm_AddChap";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.LinkLabel labk_Dashboard;
        private System.Windows.Forms.LinkLabel labk_BInf;
        private System.Windows.Forms.LinkLabel labk_Chap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}