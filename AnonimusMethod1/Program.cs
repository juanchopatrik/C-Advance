using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimusMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPunto miPunto = new CPunto(5, 6);

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
                Console.WriteLine("--------------------------");
            };

            Console.WriteLine(miPunto.ToString());

            miPunto.mensaje();

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Otro metodo anonimo");
            };

            miPunto.mensaje();
        }
    }
}
