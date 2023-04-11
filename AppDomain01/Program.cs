using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var procesos = from proc in Process.GetProcesses()
                           orderby proc.Id select proc;

            foreach (var proc in procesos)
            {
                Console.WriteLine($"PID: { proc.Id}, Nombre {proc.ProcessName}");
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Obtener el proceso con PID");

            Process miProceso = null;

            int pid = 12172;

            try
            {
                miProceso = Process.GetProcessById(pid);

                Console.WriteLine("Obtenemos la lista de hilos en el proceso");
                ProcessThreadCollection hilos = miProceso.Threads;

                foreach (ProcessThread hilo in hilos)
                {
                    Console.WriteLine($"Id del hilo: {hilo.Id}, " +
                        $"Inicio: {hilo.StartTime}, Prioridad : {hilo.PriorityLevel}"  );
                }
            }
            catch (Exception)
            {

                throw;
            }
            Process otroProceso = null;

            try
            {
                otroProceso = Process.Start("chrome.exe", "www.nicosio.com");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Oprime una tecla para continuar");

            Console.ReadLine();

            try
            {
                otroProceso.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
