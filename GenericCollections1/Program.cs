using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            for (int i = 0; i < valores.Count; i++) 
            {
                r = valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("---------------");

            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));

            Console.WriteLine("---------------");

            Console.WriteLine(valores.IndexOf(4));

            Console.WriteLine("---------------");

            valores.Insert(2, 55 );

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------------");

            valores.RemoveAt(3);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------------");

            valores.Remove(8);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------------");

            valores.Reverse();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------------");

            valores.Sort();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------------");

            List<CPunto> listaPuntos = new List<CPunto>();
            listaPuntos.Add(new CPunto(5,3));
            listaPuntos.Add(new CPunto(7,8));
            listaPuntos.Add(new CPunto(12,5));
            listaPuntos.Add(new CPunto(6,2));
            
            foreach (CPunto valor in listaPuntos)
                Console.WriteLine(valor);
        }
    }
}
