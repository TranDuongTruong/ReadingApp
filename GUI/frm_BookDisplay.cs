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
    public partial class frm_BookDisplay : Form
    {
        frm_Dashboard frm_Dashboard1;
        frm_BookInfo frm_BookInfo1;
        public String content,id;
      public  int curentChap = 1,maxChap=0;
        
        Bl_BookDisplay bl_BookDisplay ;
        public frm_BookDisplay(String id, string title, int chap,int length, frm_Dashboard frm_Dashboard,frm_BookInfo frm_BookInfo)
        {
            bl_BookDisplay = new Bl_BookDisplay(this);
            InitializeComponent();
            bl_BookDisplay.LoadData(id, title, chap, length);
             this.frm_Dashboard1 = frm_Dashboard;
            this.frm_BookInfo1 = frm_BookInfo;
           

        }
     

        private void btn_Pervious_Click(object sender, EventArgs e)
        {
            curentChap--;
            if (curentChap <= 0) curentChap = 1;
            bl_BookDisplay. DisplayText();

        }

        private void labk_Dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm_Dashboard1.Show();
            this.Hide(); this.Close();
        }

        private void labk_BInf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm_BookInfo1.Show();
            this.Hide(); this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            curentChap++;
            if (curentChap >maxChap) curentChap = maxChap;
           bl_BookDisplay.DisplayText();
        }
    }
}
