using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QLTVDTO;
namespace QLTVDAL
{
    public class bookDAL
    {
        [STAThread]
        static void Main()
        {
        }
        public bookDAL()
        {

        }
        public bool add(bookDTO book)
        {
            string query = string.Empty;
            query += "INSERT INTO SACH (MaSach, MaDauSach, NgayNhap, NXB, NamXuatBan, Gia, DaMuon) ";
            query += "VALUES (@MaSach, @MaDauSach, @NgayNhap, @NXB, @NamXuatBan, @Gia, @DaMuon)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                    cmd.Parameters.AddWithValue("@MaDauSach", book.MaDauSach);
                    cmd.Parameters.AddWithValue("@NgayNhap", book.NgayNhap);
                    cmd.Parameters.AddWithValue("@NXB", book.NhaXuatBan);
                    cmd.Parameters.AddWithValue("@NamXuatBan", book.NamXuatBan);
                    cmd.Parameters.AddWithValue("@Gia", book.TriGia);
                    cmd.Parameters.AddWithValue("@DaMuon", book.TinhTrang);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool del(bookDTO book)
        {
            string query = string.Empty;
            query += "DELETE FROM SACH WHERE [MaSach] = @MaSach";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        //to select authores from db
        public List<bookDTO> selectedBook()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM SACH";

            List<bookDTO> lsBook = new List<bookDTO>();

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                bookDTO book = new bookDTO();
                                book.MaSach = reader["MaSach"].ToString();
                                book.MaDauSach = reader["MaDauSach"].ToString();
                                book.NgayNhap = reader.GetFieldValue<DateTime>(reader.GetOrdinal("NgayNhap"));
                                book.NhaXuatBan = reader["NXB"].ToString();
                                book.NamXuatBan = reader.GetFieldValue<DateTime>(reader.GetOrdinal("NamXuatBan"));
                                book.TriGia = Decimal.Parse(reader["Gia"].ToString());
                                book.TinhTrang = reader["DaMuon"].ToString();
                                lsBook.Add(book);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsBook;
        }
    }
}

