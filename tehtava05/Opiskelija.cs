using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava05
{
    class Opiskelija
    {
        public int Pituus { get; set; } 
        public int Paino { get; set; }
        public string Silmienvari { get; set; }

        public void Ohjelmointi()
        {
            Console.WriteLine("koodaillaan: public void Ohjelmointi() { Console.WriteLine(trolololol) } jne...");
        }

        public void Nukkua()
        {
            Console.WriteLine("nukkumaan: zzz hgrhhh zzz phyyh zzz...");
        }

        public void Syoda()
        {
            Console.WriteLine("syodaan: mums mums...  ...röyh");
        }
    }
}
