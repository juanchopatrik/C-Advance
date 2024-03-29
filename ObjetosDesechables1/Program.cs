﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosDesechables1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPrueba objeto = new CPrueba(5);
            Console.WriteLine(objeto);
            objeto.Dispose();

            if (objeto is IDisposable)
                objeto.Dispose();

            try
            {
                Console.WriteLine(objeto);
            }
            finally {objeto.Dispose(); }

            using (CPrueba prueba2 = new CPrueba(7))
            {
                Console.WriteLine(prueba2);
            }
        }
    }
}
