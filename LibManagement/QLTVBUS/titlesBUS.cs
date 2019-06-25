using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTVDTO;
using QLTVDAL;
namespace QLTVBUS
{
    public class titlesBUS
    {
        private titlesDAL titlesDAL;
        public titlesBUS()
        {
            titlesDAL = new titlesDAL();
        }
        // to call add function titles
        public bool add(titlesDTO titles)
        {
            bool isAdd = titlesDAL.add(titles);
            return isAdd;
        }
        // to call delete function titles
        public bool del(titlesDTO titles)
        {
            bool isDel = titlesDAL.del(titles);
            return isDel;
        }
        public bool mod(titlesDTO titles)
        {
            bool isMod = titlesDAL.mod(titles);
            return isMod;
        }
        public List<titlesDTO> selectedTitle()
        {
            return titlesDAL.selectedTitle();
        }
        
    }
}
