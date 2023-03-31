using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace Decoradores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPrueba miPrueba =  new CPrueba();  

            CPrueba2 miPrueba2 = new CPrueba2();    
        }
    }
}
