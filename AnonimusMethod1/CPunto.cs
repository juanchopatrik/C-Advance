using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimusMethod1
{
    internal class CPunto
    {
        public delegate void DelMensaje();

        public DelMensaje mensaje;

        private int x;
        private int y;

        public CPunto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }
    }
}
