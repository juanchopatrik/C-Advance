using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Decoradores3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Assembly asm = Assembly.Load("AritmeticaAtributos");

                Type datoAt = asm.GetType("AritmeticaAtributos.DatosAttribute");

                PropertyInfo datoProp = datoAt.GetProperty("Dato");

                Type[] tipos = asm.GetTypes();

                foreach (Type tipo in tipos)
                {
                    object[] objetos = tipo.GetCustomAttributes(datoAt, false);

                    foreach (object item in objetos)
                    {
                        Console.WriteLine($"{tipo.Name}, {datoProp.GetValue(item, null)}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
