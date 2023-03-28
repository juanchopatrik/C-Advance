using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosDesechables1
{
    internal class CPrueba:IDisposable
    {
        private int a;

        public CPrueba(int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Dispose()
        {
            Console.WriteLine($@"Estamos en dispose, aqui liberamos
                                lo no administrado {a}");
        }
    }
}
