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
            Console.WriteLine("Cześć, ile masz lat?");
            string wiek;
                wiek = Console.ReadLine();
            Console.WriteLine("Masz " + wiek + " lat. Super?");
            Console.ReadLine();
        }
    }
}
