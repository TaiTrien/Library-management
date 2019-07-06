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
    public class typeDAL
    {
        //to add type into DB
        public bool add(typeDTO type)
        {
            string query = string.Empty;
            query += "INSERT INTO THELOAISACH (MaTheLoai, TenTheLoai) ";
            query += "VALUES (@MaTheLoai, @TenTheLoai)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTheLoai", type.maTheLoai);
                    cmd.Parameters.AddWithValue("@TenTheLoai", type.tenTheLoai);
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
        //to delete type from THELOAISACH table
        public bool del(typeDTO type)
        {
            string query = string.Empty;
            query += "DELETE FROM THELOAISACH ";
            query += "WHERE MaTheLoai = @mtl";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mtl", type.maTheLoai);
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
        // to modify type from THELOAISACH table
        public bool mod(typeDTO type)
        {
            string query = string.Empty;
            query += "UPDATE THELOAISACH SET ";
            query += "TenTheLoai=@ttl WHERE MaTheLoai = @mtl";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mtl", type.maTheLoai);
                    cmd.Parameters.AddWithValue("@ttl", type.tenTheLoai);
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
        //to select list of type from DB
        public List<typeDTO> selectedTypes()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += " FROM THELOAISACH";

            List<typeDTO> lsTypes = new List<typeDTO>();

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
                                typeDTO types = new typeDTO();
                                types.maTheLoai = reader["MaTheLoai"].ToString();
                                types.tenTheLoai = reader["TenTheLoai"].ToString();
                                lsTypes.Add(types);
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
            return lsTypes;
        }
        public int getPresentNumberofType()
        {
            int temp = 0;
            string query = string.Empty;
            query += "SELECT COUNT(MaTheLoai) as NumberType";
            query += " FROM THELOAISACH";

            List<typeDTO> lsTypes = new List<typeDTO>();

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
                                temp = int.Parse(reader["NumberType"].ToString());
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return temp;
        }
    }
}
