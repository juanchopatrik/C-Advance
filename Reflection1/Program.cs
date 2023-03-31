using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Type t = Type.GetType("System.Math");
                //Type t = Type.GetType("System.Collections.ArrayList");

                CaracteristicasTypo(t);
                EncuentraCampos(t);
                EncuentraPropiedades(t);
                EcuentraMetodos(t);
                EncuentraInterfaces(t);
			}
			catch (Exception)
			{
                Console.WriteLine("Verifica el tipo");
            }
        }

		public static void CaracteristicasTypo(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tienen son : ");
			Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Clase base: {t.BaseType}");
            Console.WriteLine($"Es una clae {t.IsClass}");
            Console.WriteLine($"Abstracta: {t.IsAbstract}");
            Console.WriteLine($"Sellada : {t.IsSealed}");
            Console.WriteLine($"Generica: {t.IsGenericTypeDefinition}");
        }

        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }
        }

        public static void EncuentraPropiedades(Type t)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los Propiedades encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetProperties() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }
        }

        public static void EcuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los Metodos encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetMethods() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }
            
        }

        public static void EncuentraInterfaces(Type t)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los Interfaces encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetInterfaces() select f;
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }
        }
    }
}
