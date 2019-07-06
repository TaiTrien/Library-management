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
   
    public class parametersDAL
    {
        private parametersDTO para;
        public parametersDTO selectedRegulations() // to select whole of regulations
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM THAMSO";

            para = new parametersDTO();

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
                                para.TuoiToiDaDocGia = int.Parse(reader["TuoiToiDaDocGia"].ToString());
                                para.TuoiToiThieuDocGia = int.Parse(reader["TuoiToiThieuDocGia"].ToString());
                                para.ThoiHanThe = int.Parse(reader["ThoiHanThe"].ToString());
                                para.SoTheLoaiToiDa = int.Parse(reader["SoTheLoaiToiDa"].ToString());
                                para.SoTacGiaToiDa = int.Parse(reader["SoTacGiaToiDa"].ToString());
                                para.NamXuatBanToiDa = int.Parse(reader["NamXuatBanToiDa"].ToString());
                                para.SoSachMuonToiDa = int.Parse(reader["SoSachMuonToiDa"].ToString());
                                para.SoNgayMuonToiDa = int.Parse(reader["SoNgayMuonToiDa"].ToString());
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
            return para;
        }
        public bool CapNhat(parametersDTO pr)
        {

            string query = string.Empty;
            query += "UPDATE THAMSO ";
            query += "SET TuoiToiDaDocGia = @TuoiToiDaDocGia,TuoiToiThieuDocGia = @TuoiToiThieuDocGia,ThoiHanThe = @ThoiHanThe,SoTheLoaiToiDa = @SoTheLoaiToiDa,SoTacGiaToiDa = @SoTacGiaToiDa,NamXuatBanToiDa = @NamXuatBanToiDa,SoSachMuonToiDa = @SoSachMuonToiDa, SoNgayMuonToiDa = @SoNgayMuonToiDa ";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TuoiToiDaDocGia", pr.TuoiToiDaDocGia);
                    cmd.Parameters.AddWithValue("@TuoiToiThieuDocGia", pr.TuoiToiThieuDocGia);
                    cmd.Parameters.AddWithValue("@ThoiHanThe", pr.ThoiHanThe);
                    cmd.Parameters.AddWithValue("@SoTheLoaiToiDa", pr.SoTheLoaiToiDa);
                    cmd.Parameters.AddWithValue("@SoTacGiaToiDa", pr.SoTacGiaToiDa);
                    cmd.Parameters.AddWithValue("@NamXuatBanToiDa", pr.NamXuatBanToiDa);
                    cmd.Parameters.AddWithValue("@SoSachMuonToiDa", pr.SoSachMuonToiDa);
                    cmd.Parameters.AddWithValue("@SoNgayMuonToiDa", pr.SoNgayMuonToiDa);

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
