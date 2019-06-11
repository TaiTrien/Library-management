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
            query += "INSERT INTO SACH (MaSach, MaDauSach, NgayNhap, NXB, NamXuatBan, Gia) ";
            query += "VALUES (@MaSach, @MaDauSach, @NgayNhap, @NXB, @NamXuatBan, @Gia)";
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
    }
}

