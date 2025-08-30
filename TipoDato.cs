using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class TipoDato
    {
        public  static void TdD()
        {
            int edad = 22;
            int edad2 = 24; // Tipo de dato entero
            Console.WriteLine("Tú edad es un tipo entero: " + edad);
            double altura = 1.60; // Tipo de dato con decimales más preciso que float
            Console.WriteLine("Tú altura es un tipo double: " + altura);
            bool comparar = edad == edad2; // Tipo de dato booleano (true o false)
            Console.WriteLine("¿Tú edad es igual a 24? " + comparar + " tipo booleano");
            char letra = 'a'; // Tipo de dato caracter (una sola letra)
            Console.WriteLine("La letra es: " + letra + " Tipo char");
            string nombre = "Juan"; // Tipo de dato cadena de texto
            Console.WriteLine("Tu nombre es un tipo string: " + nombre);
        }
    }
}
