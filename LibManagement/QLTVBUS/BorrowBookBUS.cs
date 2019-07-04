using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVDAL;
using QLTVDTO;
namespace QLTVBUS
{
    public class BorrowBookBUS
    {
        BorrowBookDAL br  = new BorrowBookDAL();
        public bool add(borrowbook SachMuon, bookDTO book, ReaderDTO reader)
        {
            
            bool re = br.Add(SachMuon,book,reader);
            return re;
        }
        public bool Tra(borrowbook SachMuon, bookDTO book, ReaderDTO reader)
        {
           
            bool re = br.Return(SachMuon, book, reader);
            return re;
        }
    }
}
