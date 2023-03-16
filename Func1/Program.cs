using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y = 9;
 
            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);

            Console.WriteLine(delFunc(x,y));
        }

        private static int Suma(int arg1, int arg2)
        {
            int r = 0;
            r = arg1 + arg2;
            return r;
        }
    }
}
