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
        public int getMaxAgeofReader() // 
        {
            int res;
            paraDAL = new parametersDAL();
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

    }
}
