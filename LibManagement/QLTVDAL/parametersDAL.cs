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
        public parametersDTO selectedRegulations() // to select whole of regulations
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM THAMSO";

            parametersDTO para = new parametersDTO();

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
    }
}
