﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConvertion1
{
    internal class CComplejo
    {
        private int a;
        private int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public CComplejo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return string.Format($"{a} + {b}i");
        }

        public static explicit operator CReal(CComplejo pi)
        {
            CReal temp = new CReal();
            temp.R = pi.a;
            return temp;
        }
    }
}
