using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVDTO;


namespace QLTVDAL
{
    public class ReaderDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public ReaderDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool add(ReaderDTO rd)
        {
            string query = string.Empty;
            query += "INSERT INTO [THEDOCGIA] ([MaThe], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [LoaiDocGia])";
            query += "VALUES (@MaThe,@HoTen,@NgaySinh,@DiaChi,@Email,@NgayLapThe,@LoaiDocGia)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThe", rd.IdReader);
                    cmd.Parameters.AddWithValue("@HoTen", rd.NameReader);
                    cmd.Parameters.AddWithValue("@NgaySinh", rd.DateOfBirth);
                    cmd.Parameters.AddWithValue("@DiaChi", rd.AddressReader);
                    cmd.Parameters.AddWithValue("@Email", rd.Email);
                    cmd.Parameters.AddWithValue("@NgayLapThe", rd.DateCreateReader);
                    cmd.Parameters.AddWithValue("@LoaiDocGia", rd.TypeOfReader);

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
        public bool delete(ReaderDTO dg)
        {
            string query = string.Empty;
            query += "DELETE FROM THEDOCGIA WHERE [MaThe] = @MaThe";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThe", dg.IdReader);
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
        public bool edit (ReaderDTO rd)
        {
            string query = string.Empty;
            query += "UPDATE THEDOCGIA ";
            query += "SET HoTen = @HoTen,NgaySinh = @NgaySinh,DiaChi = @DiaChi,Email = @Email,NgayLapThe = @NgayLapThe,LoaiDocGia = @LoaiDocGia ";
            query += "WHERE MaThe = @MaThe";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThe", rd.IdReader);
                    cmd.Parameters.AddWithValue("@HoTen", rd.NameReader);
                    cmd.Parameters.AddWithValue("@NgaySinh", rd.DateOfBirth);
                    cmd.Parameters.AddWithValue("@DiaChi", rd.AddressReader);
                    cmd.Parameters.AddWithValue("@Email", rd.Email);
                    cmd.Parameters.AddWithValue("@NgayLapThe", rd.DateCreateReader);
                    cmd.Parameters.AddWithValue("@LoaiDocGia", rd.TypeOfReader);

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
        public List<ReaderDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaThe], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [LoaiDocGia]";
            query += "FROM [THEDOCGIA]";

            List<ReaderDTO> lsKieuNau = new List<ReaderDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
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
                                ReaderDTO rd = new ReaderDTO();
                                rd.IdReader = int.Parse(reader["MaThe"].ToString());
                                rd.NameReader = reader["HoTen"].ToString();
                                rd.DateOfBirth = reader.GetFieldValue<DateTime>(reader.GetOrdinal("NgaySinh"));
                                rd.AddressReader = reader["DiaChi"].ToString();
                                rd.Email = reader["Email"].ToString();
                                rd.DateCreateReader = reader.GetFieldValue<DateTime>(reader.GetOrdinal("NgayLapThe"));
                                rd.TypeOfReader = reader["LoaiDocGia"].ToString();
                                lsKieuNau.Add(rd);
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
            return lsKieuNau;
        }
    }
}
