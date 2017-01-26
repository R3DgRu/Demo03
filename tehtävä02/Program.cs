using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.Kirjopesu = 0;
            pesukone.Valkopesu = 40;
            pesukone.Linkous = 1200;

            pesukone.AsetuksetTulostus();
            pesukone.Taytto();
            pesukone.Kaynnistys();
            pesukone.Tyhjennys();
        }
    }
}
