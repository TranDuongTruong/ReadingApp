using ReadingCommicBook.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingCommicBook.GUI
{
    public partial class frm_Manage : Form
    {
        Bll_Manage bll_Manage;
       public Bll_dashboard bll_Dashboard;
        public frm_Manage(Bll_dashboard bll_Dashboard)
        {
           this.bll_Dashboard = bll_Dashboard;
            InitializeComponent();
           bll_Manage = new Bll_Manage(this); 
            LoadData();
        }
        public void LoadData()
        {
            bll_Manage.bll_Grid();
        }
        private void frm_Manage_Load(object sender, EventArgs e)
        {

        }

        private void txt_category_Click(object sender, EventArgs e)
        {

        }

        private void txt_Lenght_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                bll_Manage.ShowInfo(this.bll_Dashboard, id);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            bll_Manage.Add();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            bll_Manage.Edit();
            LoadData();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_chapter_TextChanged(object sender, EventArgs e)
        {

        }

        private void pc_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODF = new OpenFileDialog();
            ODF.Title = "Hãy chọn ảnh";
    //        ODF.Filter = "Tất cả đuôi .jpg";
            if (ODF.ShowDialog() == DialogResult.OK)
            {
                Image newImage= Image.FromFile(ODF.FileName);
                pc_avatar.Image = newImage;

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                bll_Manage.Delete(id);
                LoadData();
                bll_Manage.Clear();
            }
            
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddChap_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(this.textBox_chapter.Text, out n))
            {
                MessageBox.Show("Vui lòng chọn truyện muốn thêm chương.");
                return;
            }
            string newChap=int.Parse(this.textBox_chapter.Text.ToString())+1+"";
            frm_AddChap frm_AddChap = new frm_AddChap(this, newChap);
            frm_AddChap.Show();
            this.Hide();
        }
        public void AddChap(String content)
        {
            bll_Manage.AddChap(content);
            LoadData();
        }

        private void labk_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.bll_Dashboard.frm_Dashboard.Show();
            this.bll_Dashboard.LoadData();
            this.Close();
        }

        private void labk_BInf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.bll_Manage.Clear();
        }
    }
}
