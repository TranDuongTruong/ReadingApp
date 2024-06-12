using System.Windows.Forms;

namespace ReadingCommicBook.GUI
{
    partial class frm_Manage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.textBox_chapter = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_cate = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.pc_avatar = new System.Windows.Forms.PictureBox();
            this.txt_Intro = new System.Windows.Forms.Label();
            this.richtxt_intro = new System.Windows.Forms.RichTextBox();
            this.txt_Lenght = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddChap = new System.Windows.Forms.Button();
            this.labk_Dashboard = new System.Windows.Forms.LinkLabel();
            this.labk_BInf = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(787, 505);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 46);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(535, 505);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(120, 46);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Thêm";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(661, 505);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 46);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // textBox_chapter
            // 
            this.textBox_chapter.Location = new System.Drawing.Point(1185, 232);
            this.textBox_chapter.Name = "textBox_chapter";
            this.textBox_chapter.ReadOnly = true;
            this.textBox_chapter.Size = new System.Drawing.Size(243, 22);
            this.textBox_chapter.TabIndex = 44;
            this.textBox_chapter.TextChanged += new System.EventHandler(this.textBox_chapter_TextChanged);
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(1185, 203);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(243, 22);
            this.textBox_status.TabIndex = 43;
            this.textBox_status.TextChanged += new System.EventHandler(this.textBox_status_TextChanged);
            // 
            // textBox_cate
            // 
            this.textBox_cate.Location = new System.Drawing.Point(1185, 175);
            this.textBox_cate.Name = "textBox_cate";
            this.textBox_cate.Size = new System.Drawing.Size(243, 22);
            this.textBox_cate.TabIndex = 42;
            this.textBox_cate.TextChanged += new System.EventHandler(this.textBox_cate_TextChanged);
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(1185, 147);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(243, 22);
            this.textBox_author.TabIndex = 41;
            this.textBox_author.TextChanged += new System.EventHandler(this.textBox_author_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(1185, 118);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(243, 22);
            this.textBox_name.TabIndex = 40;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // pc_avatar
            // 
            this.pc_avatar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pc_avatar.Location = new System.Drawing.Point(1454, 65);
            this.pc_avatar.Name = "pc_avatar";
            this.pc_avatar.Size = new System.Drawing.Size(227, 247);
            this.pc_avatar.TabIndex = 32;
            this.pc_avatar.TabStop = false;
            this.pc_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            this.pc_avatar.Click += new System.EventHandler(this.pc_avatar_Click);
            // 
            // txt_Intro
            // 
            this.txt_Intro.AutoSize = true;
            this.txt_Intro.Location = new System.Drawing.Point(1066, 320);
            this.txt_Intro.Name = "txt_Intro";
            this.txt_Intro.Size = new System.Drawing.Size(101, 16);
            this.txt_Intro.TabIndex = 39;
            this.txt_Intro.Text = "Thông tin truyện";
            // 
            // richtxt_intro
            // 
            this.richtxt_intro.Location = new System.Drawing.Point(1069, 366);
            this.richtxt_intro.Name = "richtxt_intro";
            this.richtxt_intro.Size = new System.Drawing.Size(612, 318);
            this.richtxt_intro.TabIndex = 38;
            this.richtxt_intro.Text = "";
            // 
            // txt_Lenght
            // 
            this.txt_Lenght.AutoSize = true;
            this.txt_Lenght.Location = new System.Drawing.Point(1084, 235);
            this.txt_Lenght.Name = "txt_Lenght";
            this.txt_Lenght.Size = new System.Drawing.Size(46, 16);
            this.txt_Lenght.TabIndex = 37;
            this.txt_Lenght.Text = "Độ dài";
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Location = new System.Drawing.Point(1084, 206);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(67, 16);
            this.txt_Status.TabIndex = 36;
            this.txt_Status.Text = "Trạng thái";
            // 
            // txt_category
            // 
            this.txt_category.AutoSize = true;
            this.txt_category.Location = new System.Drawing.Point(1084, 178);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(56, 16);
            this.txt_category.TabIndex = 35;
            this.txt_category.Text = "Thể loại";
            // 
            // txt_author
            // 
            this.txt_author.AutoSize = true;
            this.txt_author.Location = new System.Drawing.Point(1084, 150);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(55, 16);
            this.txt_author.TabIndex = 34;
            this.txt_author.Text = "Tác Giả";
            // 
            // txt_Title
            // 
            this.txt_Title.AutoSize = true;
            this.txt_Title.Location = new System.Drawing.Point(1084, 121);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(31, 16);
            this.txt_Title.TabIndex = 33;
            this.txt_Title.Text = "Tên";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(1185, 90);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(243, 22);
            this.textBox_id.TabIndex = 46;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1084, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID";
            // 
            // btn_AddChap
            // 
            this.btn_AddChap.Location = new System.Drawing.Point(1069, 690);
            this.btn_AddChap.Name = "btn_AddChap";
            this.btn_AddChap.Size = new System.Drawing.Size(136, 39);
            this.btn_AddChap.TabIndex = 47;
            this.btn_AddChap.Text = "Thêm Chap";
            this.btn_AddChap.UseVisualStyleBackColor = true;
            this.btn_AddChap.Click += new System.EventHandler(this.btn_AddChap_Click);
            // 
            // labk_Dashboard
            // 
            this.labk_Dashboard.AutoSize = true;
            this.labk_Dashboard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_Dashboard.Location = new System.Drawing.Point(0, -2);
            this.labk_Dashboard.Name = "labk_Dashboard";
            this.labk_Dashboard.Size = new System.Drawing.Size(49, 16);
            this.labk_Dashboard.TabIndex = 48;
            this.labk_Dashboard.TabStop = true;
            this.labk_Dashboard.Text = "Truyện";
            this.labk_Dashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labk_Dashboard_LinkClicked);
            // 
            // labk_BInf
            // 
            this.labk_BInf.AutoSize = true;
            this.labk_BInf.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labk_BInf.Location = new System.Drawing.Point(55, -2);
            this.labk_BInf.Name = "labk_BInf";
            this.labk_BInf.Size = new System.Drawing.Size(91, 16);
            this.labk_BInf.TabIndex = 49;
            this.labk_BInf.TabStop = true;
            this.labk_BInf.Text = "Quản lý truyện";
            this.labk_BInf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labk_BInf_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Danh sách truyện";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(913, 505);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 46);
            this.btn_Clear.TabIndex = 51;
            this.btn_Clear.Text = "Làm sạch";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 858);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labk_Dashboard);
            this.Controls.Add(this.labk_BInf);
            this.Controls.Add(this.btn_AddChap);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_chapter);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.textBox_cate);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pc_avatar);
            this.Controls.Add(this.txt_Intro);
            this.Controls.Add(this.richtxt_intro);
            this.Controls.Add(this.txt_Lenght);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Manage";
            this.Text = "frm_Manage";
            this.Load += new System.EventHandler(this.frm_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Edit;
        public TextBox textBox_chapter;
        public TextBox textBox_status;
        public TextBox textBox_cate;
        public TextBox textBox_author;
        public TextBox textBox_name;
        public PictureBox pc_avatar;
        private Label txt_Intro;
        public RichTextBox richtxt_intro;
        private Label txt_Lenght;
        private Label txt_Status;
        private Label txt_category;
        private Label txt_author;
        public Label txt_Title;
        public TextBox textBox_id;
        public Label label1;
        private Button btn_AddChap;
        private LinkLabel labk_Dashboard;
        private LinkLabel labk_BInf;
        private Label label2;
        private Button btn_Clear;
    }
}