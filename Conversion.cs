using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Conversion
    {
        public Conversion() 
        {
            Console.WriteLine("Conversion de tipos de datos");
            int entero = 10;
            double doble = entero; // Implicita
            Console.WriteLine("Entero a doble: " + doble);
            double doble2 = 9.78;
            int entero2 = (int)doble2; // Explicita
            Console.WriteLine("Doble a entero: " + entero2);
            string numero = "123";
            int numero2 = int.Parse(numero); // String a int
            Console.WriteLine("String a int: " + numero2);
            int numero3 = 456;
            string numero4 = numero3.ToString(); // Int a string
            Console.WriteLine("Int a string: " + numero4);
        }
    }
}
