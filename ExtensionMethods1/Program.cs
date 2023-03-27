using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 55;

            bool par = numero.EsPar();

            Console.WriteLine($"{numero} es {par}");

            double valor = 55.18;

            Console.WriteLine(valor.Dobletea());

            MiInt entero = new MiInt(7);

            entero.Sonido();
        }
    }
}
