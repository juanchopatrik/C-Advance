using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 5;
            Console.WriteLine($"Tipo {a.GetType()}, valor : {a}");

            a = "Hola  a todos ";
            Console.WriteLine($"Tipo {a.GetType()}, valor : {a}");

        }
    }
}
