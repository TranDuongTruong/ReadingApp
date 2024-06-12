using ReadingCommicBook.DAL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCommicBook.BLL
{
    
    internal class Bll_bookInfo
    {
        frm_Dashboard frm_Dashboard;
        frm_BookInfo frm_BookInfo;

        public Bll_bookInfo(frm_BookInfo frm_BookInfo, frm_Dashboard frm_Dashboard)
        {
            this.frm_BookInfo = frm_BookInfo;
            this.frm_Dashboard = frm_Dashboard;
        }

        Dal_BookInfo dal_BookInfo = new Dal_BookInfo();

        public void ReadingBook(string id,string title,int chap,int length)
        {
            frm_BookDisplay bookDisplay = new frm_BookDisplay(id, title, chap,length,frm_Dashboard,frm_BookInfo);
            bookDisplay.Show();
            frm_BookInfo.Hide();

        }
        public void LoadData(string id, string title, string author, string category, bool status, string length, string introduce, Image avatar)
        {
            frm_BookInfo.pc_avatar.Image = avatar;
            frm_BookInfo.txt_Title.Text = title;
            frm_BookInfo.txt_author.Text = "Tác giả" + author;
            frm_BookInfo.txt_category.Text = "Thể loại: " + category;
            frm_BookInfo.txt_Status.Text = "Trạng thái:" + (status ? "Hoàn thành" : "Chưa hoàn thành");
            frm_BookInfo.txt_Lenght.Text = "Số chương:" + length;
            frm_BookInfo.richtxt_intro.Text = introduce;
            frm_BookInfo.txt_Intro.Text = "Thông tin truyện :";
            frm_BookInfo.labk_BInf.Text = "  /   " + title;
            frm_BookInfo.numOfChap = int.Parse(length);


            frm_BookInfo.id = id;
            frm_BookInfo.title = title;
          
        }
    }
}
