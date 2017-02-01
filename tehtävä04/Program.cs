using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(); // uusi ajoneuvo

            // ajoneuvon tiedot kirjataan tässä
            vehicle.Name = "Nissan GT-R";
            vehicle.Tyres = "Pirelli P Zero, Front: 255/40ZR20 | Rear: 285/35ZR20";
            vehicle.Speed = "315 km/h";

            vehicle.PrintData();
           // vehicle.tostring();
        }
    }
}
