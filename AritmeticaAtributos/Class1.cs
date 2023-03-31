using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticaAtributos
{
    [Datos("Mi CLase de Matematicas")]
	public class MisMates
	{
		private double a;
		private double b;
		private double r;

        public MisMates(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double R { get => r; }

        public double Suma()
        {
            r = a + b;
            return r;
        }
        public double Resta()
        {
            r = a - b;
            return r;
        }
        public double Multiplicacion()
        {
            r = a * b;
            return r;
        }
        public double Division()
        {
            r = a / b;
            return r;
        }
    }

    [Datos("Clase Prueba 1")]
    class CPrueba1
    {
        public CPrueba1() { Console.WriteLine("Version 1"); }
    }

    [Datos("Clase Prueba 2")]
    class CPrueba2
    {
        public CPrueba2() { Console.WriteLine("Version 2"); }
    }
    public sealed class DatosAttribute: System.Attribute
    {
        string dato = "";
        public string Dato { get => dato; set => dato = value; }

        public DatosAttribute() { }
        public DatosAttribute(string dato) { this.dato = dato; }
    }
}
