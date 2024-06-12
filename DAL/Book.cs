using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCommicBook.DAL
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public int NumberOfChapters { get; set; }
        public string category { get; set; }
        public bool status { get; set; }

        public Book(int bookID, string title, string author, DateTime publicationDate, int numberOfChapters, string category, bool status)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            NumberOfChapters = numberOfChapters;
            this.category = category;
            this.status = status;
        }
    }
}
