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
    public class BorrowBookDAL
    {
        public bool Add(borrowbook SachMuon, bookDTO book, ReaderDTO reader)
        {
            string query = string.Empty;
            query += "INSERT INTO MUONSACH (MaThe, MaSach, MaMuonSach, NgayMuon,MaNguoiDung) ";
            query += "VALUES (@MaThe, @MaSach, @MaMuonSach, @NgayMuon,@MaNguoiDung)";
      
            string query2 = string.Empty;
            query2 += "IF NOT EXISTS(SELECT TOP 1 MaThe FROM THEDOCGIA WHERE MaThe= @MaThe)" + Environment.NewLine;
            query2 += "INSERT INTO MUONSACH (MaThe, MaSach, NgayMuon)" + Environment.NewLine;
            query2 += "VALUES (@MaThe, @MaSach, @NgayMuon)";
            query2 += "else" + Environment.NewLine;
            query2 += "begin" + Environment.NewLine;
            query2 += "DECLARE @dk INT " + Environment.NewLine;      
            query2 += "DECLARE cursorProduct CURSOR FOR" + Environment.NewLine;
            query2 += "select DaMuon from SACH where MaSach = @MaSach" + Environment.NewLine;
            query2 += "Open cursorProduct FETCH NEXT FROM cursorProduct INTO @dk" + Environment.NewLine;
            query2 += "if @dk = 0 " + Environment.NewLine;
            query2 += "update SACH set DaMuon = 1 where MaSach = @MaSach" + Environment.NewLine;
            query2 += "else" + Environment.NewLine;
            query2 += "INSERT INTO MUONSACH (MaThe, MaSach, NgayMuon)" + Environment.NewLine;
            query2 += "VALUES (@MaThe, @MaSach, @NgayMuon)";
            query2 += "end" + Environment.NewLine;
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThe", reader.IdReader);
                    cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                    Random rd = new Random();
                    cmd.Parameters.AddWithValue("@MaMuonSach",SachMuon.Idborrowbook);
                    cmd.Parameters.AddWithValue("@NgayMuon", SachMuon.NgayMuonSach);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", 1);
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

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query2;
                    cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                    cmd.Parameters.AddWithValue("@MaThe", reader.IdReader);
                    cmd.Parameters.AddWithValue("@NgayMuon", SachMuon.NgayMuonSach);


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

        public bool Return(borrowbook SachMuon, bookDTO book, ReaderDTO reader)
        {


            string query2 = string.Empty;
            query2 += "IF NOT EXISTS(SELECT TOP 1 MaThe FROM THEDOCGIA WHERE MaThe= @MaThe)" + Environment.NewLine;
            query2 += "INSERT INTO MUONSACH (MaThe, MaSach)" + Environment.NewLine;
            query2 += "VALUES (@MaThe, @MaSach)";
            query2 += "else" + Environment.NewLine;
            query2 += "begin" + Environment.NewLine;
            query2 += "DECLARE @dk INT " + Environment.NewLine;
            query2 += "DECLARE cursorProduct CURSOR FOR" + Environment.NewLine;
            query2 += "select DaMuon from SACH where MaSach = @MaSach " + Environment.NewLine;
            query2 += "Open cursorProduct FETCH NEXT FROM cursorProduct INTO @dk" + Environment.NewLine;
            query2 += "if @dk = 1 " + Environment.NewLine;
            query2 += "begin" + Environment.NewLine;
            query2 += "update SACH set DaMuon = 0 where MaSach = @MaSach" + Environment.NewLine;
     
            query2 += "UPDATE MUONSACH SET ";
            query2 += "NgayTra = @NgayTra ";
            query2 += "WHERE MaThe=@MaThe and MaSach = @MaSach" + Environment.NewLine;
            query2 += "end" + Environment.NewLine;
            query2 += "else" + Environment.NewLine;
            query2 += "INSERT INTO MUONSACH (MaThe, MaSach, NgayTra,MaMuonSach)" + Environment.NewLine;
            query2 += "VALUES (@MaThe, @MaSach, @NgayTra,@MaMuonSach)";
            query2 += "end" + Environment.NewLine;
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query2;
                    cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                    cmd.Parameters.AddWithValue("@MaThe", reader.IdReader);
                    cmd.Parameters.AddWithValue("@MaMuonSach", SachMuon.Idborrowbook);
                    cmd.Parameters.AddWithValue("@NgayTra", SachMuon.NgayTraSach);


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
    
