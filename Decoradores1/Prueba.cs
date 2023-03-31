using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Decoradores1
{
    class CPrueba
    {
        public CPrueba()
        {
            Console.WriteLine("Version 1");
        }
    }

    [Datos("Clase por Juanchito")]
    class CPrueba2
    {
        public CPrueba2()
        {
            Console.WriteLine("Version 2");
        }
    }
}
