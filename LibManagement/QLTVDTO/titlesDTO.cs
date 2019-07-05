using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QLTVDTO
{
    public class titlesDTO
    {
        private string titlesCode;
        private string titlesName;
        private string type;
        private string authCode;
        private int sumTitles; // to give data about the number of titles in library 
        private int borrowedTitles; // to give data about the number of books which is depend on titles are borrowed
        private int maintainTitles; // to give data about the number of books which is depend on titles maintains

        public string MaDauSach { get => titlesCode; set => titlesCode = value; }
        public string TenDauSach { get => titlesName; set => titlesName = value; }
        public string TheLoai { get => type; set => type = value; }
        public string MaTacGia { get => authCode; set => authCode = value; }
        public int SoLuotMuon { get => borrowedTitles; set => borrowedTitles = value; }
        public int SoLuongConLai { get => maintainTitles; set => maintainTitles = value; }
        public int TongSoLuongTrongKho { get => sumTitles; set => sumTitles = value; }
    }
}
