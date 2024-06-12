using ReadingCommicBook.BLL;
using ReadingCommicBook.DAL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingCommicBook
{
    public partial class frm_Dashboard : Form
    {
       
        Bll_dashboard bll_Dashboard;
        public frm_Dashboard()
        {
            InitializeComponent();

            bll_Dashboard = new Bll_dashboard(this);
            bll_Dashboard. LoadData();

        }

       
        public void HidePnDashboard()
        {
            pn_Dashboard.Hide();
        }
        private void frm_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            bll_Dashboard.FindBooks(txt_find.Text);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
             if (this.txt_find.Text == "Find book") this.txt_find.Text = "";
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pn_content_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pn_content_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pn_SlideItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_contentParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void i_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            frm_Manage frm_Manage=new frm_Manage(this.bll_Dashboard);
            frm_Manage.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
