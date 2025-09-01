using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class WhileL
    {
        public WhileL() 
        {
            string nombre = "";

            while (nombre == "")
            {
                Console.WriteLine("Ingresa tu nombre: ");
                nombre = Console.ReadLine();
            }
            Console.WriteLine("Hola " + nombre);
        }
    }
}
