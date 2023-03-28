using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime1
{
    internal class CPrueba
    {
        private int a;

        public CPrueba(int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format($"El valor es {a}");
        }

        ~CPrueba() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Aqui liberamos recursos no administrados");
            Console.Beep(600, 50);
        }
    }
}
