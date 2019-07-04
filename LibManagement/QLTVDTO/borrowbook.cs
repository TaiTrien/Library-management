using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDTO
{
    public class borrowbook
    {
        private DateTime dateborrow;
        private DateTime dategiveback;
        private DateTime dategivebackreal;
        private string idborrowbook;
        public DateTime NgayMuonSach { get => dateborrow; set => dateborrow = value; }
        public DateTime NgayTraSach { get => dategiveback; set => dategiveback = value; }
        public DateTime NgayTraSachThuc { get => dategivebackreal; set => dategivebackreal = value; }
        public string Idborrowbook { get => idborrowbook; set => idborrowbook = value; }
    }
}
