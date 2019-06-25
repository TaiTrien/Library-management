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
    public class bookDAL
    {
        [STAThread]
        static void Main()
        {
        }
        public bookDAL()
        {

        }
        
        public bool add(bookDTO book)
        {
            return true;
        }
    }
}

