using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä04
{
    class Vehicle // ajoneuvoluokan määritykset
    {
        public string Name { get; set; }
        public string Speed { get; set; }
        public string Tyres { get; set; }

        public void PrintData() // tietojen tulostusosa
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        // systeemi jota en ymmärtänyt/osannut

        /*public void tostring()
        {
            Console.WriteLine("\nKaikki yhdessa jonossa: \n");
            Console.WriteLine(Name + Speed + Tyres);
        }*/
    }
}
