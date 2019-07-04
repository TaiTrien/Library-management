using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTVDAL;
using QLTVDTO;
namespace QLTVBUS
{
    public class authBUS
    {
        private authDAL authDAL;
        private parametersDAL paraDAL;
        public authBUS()
        {
            authDAL = new authDAL();
            paraDAL = new parametersDAL();
        }

        public bool add(authDTO authDTO)
        {
            bool isAdd = authDAL.add(authDTO);
            return isAdd;
        }
        public bool del(authDTO authDTO)
        {
            bool isDel = authDAL.del(authDTO);
            return isDel;
        }
        public bool mod(authDTO authDTO)
        {
            bool isMod = authDAL.mod(authDTO);
            return isMod;
        }
        public List<authDTO> selectedAuth()
        {
            return authDAL.selectedAuth();
        }
        public string selectedAuthReferenceToTitle(titlesDTO titlesDTO)
        {
            return authDAL.selectedAuthReferenceToTitle(titlesDTO);
        }
        public int getNumberofAuth() // to get present type  in library
        {
            return authDAL.getPresentNumberofAuth();
        }
        public int getMaxNumberofAuth() // to get max type 
        {
            int maxAuth;
            parametersDTO para = new parametersDTO();
            para = paraDAL.selectedRegulations();
            maxAuth = para.SoTacGiaToiDa;
            return maxAuth;
        }

    }
}
