using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaInterfaces2
{
    internal class CSuma: ICalcular
    {
        private int a;
        private int b;
        private int r;

        public int Calculo(int a, int b)
        {
            this.a = a;
            this.b = b;
            r = a + b;

            return r;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"{a} + {b} = {r}");
        }
    }
}
