using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList miLista= new SortedList();
            
            miLista.Add( 754, "Honda");
            miLista.Add( 123, "Volvo");
            miLista.Add( 587, "Nissan");
            miLista.Add( 323, "Fiat");

            foreach(DictionaryEntry elemento in miLista)
                Console.WriteLine($"{elemento.Key},{elemento.Value}");

            Console.WriteLine("--------------------");

            Console.WriteLine(miLista.Count);

            Console.WriteLine(miLista.Contains(123));
            Console.WriteLine(miLista.Contains(678));

            Console.WriteLine(miLista.ContainsKey(587));
            Console.WriteLine(miLista.ContainsValue("Volvo"));

            Console.WriteLine("--------------------");

            Console.WriteLine(miLista.GetKey(2));
            Console.WriteLine(miLista.GetByIndex(2));
        }
    }
}
