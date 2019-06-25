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
    public class titlesDAL
    {
        // to add titles into DauSach Table and add titles code & auth code into DauSach_TacGia table
        public bool add(titlesDTO titles)
        {
            //add into DauSach table
            string queryAddTitles = string.Empty;
            queryAddTitles += "INSERT INTO DAUSACH (MaDauSach, TenDauSach) ";
            queryAddTitles += "VALUES (@MaDauSach, @TenDauSach)";
            //add author into DauSach_TacGia table
            string queryAddAuth = string.Empty;
            queryAddAuth += "INSERT INTO DAUSACH_TACGIA (MaDauSach, MaTacGia) ";
            queryAddAuth += "VALUES (@MaDauSach, @MaTacGia)";
            // add type into DauSach_TheLoai table
            string queryAddType = string.Empty;
            queryAddType += "INSERT INTO DAUSACH_THELOAI (MaDauSach, MaTheLoai) ";
            queryAddType += "VALUES (@MaDauSach, @MaTheLoai)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {
                // to add titles and name of titles into table DAUSACH
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryAddTitles;
                    cmd.Parameters.AddWithValue("@MaDauSach", titles.MaDauSach);
                    cmd.Parameters.AddWithValue("@TenDauSach", titles.TenDauSach);
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
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = con;
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = queryAddAuth;
                    cmd2.Parameters.AddWithValue("@MaDauSach", titles.MaDauSach);
                    cmd2.Parameters.AddWithValue("@MaTacGia", titles.MaTacGia);
                    try
                    {
                        con.Open();
                        cmd2.ExecuteNonQuery();
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
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd3 = new SqlCommand())
                {
                    cmd3.Connection = con;
                    cmd3.CommandType = System.Data.CommandType.Text;
                    cmd3.CommandText = queryAddType;
                    cmd3.Parameters.AddWithValue("@MaDauSach", titles.MaDauSach);
                    cmd3.Parameters.AddWithValue("@MaTheLoai", titles.TheLoai);
                    try
                    {
                        con.Open();
                        cmd3.ExecuteNonQuery();
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
        // to delete titles from DAUSACH table and referencing table
        public bool del(titlesDTO titles)
        {
            //delete titles from DauSach table
            string queryDelTitles = string.Empty;
            queryDelTitles += "DELETE FROM DAUSACH ";
            queryDelTitles += "WHERE MaDauSach = @mds";
            //delete author from DauSach_TacGia table
            string queryDelAuth = string.Empty;
            queryDelAuth += "DELETE FROM DAUSACH_TACGIA ";
            queryDelAuth += "WHERE  MaDauSach = @mds ";
            //delte titles from DauSach_TheLoai table
            string queryDelType = string.Empty;
            queryDelType += "DELETE FROM DAUSACH_THELOAI ";
            queryDelType += "WHERE  MaDauSach = @mds ";
            // to delete titles from table DAUSACH_TACGIA
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryDelAuth;
                    cmd.Parameters.AddWithValue("@mds", titles.MaDauSach);
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
            // to delete titles from table DauSach_TheLoai table
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = con;
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = queryDelType;
                    cmd2.Parameters.AddWithValue("@mds", titles.MaDauSach);
                    try
                    {
                        con.Open();
                        cmd2.ExecuteNonQuery();
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
            // to delete titles and name of titles from table DAUSACH
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {
                
                using (SqlCommand cmd3 = new SqlCommand())
                {
                    cmd3.Connection = con;
                    cmd3.CommandType = System.Data.CommandType.Text;
                    cmd3.CommandText = queryDelTitles;
                    cmd3.Parameters.AddWithValue("@mds", titles.MaDauSach);
                    try
                    {
                        con.Open();
                        cmd3.ExecuteNonQuery();
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
        // to modify
        public bool mod(titlesDTO titles)
        {
            //modify titles from DauSach table
            string queryModTitles = string.Empty;
            queryModTitles += "UPDATE DAUSACH SET ";
            queryModTitles += "TenDauSach = @tds WHERE MaDauSach = @mds";
            //delete author from DauSach_TacGia table
            string queryModAuth = string.Empty;
            queryModAuth += "UPDATE DAUSACH_TACGIA SET ";
            queryModAuth += "MaTacGia = @mtg WHERE  MaDauSach = @mds ";
            
            //delte titles from DauSach_TheLoai table
            string queryModType = string.Empty;
            queryModType += "UPDATE DAUSACH_THELOAI SET ";
            queryModType += "MaTheLoai = @mtl WHERE  MaDauSach = @mds ";
            // to modify titles from table DAUSACH_TACGIA
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryModAuth;
                    cmd.Parameters.AddWithValue("@mds", titles.MaDauSach);
                    cmd.Parameters.AddWithValue("@mtg", titles.MaTacGia);
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
            // to modify titles from table DauSach_TheLoai table
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = con;
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = queryModType;
                    cmd2.Parameters.AddWithValue("@mds", titles.MaDauSach);
                    cmd2.Parameters.AddWithValue("@mtl", titles.TheLoai);
                    try
                    {
                        con.Open();
                        cmd2.ExecuteNonQuery();
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
            // to modify titles and name of titles from table DAUSACH
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd3 = new SqlCommand())
                {
                    cmd3.Connection = con;
                    cmd3.CommandType = System.Data.CommandType.Text;
                    cmd3.CommandText = queryModTitles;
                    cmd3.Parameters.AddWithValue("@mds", titles.MaDauSach);
                    cmd3.Parameters.AddWithValue("@tds", titles.TenDauSach);
                    try
                    {
                        con.Open();
                        cmd3.ExecuteNonQuery();
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
        public List<titlesDTO> selectedTitle()

        {
            string query = string.Empty;
            query += "SELECT MaDauSach, TenDauSach";
            query += " FROM DAUSACH";

            List<titlesDTO> lsTitles = new List<titlesDTO>();

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
                                titlesDTO titles = new titlesDTO();
                                titles.MaDauSach = reader["MaDauSach"].ToString();
                                titles.TenDauSach = reader["TenDauSach"].ToString();
                                lsTitles.Add(titles);
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
            return lsTitles;
        }
    }
}

