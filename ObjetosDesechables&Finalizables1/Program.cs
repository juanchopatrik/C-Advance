﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosDesechables_Finalizables1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPrueba objeto1 = new CPrueba(5);
            CPrueba objeto2 = new CPrueba(7);

            Console.WriteLine(objeto1);
            Console.WriteLine(objeto2);

            objeto1.Dispose();

            Console.WriteLine("--------- Fin del Programa ---------");
        }
    }
}
