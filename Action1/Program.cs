using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string m = "Hola a todos ";

            Action<string, int> delAction = new Action<string, int>(RepiteElMensaje);

            delAction(m, n);
        }

        private static void RepiteElMensaje(string pMensaje, int pVeces)
        {
            int n = 0;
            for (int i = 0; i < pVeces; i++) { Console.WriteLine(pMensaje); }
        }
    }
}
