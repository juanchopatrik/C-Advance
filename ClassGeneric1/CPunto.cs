using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric1
{
    internal class CPunto<T>
    {
        private T x;
        private T y;

        public CPunto(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }

        public void Reset()
        {
            x = default(T); y = default(T);
        }

        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
                Console.WriteLine("Trabajo como entero");
            else
                Console.WriteLine("Soy de otro tipo");
        }
    }
}
