using ReadingCommicBook.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingCommicBook.BLL
{
    internal class FindItem : Button
    {
        Bll_dashboard bll_Dashboard; BookItem item;
        public FindItem(Bll_dashboard bll_Dashboard, BookItem item)
        {
            this.item = item;
          this.bll_Dashboard = bll_Dashboard;
            this.Location = new System.Drawing.Point(3, 31);
            this.Name = "button1";
            this.Size = new System.Drawing.Size(286, 40);
            this.TabIndex = 6;
            this.Text = item.txt_bookName.Text.ToString();
           
            this.UseVisualStyleBackColor = true;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Click += FindItemClickHandler;

        }
        private void FindItemClickHandler(object sender, EventArgs e)
        {
            bll_Dashboard.LoadBookInfo(item.avatar.Image, item.id, item.txt_bookName.Text.ToString(), item.txt_bookAuthor.Text.ToString(), item.category, item.status, item.txt_chapter.Text.ToString());
        }
    }
}
