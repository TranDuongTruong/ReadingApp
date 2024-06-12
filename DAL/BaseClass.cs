using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using ReadingCommicBook.BLL;

namespace ReadingCommicBook.DAL
{
    public class BaseClass
    {
       public  int height = 823, width = 1299;
           
        SqlConnection con;
        protected  String connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Study\DotNet\ReadingCommicBook\ReadingCommicBook\SQL_DB.mdf;Integrated Security=True";
        protected string imagePath = @"E:\Study\DotNet\ReadingCommicBook\ReadingCommicBook\IMAGES\";

       

        protected string textPath = @"E:\Study\DotNet\ReadingCommicBook\ReadingCommicBook\BOOKS\";
        public BaseClass()
        {
            con = new SqlConnection(connectString);

        }
        public DataTable LoadData(String sqlDL)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlDL, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public List<Book> LoadData1(string sqlDL)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlDL, con);
            List<Book> books = new List<Book>();

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Book book = new Book(
                    Convert.ToInt32(row["BookID"]),
                    row["Title"].ToString(),
                    row["Author"].ToString(),
                    Convert.ToDateTime(row["PublicationDate"]),
                    Convert.ToInt32(row["NumberOfChapters"]),
                    row["Category"].ToString(),
                    Convert.ToBoolean(row["Status"])
                    

                );

                books.Add(book);
            }

            return books;
        }

        public Image LoadImage(string id)
        {           
            try
            {
                if (System.IO.File.Exists(imagePath + id))
                {
                    Image img = Image.FromFile(imagePath + id);
                    return img;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình ảnh!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            return null;

        }
        public void CreateTextFile(string fileName, string content)
        {
            
            try
            {               
                string filePath = Path.Combine(textPath, fileName + ".txt");           
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Tệp văn bản đã tồn tại: " + filePath);
                    return;
                }
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(content);
                }

                MessageBox.Show("Thành công" );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo tệp văn bản: " + ex.Message);
            }
        }
    public String LoadTextFile(string id)
        {
            try
            {

                if (File.Exists(textPath + id))
                {
                    
                    string content = File.ReadAllText(textPath + id);

                   
                    return content;
                }
                else
                {
                    MessageBox.Show("File not found."+id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
            return "";
        }

        public void UpdateTextFile(string id, string newFileName, string newText)
        {
            try
            {
                string oldFilePath = textPath + id;
                string newFilePath = textPath + newFileName;

                if (File.Exists(oldFilePath))
                {
                    
                    if (id != newFileName)
                    {
                        File.Move(oldFilePath, newFilePath);
                    }                   
                    File.WriteAllText(newFilePath, newText);
                    MessageBox.Show("File updated successfully.");
                }
                else
                {
                    MessageBox.Show("File not found: " + oldFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating file: " + ex.Message);
            }
        }


      

        public void Nonquery(string sqlNon)
        {
            Console.WriteLine(sqlNon);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            using (SqlCommand com = new SqlCommand(sqlNon, con))
            {
                try
                {
                    int result = com.ExecuteNonQuery();
                    if (result >= 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xoá hoặc sửa khi không có mã");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            con.Close();
        }


        public Object Scalar(String sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, con);
            con.Open();
            int ketqua = (int)comm.ExecuteScalar();
            con.Close();
            return ketqua;
        }
    }

}
