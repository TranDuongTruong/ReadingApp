using ReadingCommicBook.BLL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReadingCommicBook.DAL
{
    public class BookItem : Panel
    {
       public Label txt_chapter, txt_bookAuthor, txt_bookName, txtChuong;
        public PictureBox avatar;
        public Bll_dashboard bll_Dashboard;
        public string id;
        public String category;
        public Boolean status;
        public BookItem(Bll_dashboard bll_Dashboard)
        {
            this.bll_Dashboard = bll_Dashboard;

            this.txt_chapter = new Label();
            this.txt_chapter.AutoSize = true;

            this.txtChuong = new Label();
            this.txtChuong.AutoSize = true;

            this.txt_bookAuthor = new Label();
            this.txt_bookAuthor.AutoSize = true;
            this.txt_bookName = new Label();
            this.txt_bookName.AutoSize = true;
            this.avatar = new PictureBox();

            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.txt_chapter);
            this.Controls.Add(this.txtChuong);
            this.Controls.Add(this.txt_bookAuthor);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.avatar);
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(148, 281);
            this.TabIndex = 0;
        }

        public BookItem(String id ,String txt_chapter, String txt_bookAuthor, String txt_bookName, PictureBox pictureBox, String category, Boolean status, Bll_dashboard bll_Dashboard)
        {
            this.category= category;
            this.status= status;
            this.id = id;
            this.txt_chapter = new Label();
            this.txt_chapter.AutoSize=true;
            this.txtChuong = new Label();
            this.txtChuong.AutoSize = true;
            this.txt_bookAuthor = new Label();
            this.txt_bookAuthor.AutoSize=true;
            this.txt_bookName= new Label();
            this.txt_bookName.AutoSize=true;
            this.avatar=new PictureBox();

            this.txt_bookName.Location= new System.Drawing.Point(1, 190);
            
            this.txt_bookName.Size = new System.Drawing.Size(44, 16);
            this.txt_bookAuthor.Location = new System.Drawing.Point(20, 204);
            this.txt_bookAuthor.Size = new System.Drawing.Size(44, 16);
            this.txt_chapter.Location = new System.Drawing.Point(80, 220);
            this.txt_chapter.Size = new System.Drawing.Size(44, 16);

            this.txtChuong.Location = new System.Drawing.Point(20, 220);
            this.txtChuong.Size = new System.Drawing.Size(44, 16);


            this.avatar = pictureBox;
            this.avatar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.avatar.Location = new System.Drawing.Point(3, 3);
            this.avatar.Name = "pictureBox1";
            this.avatar.Size = new System.Drawing.Size(139, 165);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.SizeMode = PictureBoxSizeMode.Zoom;



            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.avatar);            
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.txt_bookAuthor);
            this.Controls.Add(this.txt_chapter);
            this.Controls.Add(this.txtChuong);
            
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(148, 260);
            this.TabIndex = 0;
            this.txt_bookName.Text = txt_bookName;
            this.txt_bookName.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_chapter.Text = txt_chapter;
            this.txtChuong.Text = "Số chương: ";

            this.txt_bookAuthor.Text = "Tác giả: "+txt_bookAuthor;
            this.bll_Dashboard = bll_Dashboard;
            this.avatar.Click += (sender, e) => AvatarClick(sender, e, id,category,status);
            

        }

        private void AvatarClick(object sender, EventArgs e,String id, String category, Boolean status)
        {
            /*  String text=bll_Dashboard.dal_dashboard.LoadTextFile("1.txt");
              BookDisplay bookDisplay = new BookDisplay(text);
              bookDisplay.Show();*/
            Console.WriteLine("/t/tChap:" + this.txt_chapter.Text.ToString());
            bll_Dashboard.LoadBookInfo(this.avatar.Image,id, this.txt_bookName.Text.ToString(), this.txt_bookAuthor.Text.ToString(), category, status,(this.txt_chapter.Text.ToString()));

        }
    }
}
