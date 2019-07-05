using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTVDAL;
using QLTVDTO;
namespace QLTVBUS
{
    public class typeBUS
    {
        private typeDAL typeDAL;
        private parametersDAL parametersDAL;
        public typeBUS()
        {
            typeDAL = new typeDAL();
            parametersDAL = new parametersDAL();
        }

        public bool add(typeDTO typeDTO)
        {
            bool isAdd = typeDAL.add(typeDTO);
            return isAdd;
        }
        public bool del(typeDTO typeDTO)
        {
            bool isDel = typeDAL.del(typeDTO);
            return isDel;
        }
        public bool mod(typeDTO typeDTO)
        {
            bool isMod = typeDAL.mod(typeDTO);
            return isMod;
        }
        public List<typeDTO> selectedTypes()
        {
            return typeDAL.selectedTypes();
        }
        public int getNumberofType() // to get present type  in library
        {
            return typeDAL.getPresentNumberofType();
        }
        public int getMaxNumberofType() // to get max type 
        {
            int maxType;
            parametersDTO para = new parametersDTO();
            para = parametersDAL.selectedRegulations();
            maxType = para.SoTheLoaiToiDa;
            return maxType;
        }
        

    }
    
}
