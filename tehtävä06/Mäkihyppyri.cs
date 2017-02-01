using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä06
{
    class Mäkihyppyri // mäkihyppyriluokka
    {
        // mäen tiedot 
        public string Sijainti { get; set; }
        public string Nimi { get; set; }
        public string Tyyppi { get; set; }
        public int Kpiste { get; set; }
        public int HSpiste { get; set; }
        public string Hyppyrinkork { get; set; }
        public string Keulanopeus { get; set; }
        public string Makiennatys { get; set; }

        public void Tiedot() // metodi joka tulostaa aikanaan mäen tiedot
        {
            Console.WriteLine("--- Maen tiedot --- \n");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Sijainti: " + Sijainti);
            Console.WriteLine("Tyyppi: " + Tyyppi);
            Console.WriteLine("K-piste: " + Kpiste);
            Console.WriteLine("HS-piste: " + HSpiste);
            Console.WriteLine("Hyppyrinkorkeus: " + Hyppyrinkork);
            Console.WriteLine("Nopeus keulalla (tyypillinen): " + Keulanopeus);
            Console.WriteLine("Makiennatys ja sen tekija: " + Makiennatys);
        }
    }
}
