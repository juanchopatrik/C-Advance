using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain AD = AppDomain.CurrentDomain;

            Console.WriteLine($"Nombre del dominio: {AD.FriendlyName}");
            Console.WriteLine($"ID Del Dominio en el Proceso : {AD.Id}");
            Console.WriteLine($"Directorio base del dominio : {AD.BaseDirectory}");

            if (AD.IsDefaultAppDomain() == true)
                Console.WriteLine("Es el de default");
            else
                Console.WriteLine("No es el de default");

            Console.WriteLine("------------------");

            Assembly[] assemblies = AD.GetAssemblies();

            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine($"Nombre: {asm.GetName().Name}, version: {asm.GetName().Version}");
            }
            
        }
    }
}
