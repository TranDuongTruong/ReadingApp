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
    public partial class frm_AddChap : Form
    {
        frm_Manage frm_Manage;
        public frm_AddChap(frm_Manage frm_Manage, string chap)
        {
            this.frm_Manage = frm_Manage;
            InitializeComponent();
            this.lb_title.Text = "Chương "+chap;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.frm_Manage.AddChap(this.richTextBox1.Text.ToString());
            this.frm_Manage.Show();
            this.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labk_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm_Manage.bll_Dashboard.frm_Dashboard.Show();
            this.frm_Manage.bll_Dashboard.LoadData();
            this.Close();this.frm_Manage.Close();
        }

        private void labk_BInf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm_Manage.Show();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.frm_Manage.Show();
            this.Close();
        }
    }
}
