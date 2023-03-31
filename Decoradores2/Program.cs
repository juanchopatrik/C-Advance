using AritmeticaAtributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoradores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MisMates);

            object[] atributos = t.GetCustomAttributes(false);

            foreach (DatosAttribute atributo in atributos)
            {
                Console.WriteLine($"{atributo.Dato}");
            }
        }
    }
}
