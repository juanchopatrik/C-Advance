using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssembExectuTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = null;

            try
            {
                asm = Assembly.Load("aritmetica");
                EncuentraTipos(asm);
            }
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (asm != null)
            {
                Type mates = asm.GetType("Aritmetica.MisMates");

                try
                {
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 3 });
                    Console.WriteLine($"Tenemos instacia en {obj}");

                    MethodInfo suma = mates.GetMethod("Suma");

                    PropertyInfo resultado = mates.GetProperty("R");

                    double r = 0;

                    suma.Invoke(obj, null);

                    //ejemplo si el metodo tuviera parametros
                    //suma.Invoke(obj, new object[] { 1, 2, });

                    r = (double)resultado.GetValue(obj);

                    Console.WriteLine($"El resultado es {r}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private static void EncuentraTipos(Assembly asm)
        {
            Console.WriteLine($"Los tipos encontrados en {asm.FullName}");

            Type[] tipos = asm.GetTypes();

            foreach ( Type t in tipos )
                Console.WriteLine(t);
        }
    }
}
