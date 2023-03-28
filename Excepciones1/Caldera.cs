using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1
{
    internal class Caldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public string Marca { get => marca; set => marca = value; }
        public bool Funciona { get => funciona;}
        public int Temperatura { get => tempActual; set => tempActual = value; }

        public Caldera( string marca, int tempActual)
        {
            this.tempActual = tempActual;
            this.marca = marca;
        }

        public void Trabajar(int pAumento)
        {
            if (pAumento < 0)
                throw new
                    ArgumentOutOfRangeException("Aumento", "El aumento no puede ser negativo");

            if (funciona == false)
                Console.WriteLine($" La caldera {marca} esta descompuesta ");
            else
            {
                tempActual += pAumento;
                Console.WriteLine($"La temperatura actual es de {tempActual}");

                if (tempActual > tempMax)
                {
                    Console.WriteLine($"{marca} supero la temperatura, tiene {tempActual}");
                    tempActual = tempMax;
                    funciona = false;

                    CalderaExeption ex = new CalderaExeption(
                        string.Format($"La caldera {marca} se sobrecalienta"),
                        "Ha trabajdo demasiado tiempo",
                        DateTime.Now);

                    //Exception ex = new Exception(string.Format($"La caldera {marca} se sobrecalienta"));
                    ex.HelpLink = "http://www.nicosio.com";

                    ex.Data.Add("Momento: ", string.Format($"Ocurrio en {DateTime.Now}"));
                    ex.Data.Add("Temperatura Actual: ", string.Format($"{tempActual} grados"));
                    ex.Data.Add("Incremento Dado: ", string.Format($" {pAumento} grados"));
                    throw ex;
                }
            }
        }
    }

    public class  CalderaExeption : ApplicationException
    {
        private string mensaje = "";
        private DateTime momento;
        private string causa;

        public DateTime Momento { get => momento; set => momento = value; }
        public string Causa { get => causa; set => causa = value; }

        public CalderaExeption(string mensaje, string causa, DateTime momento)
        {
            this.mensaje = mensaje;
            this.causa = causa;
            this.momento = momento;
        }

        public override string Message
        {
            get
            {
                return string.Format($" Mensaje de la excepcion => {mensaje}");
            }
        } 
    }
}
