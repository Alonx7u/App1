using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class DataEntry
    {
       public DataEntry() 
        {
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + "!");
            Console.WriteLine("Por favor, ingresa tu edad:");
            string edadInput = Console.ReadLine();
            int edad;
            if (int.TryParse(edadInput, out edad))
            {
                Console.WriteLine("Tú tienes " + edad + " años.");
            }
            else
            {
                Console.WriteLine("La edad ingresada no es válida.");
            }
        }
    }
}
