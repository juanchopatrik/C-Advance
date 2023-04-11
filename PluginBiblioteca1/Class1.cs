using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginBiblioteca1
{
    public interface IPlugInMates
    {
        double Calcular(double pA, double pB);

    }

    [AttributeUsage(AttributeTargets.Class)]    
    public sealed class CInfoPlugin : System.Attribute
    {
        private string creator;
        private string information;

        public string Creator { get => creator; set => creator = value; }
        public string Information { get => information; set => information = value; }
    }
}
