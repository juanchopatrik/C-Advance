using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTable = new Hashtable();

            miTable.Add(123 , "Hola");
            miTable.Add(234 , "Saludos");
            miTable.Add(45 , "Adios");
            miTable.Add(567 , "C#");
            miTable.Add(12763 , "Programacion");

            foreach (DictionaryEntry element in miTable)
            {
               Console.WriteLine($"{element.Key}, {element.Value}");
            }

            Console.WriteLine("---------------");
            Console.WriteLine(miTable.Count);
            Console.WriteLine("---------------");

            Console.WriteLine(miTable[567]);
            Console.WriteLine(miTable[445]);
            Console.WriteLine("---------------");

            miTable[45] = "Avanzado";
            miTable[300] = "Colecciones";

            foreach (DictionaryEntry element in miTable)
            {
               Console.WriteLine($"{element.Key}, {element.Value}");
            }
                
            Console.WriteLine("---------------");
            Console.WriteLine(miTable.Contains(567));
            Console.WriteLine(miTable.Contains(335));
            Console.WriteLine("---------------");

            miTable.Remove(234);

            foreach (DictionaryEntry element in miTable)
            {
               Console.WriteLine($"{element.Key}, {element.Value}");
            }

            Console.WriteLine("---------------");

            foreach (int llave in miTable.Keys)
            {
                Console.WriteLine(llave);
            }

            Console.WriteLine("---------------");

            foreach (int valor in miTable.Values)
            {
                Console.WriteLine(valor);
            }

        }
    }
}
