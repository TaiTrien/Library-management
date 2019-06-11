using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QLTVDTO
    {
        public class bookDTO
        {
        [STAThread]
        static void Main()
        {
        }
            private string bookCode;
            private string titlesCode; 
            private DateTime publishYear;
            private string publisher;
            private decimal price;
            private DateTime dateIn;

            public string MaDauSach { get => titlesCode; set => titlesCode = value; }
            public string MaSach { get => bookCode; set => bookCode = value; }
            public DateTime NamXuatBan { get => publishYear; set => publishYear = value; }
            public string NhaXuatBan { get => publisher; set => publisher = value; }
            public DateTime NgayNhap { get => dateIn; set => dateIn = value; }
            public decimal TriGia { get => price; set => price = value; }

        }
    }


