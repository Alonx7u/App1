using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class IfStatements
    {
        public IfStatements()
        {
            Console.WriteLine("Ingresa un número:");
            string input = Console.ReadLine();
            int numero;
            if (int.TryParse(input, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
    }
}
