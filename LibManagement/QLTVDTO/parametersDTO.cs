using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QLTVDTO
{
    public class parametersDTO
    {
        private int maxAgeReader;
        private int minAgeReader;
        private int cardTerm;
        private int maxType;
        private int maxAuth;
        private int maxPublishYear;
        private int maxBorrowedBook;
        private int maxBorrowDay;

        public int TuoiToiDaDocGia { get => maxAgeReader; set => maxAgeReader = value; }
        public int TuoiToiThieuDocGia { get => minAgeReader; set => minAgeReader = value; }
        public int ThoiHanThe { get => cardTerm; set => cardTerm = value; }
        public int SoTheLoaiToiDa { get => maxType; set => maxType = value; }
        public int SoTacGiaToiDa { get => maxAuth; set => maxAuth = value; }
        public int NamXuatBanToiDa { get => maxPublishYear; set => maxPublishYear = value; } /*Give data about maxium year of book can be received */
        public int SoSachMuonToiDa { get => maxBorrowedBook; set => maxBorrowedBook = value; }
        public int SoNgayMuonToiDa { get => maxBorrowDay; set => maxBorrowDay = value; }
    }
}
