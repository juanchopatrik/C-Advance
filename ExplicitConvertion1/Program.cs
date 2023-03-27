using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConvertion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CComplejo comp1 = new CComplejo(2, 3);

            CReal real1 = (CReal)comp1;
            Console.WriteLine(real1);
        }
    }
}
