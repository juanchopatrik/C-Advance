using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGeneric1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<CPunto> puntos = new Queue<CPunto>();

            puntos.Enqueue(new CPunto(3,7));
            puntos.Enqueue(new CPunto(7,9));
            puntos.Enqueue(new CPunto(11,2));

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine("----------------------");

            Console.WriteLine($"-> {puntos.Peek()}");

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine("----------------------");

            Console.WriteLine($"Dequeue {puntos.Dequeue()}");
            Console.WriteLine($"Dequeue {puntos.Dequeue()}");

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine("----------------------");

        }
    }
}
