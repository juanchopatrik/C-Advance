using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificarConexionInterfaz
{
    internal class CPelota
    {
        string tamano;

        public CPelota(string tamano)
        {
            this.tamano = tamano;
        }

        public override string ToString()
        {
            return string.Format("El tamano de la pelota es {0}", tamano);
        }
    }
}
