using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacion2 = new COperaciones<string>();

            Console.WriteLine(miOperacion.Suma(5,4));
            Console.WriteLine(miOperacion2.Suma("Hola", " esto es una prueba"));
        }

        class COperaciones<T>
        {
            public T Suma(T a, T b)
            {
                dynamic da = a, db = b;
                return da + db;
            }
            public T Resta(T a, T b)
            {
                dynamic da = a, db = b;
                return da - db;
            }
            public T Div(T a, T b)
            {
                dynamic da = a, db = b;
                return da / db;
            }
            public T Mult(T a, T b)
            {
                dynamic da = a, db = b;
                return da * db;
            }
        }
    }
}
