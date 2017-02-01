using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä06
{
    class Program
    {
        static void Main(string[] args)
        {
            Mäkihyppyri makihyppyri = new Mäkihyppyri(); // uusi mäki

            // ensimmäisen mäen tietojen täyttö
            makihyppyri.Nimi = "Letalnica";
            makihyppyri.Sijainti = "Slovenia, Planica";
            makihyppyri.Tyyppi = "Lentomaki";
            makihyppyri.Kpiste = 200;
            makihyppyri.HSpiste = 225;
            makihyppyri.Hyppyrinkork = "2,9 m";
            makihyppyri.Keulanopeus = "105 km/h";
            makihyppyri.Makiennatys = "248,5 m, Peter Prevc \n\n";

            makihyppyri.Tiedot(); // koodinpätkä joka hoitaa konsoliin tulostamisen

          
            Mäkihyppyri kakkosmaki = new Mäkihyppyri(); // uusi mäki

            // toisen mäen tietojen täyttö
            kakkosmaki.Nimi = "Vikersundbakken";
            kakkosmaki.Sijainti = "Norja, Vikersund";
            kakkosmaki.Tyyppi = "Lentomaki";
            kakkosmaki.Kpiste = 200;
            kakkosmaki.HSpiste = 225;
            kakkosmaki.Hyppyrinkork = "2,42 m";
            kakkosmaki.Keulanopeus = "102 km/h";
            kakkosmaki.Makiennatys = "251,5 m, Anders Fannemel \n\n";

            kakkosmaki.Tiedot(); // koodinpätkä joka hoitaa konsoliin tulostamisen

            Mäkihyppyri kolmasmaki = new Mäkihyppyri(); // uusi mäki

            // kolmannen mäen tietojen täyttö
            kolmasmaki.Nimi = "Rukatunturi";
            kolmasmaki.Sijainti = "Suomi, Kuusamo";
            kolmasmaki.Tyyppi = "Suurmaki";
            kolmasmaki.Kpiste = 120;
            kolmasmaki.HSpiste = 142;
            kolmasmaki.Hyppyrinkork = "3,5 m";
            kolmasmaki.Keulanopeus = "94 km/h";
            kolmasmaki.Makiennatys = "150,5 m, Ville Larinto \n\n";

            kolmasmaki.Tiedot(); // koodinpätkä joka hoitaa konsoliin tulostamisen
        }
    }
}
