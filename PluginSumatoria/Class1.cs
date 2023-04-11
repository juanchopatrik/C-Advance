using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginBiblioteca1;

namespace PluginSumatoria
{
    [CInfoPlugin(Creator = "Nicosio", Information = "Regresa doble, primer operando valor, segundo poner 0")]
    public class CSumatoria : IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            int n = 0;
            double sumatoria = 0;

            for (n = 0; n < pA; n++)
                sumatoria += n;

            return sumatoria;
        }
    }
}
