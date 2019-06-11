using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTVDTO
{
    public class authDTO
    {
        private string authName;
        private string authCode;
        private DateTime DOB;

        public string TenTacGia { get => authName; set => authName = value; }
        public string MaTacGia { get => authCode; set => authCode = value; }
        public DateTime NgaySinh { get => DOB; set => DOB = value; }

    }
}
