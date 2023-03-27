using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConvertion1
{
    internal class CReal
    {
        private double r;

        public double R { get => r; set => r = value; }

        public CReal(double r)
        {
            this.r = r;
        }

        public CReal()
        {
        }

        public override string ToString()
        {
            return string.Format($"r = {r}");
        }

        public static implicit operator CComplejo(CReal pR)
        {
            CComplejo temporal = new CComplejo((int)pR.r, 0);

            return temporal;
        }

    }
}
