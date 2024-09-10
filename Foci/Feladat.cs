using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class Feladat
    {
        public static List<Read> adatok;
        public Feladat() 
        {
            adatok = new List<Read>();
        }

        public void Beolvasas (string fajlnev)
        {
            int fordulo = 0;
            int HGol = 0;
            int VGol = 0;
            int ElsoFel = 0;
            int MasodikFel = 0;
            string hazai;
            string vendeg;
            foreach (var lines in File.ReadAllLines(fajlnev, Encoding.UTF8).Skip(1))
            {
                var x = lines.Trim().Split(' ');
               fordulo = Convert.ToInt32(x[0]);
               HGol = Convert.ToInt32(x[1]);
               VGol = Convert.ToInt32(x[2]);
               ElsoFel = Convert.ToInt32(x[3]);
               MasodikFel = Convert.ToInt32(x[4]);
                hazai = x[5];
                vendeg = x[6];
                adatok.Add(new Read(fordulo, HGol, VGol, ElsoFel, MasodikFel, hazai, vendeg));
            }
        }
    }
}
