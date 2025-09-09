using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Bluces
    {
        public static void WhileLoops()
        {
            string nombre = "";

            while (nombre == "")
            {
                Console.WriteLine("Ingresa tu nombre: ");
                nombre = Console.ReadLine();
            }
            Console.WriteLine("Hola " + nombre);
        }
        public static void ForLoops()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Despegue!");
        }
        public static void NestedLoops()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
