using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosDesechables_Finalizables1
{
    internal class CPrueba : IDisposable
    {
        private bool usoDispose = false;

        private int a;

        public CPrueba(int a)
        {
            this.a = a;
        }

        public override string ToString()
        {
            return string.Format($"El varlor es {a}");
        }

        ~CPrueba()
        {
            Limpieza();
        }

        public void Limpieza()
        {
            if ( usoDispose == false)
            {
                Console.WriteLine($@"Estamos en limpieza, aqui liberamos
                                    no administrados {a}");
            }

            usoDispose = true;
        }
        public void Dispose()
        {

            Limpieza();
            GC.SuppressFinalize( this );
        }
    }
}
