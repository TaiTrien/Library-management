using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVDTO;
using QLTVDAL;

namespace QLTVBUS
{
    public class ParameterBUS
    {
        public parametersDTO  Selected ()
        {
            parametersDAL parametersDAL = new parametersDAL();
            parametersDTO res = new parametersDTO();
            res = parametersDAL.selectedRegulations();
            return res;
           
        }
        public bool edit(parametersDTO pr)
        {
            parametersDAL parametersDAL = new parametersDAL();
            bool res = parametersDAL.CapNhat(pr);
            return res;

        }
    }
}
