using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic1._2
{
    internal class CConDynamic
    {
        private dynamic atributo;

        public dynamic Propiedad { get => atributo; set => atributo = value; }

        public void imprime() { Console.WriteLine(atributo); }

        public void recibe( dynamic parametro)
        {
            Console.WriteLine($"Recibi {parametro}");
        }

        public dynamic regresa(int a)
        {
            if (a < 0)
                return 5;
            else
                return "positivo";
        }
    }
}
