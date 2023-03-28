using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine($"El heap usa {bytesHeap}");

            int maximaGeneracion = GC.MaxGeneration + 1;
            Console.WriteLine($"{maximaGeneracion}");
 
            CPrueba prueba1 = new CPrueba(5);

            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine($"El heap usa {bytesHeap} bytes");

            int generacionIstancia = GC.GetGeneration(prueba1);

            Console.WriteLine($"La Generacion de la instacia es {generacionIstancia}");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            GC.Collect(0);
            GC.WaitForPendingFinalizers();
        }
    }
}
