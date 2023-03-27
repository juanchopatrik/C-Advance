using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miCompu = new
            {
                Procesador = "i7",
                Memoria = 16,
                Graficos = "intel"
            };

            Console.WriteLine(miCompu);

            Console.WriteLine($"la compu tiene {miCompu.Memoria} de memoria");
        }
    }
}
