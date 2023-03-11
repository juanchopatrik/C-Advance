using GenericCollections1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CPunto> puntos = new List<CPunto>
            {
                new CPunto(2,3),
                new CPunto(5,23),
                new CPunto(7,9),
            };

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("------------------");

            puntos.Add(new CPunto(45,90));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("------------------");

            puntos.Insert(2, new CPunto(100,150));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("------------------");

            CPunto[] arregloPuntos = puntos.ToArray();

            for (int i = 0;i < arregloPuntos.Length;i++) 
            {
                Console.WriteLine(arregloPuntos[i]);
            }

            Console.WriteLine("------------------");
        }
    }
}
