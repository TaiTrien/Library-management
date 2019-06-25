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
    public class authDAL
    {
        public authDAL()
        {
           
        }
        public bool add(authDTO auth)
        {
            string query = string.Empty;
            query += "INSERT INTO TACGIA (MaTacGia, HoTen, NgaySinh) ";
            query += "VALUES (@MaTacGia, @HoTen, @NgaySinh)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTacGia", auth.MaTacGia);
                    cmd.Parameters.AddWithValue("@HoTen", auth.TenTacGia);
                    cmd.Parameters.AddWithValue("@NgaySinh", auth.NgaySinh);
                  
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
        //to delete selected author
        public bool del(authDTO auth)
        {
            //to delete auth from TACGIA table
            string queryDelAuth = string.Empty;
            queryDelAuth += "DELETE FROM TACGIA ";
            queryDelAuth += "WHERE MaTacGia = @mtg";
            // to delte auth from DAUSACH_TACGIA table
            string queryDelTitles = string.Empty;
            queryDelTitles += "DELETE FROM DAUSACH_TACGIA ";
            queryDelTitles += "WHERE MaTacGia = @mtg";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryDelTitles;
                    cmd.Parameters.AddWithValue("@mtg", auth.MaTacGia);

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
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd1 = new SqlCommand())
                {
                    cmd1.Connection = con;
                    cmd1.CommandType = System.Data.CommandType.Text;
                    cmd1.CommandText = queryDelAuth;
                    cmd1.Parameters.AddWithValue("@mtg", auth.MaTacGia);

                    try
                    {
                        con.Open();
                        cmd1.ExecuteNonQuery();
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
        //to modify selected author
        public bool mod(authDTO auth)
        {
            string queryModAuth = string.Empty;
            queryModAuth += "UPDATE TACGIA SET ";
            queryModAuth += "HoTen = @ht, NgaySinh = @ngs ";
            queryModAuth += "WHERE MaTacGia=@mtg";
        
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryModAuth;
                    cmd.Parameters.AddWithValue("@mtg", auth.MaTacGia);
                    cmd.Parameters.AddWithValue("@ht", auth.TenTacGia);
                    cmd.Parameters.AddWithValue("@ngs", auth.NgaySinh);
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
        public List<authDTO> selectedAuth()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM TACGIA";

            List<authDTO> lsAuth = new List<authDTO>();

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
                                authDTO auth = new authDTO();
                                auth.MaTacGia=reader["MaTacGia"].ToString();
                                auth.TenTacGia = reader["HoTen"].ToString();
                                auth.NgaySinh= Convert.ToDateTime(reader["NgaySinh"]);
                                lsAuth.Add(auth);
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
            return lsAuth;
        }
        // to select Auth code from DAUSACH_TACGIA TABLE
        public string selectedAuthReferenceToTitle(titlesDTO titles)
        {
            string query = string.Empty;
            query += "SELECT MaTacGia ";
            query += "FROM DAUSACH_TACGIA WHERE MaDauSach = @mds";

            authDTO auth = new authDTO();

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
                                cmd.Parameters.AddWithValue("@mds", titles.MaDauSach);
                                auth.MaTacGia = reader["MaTacGia"].ToString();
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
            return auth.MaTacGia;
        }
    }
}
