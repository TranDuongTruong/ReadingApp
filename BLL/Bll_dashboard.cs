using ReadingCommicBook.DAL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingCommicBook.BLL
{
    public class Bll_dashboard
    {
       public List<BookItem> bookItems = new List<BookItem>();
        public  DAL_dashboard dal_dashboard = new DAL_dashboard();
       public frm_Dashboard frm_Dashboard;

        public Bll_dashboard(frm_Dashboard frm_Dashboard)
        {
            this.frm_Dashboard = frm_Dashboard;
        }

        public void LoadData()
        {

            ClearAllBooks();
            List<Book> books = new List<Book>();
            string sqlDL = "SELECT BookID, Title, Author, PublicationDate, NumberOfChapters, Category, Status FROM Books";
            books = dal_dashboard.baseClass.LoadData1(sqlDL);
            foreach (Book book in books)
            {

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = dal_dashboard.baseClass.LoadImage(book.BookID + ".jpg");
                BookItem item = new BookItem(book.BookID.ToString(), book.NumberOfChapters.ToString(), book.Author.ToString(), book.Title.ToString(), pictureBox, book.category.ToString(), book.status, this);
                bookItems.Add(item);
                frm_Dashboard.pn_content.Controls.Add(item);

            }
        }
        public void ClearAllBooks()
        {
            while (frm_Dashboard.pn_content.Controls.Count > 0)
            {
                Control control = frm_Dashboard.pn_content.Controls[0];
                frm_Dashboard.pn_content.Controls.Remove(control);
                control.Dispose();
            }

        }
        internal void LoadBookInfo(Image avatar ,string id, string title, String author, string category, bool status, string lenght)
        {
            String intro = dal_dashboard.baseClass.LoadTextFile(id+"_intro.txt");                 
            frm_BookInfo bookInfo = new frm_BookInfo(id, title, author, category, status, lenght, intro, avatar,frm_Dashboard);
            bookInfo.Show();
            frm_Dashboard.Hide();
            frm_Dashboard.txt_find.Text = "";


        }

     
        internal void FindBooks(string text)
        {
            string keyword = text.ToLower();
            ClearButtons(frm_Dashboard.pn_FindResult);
            Console.WriteLine(keyword);
        
            if (text.Length > 0)
                foreach (BookItem item in bookItems)
                {
                    if (item.txt_bookName.Text.ToString().ToLower().Contains(keyword))
                    {
                       // Console.WriteLine("\t" + item.txt_bookName.Text.ToString());
                        FindItem findItem = new FindItem(this, item);
                        frm_Dashboard.pn_FindResult.Controls.Add(findItem);
                        frm_Dashboard.pn_FindResult.Height += 40;
                    }
                }
            
        }
        private void ClearButtons(Panel panel)
        {
            while (panel.Controls.Count > 1)
            {

                Control control = panel.Controls[1];

                panel.Controls.Remove(control);   frm_Dashboard.pn_FindResult.Height -= 40;
                control.Dispose();
            }
         


        }    
    }
}
