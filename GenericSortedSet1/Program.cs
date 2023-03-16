using GenericCollections1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortedSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(3, 7));
            puntos.Add(new CPunto(8, 11));
            puntos.Add(new CPunto(2, 6));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine($"-> {p}");
            }

            Console.WriteLine("--------------------");

            puntos.Add(new CPunto(1, 15));
            puntos.Add(new CPunto(1, 12));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine($"-> {p}");
            }

            Console.WriteLine("--------------------");
        }
    }
}
