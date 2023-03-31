using System;
using Aritmetica;

namespace CreacionDeLibrerias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MisMates mates = new MisMates(5,3);

            double resultado = mates.Suma();
            Console.WriteLine($"El Resultado de la suma es {resultado} ");
                
            mates.Multiplicacion();
            Console.WriteLine($"El Resultado de la suma es {mates.R} ");

            Console.ReadKey();
        }
    }
}
