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
        public authBUS()
        {
            authDAL = new authDAL();
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


    }
}
