using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Read
    {
        public Read(int fordulo, int hGol, int vGol, int elsoFelIdo, int masodikFelIdo, string hazaiCsapat, string vendegCsapat)
        {
            Fordulo = fordulo;
            HGol = hGol;
            VGol = vGol;
            ElsoFelIdo = elsoFelIdo;
            MasodikFelIdo = masodikFelIdo;
            HazaiCsapat = hazaiCsapat;
            VendegCsapat = vendegCsapat;
        }

        public int Fordulo { get; set; }
        public int HGol {  get; set; }
        public int VGol { get; set; }
        public int ElsoFelIdo { get; set; }
        public int MasodikFelIdo { get; set; }
        public string HazaiCsapat {  get; set; }
        public string VendegCsapat { get; set; }
    }
}
