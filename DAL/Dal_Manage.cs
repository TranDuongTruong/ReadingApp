using ReadingCommicBook.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCommicBook.DAL
{
    internal class Dal_Manage
    {
        public BaseClass baseClass =new BaseClass();
        public DataTable dal_Grid()
        {
            String sqlLoadData = "select * from Books";
            return baseClass.LoadData(sqlLoadData);
        }


        internal void Add(string newTitle, string newAuthor, string newNumberOfChapters, string newCategory, bool newStatus, string bookIDToUpdate)
        {
            int statusValue = newStatus ? 1 : 0;
            string query = "INSERT INTO Books (Title, Author, PublicationDate, NumberOfChapters, Category, Status) VALUES ('" + newTitle + "', '" + newAuthor + "', CONVERT(DATETIME, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 103), '" + newNumberOfChapters + "', '" + newCategory + "', '" + statusValue + "')";
            baseClass.Nonquery(query);
        }

        internal void Edit(string newTitle, string newAuthor, string newNumberOfChapters, string newCategory, bool newStatus, string bookIDToUpdate)
        {
            int statusValue = newStatus ? 1 : 0;
            //string query = "UPDATE Books set Title = '"+newTitle+ "', Author ='" + newAuthor + "', NumberOfChapters = '" + int.Parse(newNumberOfChapters) + "', Category = '" + newCategory + "', Status ='" + newStatus + "' WHERE BookID = '" +int.Parse( bookIDToUpdate) + "' ";
            string query = "update Books set Title = '" + newTitle + "', Author = '" + newAuthor + "', NumberOfChapters = " + newNumberOfChapters + ", Category = '" + newCategory + "', Status = " + statusValue + " WHERE BookID = " + bookIDToUpdate;

            baseClass.Nonquery(query);

        }

        internal void Delete(string ID)
        {
            String sqlXoa = "delete from Books where BookID = '" + ID + "'";
            baseClass.Nonquery(sqlXoa);

        }
    }
}
