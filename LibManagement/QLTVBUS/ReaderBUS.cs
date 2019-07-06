using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVDAL;
using QLTVDTO;

namespace QLTVBUS
{
    public class ReaderBUS
    {
        private parametersDAL paraDAL;
        private  ReaderDAL dgDal;

        public ReaderBUS()
        {
            paraDAL = new parametersDAL();
            dgDal = new ReaderDAL();
        }
        public bool add(ReaderDTO dg)
        {
            bool re = dgDal.add(dg);
            return re;
        }
        public bool delete(ReaderDTO dg)
        {
            bool re = dgDal.delete(dg);
            return re;
        }
        public bool edit(ReaderDTO dg)
        {
            bool re = dgDal.edit(dg);
            return re;
        }
        public List<ReaderDTO> select()
        {
            return dgDal.select();
        }
        public int SoSachMuon(ReaderDTO dg)
        {
            int re = dgDal.SoluongSachDangMuon(dg);
            return re;
        }
        public int getMaxAgeofReader() // 
        {
            int res;
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            res = para.TuoiToiDaDocGia;
            return res;
        }
        public int getMinAgeofReader() // 
        {
            int res;
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            res = para.TuoiToiThieuDocGia;
            return res;
        }
        public int getMaxofBorrowBook() // 
        {
            int res;
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            res = para.SoSachMuonToiDa;
            return res;
        }
        public int getTimeofReader() // 
        {
            int res;
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            res = para.ThoiHanThe;
            return res;
        }

    }
}
