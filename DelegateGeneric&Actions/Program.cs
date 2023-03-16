using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric_Actions
{
    public delegate void miDelegado<T>(T p);
    internal class Program
    {
        static void Main(string[] args)
        {
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Hola a todos");

            miDelegado<double> delDouble = new miDelegado<double>(HandlerDouble);
            delDouble(58.7);
        }

        private static void HandlerDouble(double p)
        {
            Console.WriteLine($"uso string como tipo y el valor es {p}");
        }

        private static void HandlerString(string p)
        {
            Console.WriteLine($"uso doble como tipo y el valor es {p}");
        }
    }
}
