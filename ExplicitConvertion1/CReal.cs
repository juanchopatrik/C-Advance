using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConvertion1
{
    internal class CReal
    {
        private double r;

        public double R { get => r; set => r = value; }

        public CReal()
        {
        }

        public CReal(double r)
        {
            this.r = r;
        }

        public override string ToString()
        {
            return string.Format($"r = {r}");
        }
    }
}
