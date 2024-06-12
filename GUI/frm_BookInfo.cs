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
    public partial class frm_BookInfo : Form
    {
        frm_Dashboard frm_Dashboard1;
        Bll_bookInfo bll_BookInfo ;
       public int numOfChap = 0;
        public string id,title;

        public frm_BookInfo(string id, string title,  string author,  string category,  bool status,  string length, string introduce, Image avatar,frm_Dashboard frm_Dashboard)
        {
            InitializeComponent();
            frm_Dashboard1=frm_Dashboard;
            bll_BookInfo=new Bll_bookInfo(this, frm_Dashboard);
            bll_BookInfo.LoadData(id, title, author, category, status, length, introduce, avatar);

        }

        private void BookInfo_Load(object sender, EventArgs e)
        {

        }

        private void txt_Lenght_Click(object sender, EventArgs e)
        {

        }

        private void pc_avatar_Click(object sender, EventArgs e)
        {

        }

        private void btn_LastChap_Click(object sender, EventArgs e)
        {
            bll_BookInfo.ReadingBook(this.id, this.title, this.numOfChap, this.numOfChap);
        }

        private void labk_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm_Dashboard1.Show();
            this.Close();
        }

        private void labk_BInf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_FirstChap_Click(object sender, EventArgs e)
        {
             bll_BookInfo.ReadingBook(this.id,this.title,1,this.numOfChap);
        }
    }
}
