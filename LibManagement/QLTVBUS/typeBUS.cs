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
        public typeBUS()
        {
            typeDAL = new typeDAL();
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
        public bool mod (typeDTO typeDTO)
        {
            bool isMod = typeDAL.mod(typeDTO);
            return isMod;
        }
        public List<typeDTO> selectedTypes()
        {
            return typeDAL.selectedTypes();
        } 
    }
    
}
