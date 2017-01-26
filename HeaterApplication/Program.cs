using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater kiuas = new Heater();
            kiuas.IsOn = true;
            kiuas.Temperature = 78;
            kiuas.Humidity = 90;
            kiuas.ThrowWater();
            Console.WriteLine("Temperature is " + kiuas.Temperature);
            Console.WriteLine("Humidity is " + kiuas.Humidity);
        }
    }
}
