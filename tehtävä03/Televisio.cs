using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Televisio // televisioluokka
    {
        public string Merkki {get; set;}
        public string Väri { get; set; }
        public string Paneelityyppi { get; set; }
        public string Paneelinkoko { get; set; }
        public string Resoluutio { get; set; }
        public string Käyttöjärjestelmä { get; set; }
        public string Paino { get; set; }

        public void Menu() // tv:n käynnistystoiminto
        {
            Console.WriteLine("Asetukset > Järjestelmä > Tietoja > ");
        }
        public void Speksit() // ominaisuuksien tulostus-systeemi
        {
            Console.WriteLine("------ Television ominaisuudet ------");
            Console.WriteLine("- Merkki: " + Merkki);
            Console.WriteLine("- Väri: " + Väri);
            Console.WriteLine("- Paino: " + Paino);
            Console.WriteLine("- Paneelin tyyppi: " + Paneelityyppi);
            Console.WriteLine("- Paneelin koko: " + Paneelinkoko);
            Console.WriteLine("- Resoluutio: " + Resoluutio);
            Console.WriteLine("- Käyttöjärjestelmä: " + Käyttöjärjestelmä);
            
        }
    }
}
