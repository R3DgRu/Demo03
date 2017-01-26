using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from a Car class
            Car kottero = new Car();
            kottero.PrintData();
            kottero.Model = "Fiat Multipla";
            kottero.Color = "Grey";
            kottero.Engine = 1.6;
            kottero.Speed = 10;
            kottero.FuzzyDices = true;
            kottero.DoorCount = 5;
            kottero.Accelerate();
            kottero.PrintData();
            kottero.Brake(7);
            Car.SomeProperty = 56;
            kottero.PrintData();

            // create another car object
            string model = "Speedster";
            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Color = "Black";
            Console.WriteLine("Color is " + nascar.Color);
        }
    }
}
