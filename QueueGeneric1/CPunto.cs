using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGeneric1
{
    internal class CPunto
    {
        public int x { get; set; }
        public int y { get; set; }

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
