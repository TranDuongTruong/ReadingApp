using ReadingCommicBook.DAL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCommicBook.BLL
{
    internal class Bll_Manage
    {
       public Dal_Manage dal_Manage = new Dal_Manage();
        public frm_Manage frm_Manage;
        List<Book> books = new List<Book>();
        Book selectedBook;
        public Bll_Manage(frm_Manage frm_Manage)
        {
            this.frm_Manage = frm_Manage;
        }
        public void bll_Grid()
        {
            frm_Manage.dataGridView1.DataSource = dal_Manage.dal_Grid();
            string sqlDL = "SELECT BookID, Title, Author, PublicationDate, NumberOfChapters, Category, Status FROM Books";
            books= dal_Manage.baseClass.LoadData1(sqlDL);

        }

        internal void ShowInfo(Bll_dashboard bll_Dashboard,string id)
        {
            
            foreach (Book book in books)
            {
                if (book.BookID.ToString() == id)
                {
                    selectedBook = book;
                    setInfo(book);
                    return;
                }
            }

       
            
            
        } 
        public void setInfo(Book book)
        {
            frm_Manage.textBox_id.Text = book.BookID.ToString();
            frm_Manage.textBox_name.Text = book.Title;
            frm_Manage.textBox_author.Text = book.Author;
            frm_Manage.textBox_cate.Text = book.category;
            frm_Manage.textBox_chapter.Text = book.NumberOfChapters.ToString();
            frm_Manage.textBox_status.Text = book.status ? "Hoàn thành" : "Chưa Hoàn Thành";
            frm_Manage.pc_avatar.Image = dal_Manage.baseClass.LoadImage(book.BookID + ".jpg");
            frm_Manage.richtxt_intro.Text = dal_Manage.baseClass.LoadTextFile(book.BookID + "_intro.txt");

        }

        internal void Add()
        {
            
            dal_Manage.Add(frm_Manage.textBox_name.Text, frm_Manage.textBox_author.Text, frm_Manage.textBox_chapter.Text, frm_Manage.textBox_cate.Text, (frm_Manage.textBox_status.Text.ToLower() == "hoàn thành" ? true : false), frm_Manage.textBox_id.Text);
            bll_Grid();
            dal_Manage.baseClass.CreateTextFile(books[books.Count - 1].BookID + "_intro", frm_Manage.richtxt_intro.Text.ToString());

        
        }

        internal void Edit()
        {
           // dal_Manage.baseClass.UpdateImage(selectedBook.BookID.ToString(), frm_Manage.textBox_id.Text, frm_Manage.pc_avatar.Image);
            dal_Manage.baseClass.UpdateTextFile(selectedBook.BookID + "_intro.txt", frm_Manage.textBox_id.Text.ToString() + "_intro.txt", frm_Manage.richtxt_intro.Text.ToString());
            dal_Manage.Edit(frm_Manage.textBox_name.Text, frm_Manage.textBox_author.Text, frm_Manage.textBox_chapter.Text, frm_Manage.textBox_cate.Text,(frm_Manage.textBox_status.Text.ToLower()=="hoàn thành"?true:false),frm_Manage.textBox_id.Text);
        
        
        }
       public void Delete(string id)
        {
            dal_Manage.Delete(id);
        }

        internal void AddChap(string content)
        {
            frm_Manage.textBox_chapter.Text = (int.Parse(frm_Manage.textBox_chapter.Text.ToString()) + 1).ToString();
            this.dal_Manage.baseClass.CreateTextFile(frm_Manage.textBox_id.Text + "_c" + frm_Manage.textBox_chapter.Text.ToString(), content);
            dal_Manage.Edit(frm_Manage.textBox_name.Text, frm_Manage.textBox_author.Text, frm_Manage.textBox_chapter.Text, frm_Manage.textBox_cate.Text, (frm_Manage.textBox_status.Text.ToLower() == "hoàn thành" ? true : false), frm_Manage.textBox_id.Text);

        }

        internal void Clear()
        {
            frm_Manage.textBox_id.Text ="";
            frm_Manage.textBox_name.Text = "";
            frm_Manage.textBox_author.Text = "";
            frm_Manage.textBox_cate.Text = "";
            frm_Manage.textBox_chapter.Text = "";
            frm_Manage.textBox_status.Text = "";
            frm_Manage.pc_avatar.Image = null;
            frm_Manage.richtxt_intro.Text = "";


        }
    }
}
