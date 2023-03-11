using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue miQ = new Queue();

            miQ.Enqueue("Manzana");
            miQ.Enqueue("Fresa");
            miQ.Enqueue("Pera");

            foreach (string fruta in miQ)
                Console.WriteLine($"-> {fruta}");

            Console.WriteLine("---------------");

            Console.WriteLine($"Dequeue {miQ.Dequeue()}");

            foreach (string fruta in miQ)
                Console.WriteLine($"Despues deque -> {fruta}");

            Console.WriteLine("---------------");

            miQ.Enqueue("Limon");
            miQ.Enqueue("Mango");
            miQ.Enqueue("Ciruela");

            Console.WriteLine($"Peek = {miQ.Peek()}");

            foreach (string fruta in miQ)
                Console.WriteLine($"Despues peek -> {fruta}");

            Console.WriteLine("---------------");
            Console.WriteLine(miQ.Count);
            Console.WriteLine("---------------");

            Console.WriteLine(miQ.Contains("Mango"));
            Console.WriteLine(miQ.Contains("Manzana"));

        }
    }
}
