using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-0", 20);

            try
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    miCaldera.Trabajar(20);
                //}

                miCaldera.Trabajar(12);

            }
            catch (CalderaExeption e)
            {
                Console.WriteLine("\n Sucedio la exception");
                Console.WriteLine($"En este metodo : {e.TargetSite}");
                Console.WriteLine($"Con este metodo de error: {e.Message}");
                Console.WriteLine($"Fuente: {e.Source}");

                Console.WriteLine($"Clase donde ocurrio: {e.TargetSite.DeclaringType} ");
                Console.WriteLine($"Tipo de miembro: {e.TargetSite.MemberType}");
                Console.WriteLine($"Stack: {e.StackTrace}");
                Console.WriteLine($"Help Link : {e.HelpLink}");

                Console.WriteLine(" datos propios en la excepcion");

                if (e.Data != null)
                {
                    foreach (DictionaryEntry dato in e.Data)
                    {
                        Console.WriteLine($" -> {dato.Key} -> {dato.Value}");
                    }
                }

                Console.WriteLine("-------- Usando la excepcion Propia --------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Momento);
                Console.WriteLine(e.Causa);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("El codigo comun de finally");
            }
        }
    }
}
