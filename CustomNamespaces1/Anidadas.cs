﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anidadas
{
    namespace ExtensionAnidadas
    {
        class Clase1
        {
            public Clase1()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saludos desde la clase1 Clases Anidadas");
            }
        }

    }

    class Clase2
    {
        public Clase2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saludos desde la Clase2 OtrasClases");
        }
    }
    class Clase3
    {
        public Clase3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Saludos desde la Clase3 OtrasClases");
        }
    }
}
