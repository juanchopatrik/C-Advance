using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificarConexionInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CTelevisor mitele = new CTelevisor("Sharpy");
            CPelota miPelota = new CPelota("Grande");
            IElectronico objeto = null;

            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)mitele;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)miPelota;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("----------Metodo dos ------------");

            Console.WriteLine("Probamos la tele");
            objeto = mitele as IElectronico;

            if (objeto != null) objeto.Encender(true);
            else Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");
            objeto = miPelota as IElectronico;

            if (objeto != null) objeto.Encender(true);
            else Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("---------------------------");

            Console.WriteLine("----------Metodo tres ------------");

            Console.WriteLine("Probamos la tele");
            if (mitele is IElectronico) mitele.Encender(true);
            else Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la tele");
            if (miPelota is IElectronico) mitele.Encender(true);
            else Console.WriteLine("No implementa IElectronico");
            
        }
    }
}
