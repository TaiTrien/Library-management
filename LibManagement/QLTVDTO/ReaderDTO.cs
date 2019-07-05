using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDTO
{
    public class ReaderDTO
    {
        private int idreader;

        public int IdReader
        {
            get { return idreader; }
            set { idreader = value; }
        }
        private string namereader;

        

        public string NameReader
        {
            get { return namereader; }
            set { namereader = value; }
        }
        private DateTime dateofbirth;

        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        private string addressreader;

        public string AddressReader
        {
            get { return addressreader; }
            set { addressreader = value; }
        }

        private string email;
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime datecreatereader;

        public DateTime DateCreateReader
        {
            get { return datecreatereader; }
            set { datecreatereader = value; }
        }
        private string typeofreader;

        public string TypeOfReader
        {
            get { return typeofreader; }
            set { typeofreader = value; }
        }
        
    }
}
