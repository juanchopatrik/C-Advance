using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            palabras.AddRange(new string[] { "hola", "como", "estan?" });

            Console.WriteLine($"cantidad de elementos en palabras {palabras.Count}");

            for (int i = 0; i < palabras.Count; i++)
                Console.WriteLine($"{palabras[i]}");

            Console.WriteLine("--------------");

            palabras.Add("Bien y tu?");

            foreach (string item in palabras)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("--------------");

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("--------------");

            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));

            Console.WriteLine("--------------");

            valores.Insert(2, 55);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("--------------");

            valores.Remove(55);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("--------------");

            valores.RemoveAt(0);

            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);
            }

            Console.WriteLine("--------------");
        }
    }
}
