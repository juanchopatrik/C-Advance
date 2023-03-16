using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine($"x = {x}, y = {y}");
            Intercambio<int>(ref x,ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            double m = 78.9;
            double n = 98.6;

            Console.WriteLine($"m = {m}, n = {n}");
            Intercambio<double>(ref m,ref n);
            Console.WriteLine($"m = {m}, n = {n}");

        }

        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
