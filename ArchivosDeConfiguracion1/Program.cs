using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosDeConfiguracion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader lector = new AppSettingsReader();

            string nombre = (string)lector.GetValue("Nombre", typeof(string));  

            int edad = (int)lector.GetValue("Edad", typeof(int));

            Console.WriteLine($"{nombre}, tiene {edad} de edad");
        }
    }
}
