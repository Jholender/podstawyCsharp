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
            
            int l1;
            do {
                Console.WriteLine("Podaj minimum zakresu losowanych liczb:");
            } while (!((int.TryParse(Console.ReadLine(), out l1))));
             
            
            int l2;
            do
            {
                Console.WriteLine("Podaj maximum zakresu losowanych liczb:");
            } while (!((int.TryParse(Console.ReadLine(), out l2))));
            
            Random rnd = new Random();
            int liczba1 = rnd.Next(l1, l2);
            int liczba2 = rnd.Next(l1, l2);
            Console.WriteLine("Wylosowałem: " + liczba1);
            Console.WriteLine("Wylosowałem: " + liczba2);
            Console.WriteLine("Suma tych liczb "+ (liczba1 + liczba2));
            Console.ReadLine();

            
        }
    }
}
