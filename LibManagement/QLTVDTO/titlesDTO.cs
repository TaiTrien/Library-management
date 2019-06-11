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

        public string MaDauSach { get => titlesCode; set => titlesCode = value; }
        public string TenDauSach { get => titlesName; set => titlesName = value; }
        public string TheLoai { get => type; set => type = value; }
        public string MaTacGia { get => authCode; set => authCode = value; }
      
    }
}
