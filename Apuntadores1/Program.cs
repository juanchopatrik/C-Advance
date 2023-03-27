using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntadores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int valor = 5;

                int* p;

                p = &valor;

                Console.WriteLine(*p);

                *p = 67;
                Console.WriteLine(*p);
                Console.WriteLine(valor);
            }

            Console.WriteLine("--------- hacemos un swap -------------");

            int a = 3;
            int b = 8;

            Console.WriteLine($"a = {a}, b = {b}");

            unsafe { swap(&a , &b); }

            Console.WriteLine($"a = {a}, b = {b}");
        }

        unsafe public static  void swap(int* v1, int* v2)
        {
            int temp = *v2;
            *v2 = temp;
            *v1 = temp;
        }
    }
}
