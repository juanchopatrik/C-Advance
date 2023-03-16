using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections1
{
    internal class CPunto : IComparable<CPunto>
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

        public int CompareTo( CPunto b)
        {
            double maga = Math.Sqrt( x * x + y * y );
            double magb = Math.Sqrt(b.x * b.x + b.y * b.y );

            if (maga > magb) return 1;
            if (maga < magb) return -1; 
            else return 0;
        }
    }
}
