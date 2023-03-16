using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NulleableVarDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = "Hola a todos";
            var c = 15.689;
            var d = false;
            var f = c;
            //d = 8;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine($"a es {a.GetType().Name}");
            Console.WriteLine($"b es {b.GetType().Name}");
            Console.WriteLine($"c es {c.GetType().Name}");
            Console.WriteLine($"d es {d.GetType().Name}");
            Console.WriteLine($"f es {f.GetType().Name}");

            Console.WriteLine("------------------------");

            int? dato = 5;
            Console.WriteLine($"dato {dato}");
            dato = null;
            Console.WriteLine($"dato {dato}");

            double? precio = null;
            precio = 6.7;
            Console.WriteLine(precio);

            precio = null;

            if (precio.HasValue)
                Console.WriteLine($"Tiene valor de {precio.Value}");
            else
                Console.WriteLine("No tiene valor");

            double? numero = asignador() ?? 5.55;
            Console.WriteLine(numero);
        }

        public static double? asignador()
        {
            return 4.5;
        }
    }
}
