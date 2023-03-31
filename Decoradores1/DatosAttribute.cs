using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoradores1
{
    public sealed class DatosAttribute : System.Attribute
    {
        string dato = "";
        public string Dato { get => dato; set => dato = value; }

        public DatosAttribute() { }
        public DatosAttribute(string dato) { this.dato = dato; }
    }
}
