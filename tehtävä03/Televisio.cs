using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Televisio
    {
        public string Merkki {get; set;}
        public string Väri { get; set; }
        public string Paneelityyppi { get; set; }
        public string Paneelinkoko { get; set; }
        public string Resoluutio { get; set; }
        public string Käyttöjärjestelmä { get; set; }
        public double Paino { get; set; }

        public void VirtaOn() // tv:n käynnistys toiminto
        {
            Console.WriteLine("Käynnistys...");
        }

    }
}
