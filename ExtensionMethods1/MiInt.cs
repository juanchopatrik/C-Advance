using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods1
{
    internal class MiInt : ISaludador
    {
        private int a;

        public MiInt(int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format($"tu int es {a}");
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola desde mi int {a}");
        }
    }
}
