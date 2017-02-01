using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä02
{
    class Pesukone
    {
        public bool On { get; set; }
        public int Kirjopesu { get; set; }
        public int Valkopesu { get; set; }
        public int Linkous { get; set; }

        public void Taytto() // pesukoneen täyttötoiminto
        {
            Console.WriteLine("Tayta pesukone");
        }

        public void Kaynnistys() // pesukoneen käynnistystoiminto
        {
            Console.WriteLine("Kaynnistys: lori lori, whhrrrrr");
        }

        public void Tyhjennys() // pesukoneen tyhjennystoiminto
        {
            Console.WriteLine("Tyhjenna pesukone");
        }

        public void AsetuksetTulostus() // toiminto pesuohjelmien tulostukseen
        {
            Console.WriteLine("Pesukoneen asetukset");
            Console.WriteLine("Kirjopesu: {0} C", Kirjopesu );
            Console.WriteLine("Valkopesu: {0} C", Valkopesu);
            Console.WriteLine("Linkous: {0} rpm", Linkous);
        }
    }
}
