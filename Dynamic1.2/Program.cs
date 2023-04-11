using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic texto = "Hola";

            int n = texto.Length;
            texto = texto.ToUpper();

            Console.WriteLine($"{n}, {texto}");

            n = texto.Length;

            //texto.nono(57);

            dynamic texto2 = "nicosio";

            try
            {
                n = texto2.Length;
                texto2.ToUpper();

                Console.WriteLine($"{n}, {texto}");

                CConDynamic objeto = new CConDynamic();

                objeto.Propiedad = 5;
                objeto.imprime();
                objeto.Propiedad = "Mas Saludos";
                objeto.imprime();

                objeto.recibe(57.6);
                objeto.recibe("Otro test");

                dynamic regreso = objeto.regresa(10);
                Console.WriteLine(regreso);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
        }
    }
}
