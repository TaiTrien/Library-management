using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTVDAL;
using QLTVDTO;
namespace QLTVBUS
{
    public class bookBUS
    {
        [STAThread]
        static void Main()
        {
        }
        private parametersDAL paraDAL;
        private bookDAL bookDAL;
        public bookBUS()
        {
            bookDAL = new bookDAL();
        }

        public bool add(bookDTO bookDTO)
        {
            bool isAdd = bookDAL.add(bookDTO);
            return isAdd;
        }

        public bool del(bookDTO bookDTO)
        {
            bool re = bookDAL.del(bookDTO);
            return re;
        }
        public bool mod(bookDTO bookDTO)
        {
            bool re = bookDAL.mod(bookDTO);
            return re;
        }
        public List<bookDTO> selectedBook()
        {
            return bookDAL.selectedBook();
        }
        public int getMaxOfYearExp() // 
        {
            int res;
            paraDAL = new parametersDAL();
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            res = para.NamXuatBanToiDa;
            return res;
        }
   
    }
}
