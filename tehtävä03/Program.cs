using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä03
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio televisio = new Televisio();

            televisio.Merkki = "LG";
            televisio.Väri = "Hopea";
            televisio.Paino = "65 Kg";
            televisio.Paneelityyppi = "OLED";
            televisio.Paneelinkoko = "78 tuumaa";
            televisio.Resoluutio = "4096 x 2160 pikselia";
            televisio.Käyttöjärjestelmä = "Android TV";

            televisio.Menu();
            televisio.Speksit();
        }
    }
}
