using GenericCollections1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(3,4));
            puntos.Push(new CPunto(5,7));
            puntos.Push(new CPunto(9,11));
            puntos.Push(new CPunto(1,4));

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($" -> {item}");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine($"-> {puntos.Peek()}");

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($" -> {item}");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine($"-> {puntos.Pop()}");
            Console.WriteLine($"-> {puntos.Pop()}");

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($" -> {item}");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine($"-> {puntos.Peek()}");

            foreach (CPunto item in puntos)
            {
                Console.WriteLine($" -> {item}");
            }

            Console.WriteLine("-------------------");
        }
    }
}
