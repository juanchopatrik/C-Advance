using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginBiblioteca1;

namespace PluginSuma1
{
    [CInfoPlugin(Creator = "Nicosio", Information = "Regresa doble, dos operandos a sumar")]
    public class CSuma : IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            double r = pA + pB;

            return r;
        }
    }
}
