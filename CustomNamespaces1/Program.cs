using LasClases;
using OtrasClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using principal = LasClases.Clase3;
using secundaria = OtrasClases.Clase3;
using otras = Anidadas.ExtensionAnidadas;

namespace CustomNamespaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtrasClases.Clase1 clase1 = new OtrasClases.Clase1();

            LasClases.Clase2  clase2 = new LasClases.Clase2();  

            principal obj3 = new principal();
            secundaria obj4 = new secundaria();
            otras.Clase1 obj5 = new otras.Clase1(); 
        }
    }
}
