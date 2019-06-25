using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTVDTO
{
    public class typeDTO
    {
        private string typeCode;
        private string typeName;

        public string maTheLoai { get => typeCode; set => typeCode = value; }
        public string tenTheLoai { get => typeName; set => typeName = value; }
    }
}
