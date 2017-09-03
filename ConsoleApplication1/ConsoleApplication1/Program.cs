using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć, jak masz na imię?");
            string imie;
                imie = Console.ReadLine();
            Console.WriteLine("Ile masz lat?");
                string wiek;
            wiek = Console.ReadLine();

            Console.WriteLine("Masz na imię " + imie + " i masz" + wiek + " lat");
            Console.ReadLine();
        }
    }
}
