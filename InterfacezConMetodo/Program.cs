using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacezConMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Arreglo de Interfaces -----");

            IElectronico[] teles =
            {
                new CTelevisor("Charp"),
                new CTelevisor("Zony"),
                new CRadio("Jvc"),
                new CRadio("Aiwa")
            };


            for (int i = 0; i < teles.Length; i++)
                Console.WriteLine(teles[i]);

            Console.WriteLine("------------");
            Console.WriteLine("------ Uso de Interfaz con Metodo ------");

            CTelevisor miTV = new CTelevisor("Charp tv");
            CRadio miRadio = new CRadio("Rcb Radio");

            Muestra(miRadio);
            Muestra(miTV);

            Console.WriteLine("------------");
            Console.WriteLine("----- Metodo que regresa objeto que implementa la interfase -----");

            IElectronico aparatoCreado = null;

            aparatoCreado = CreaAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);
        }

        static void Muestra(IElectronico aparato)
        {
            if (aparato is CTelevisor)
                Console.WriteLine($"El televisor es {aparato}");

            if (aparato is CRadio)
                Console.WriteLine($" el radis es {aparato}");
        }

        static IElectronico CreaAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("que deseas crear? 1-Tele, 2-Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1)
            {
                Console.WriteLine("Dame la marca de la tele");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato); 
            }
            if (opcion == 2)
            {
                Console.WriteLine("Dame la marca de la tele");
                dato = Console.ReadLine();
                aparato = new CRadio(dato); 
            }
            return aparato;
        }
    }
}
