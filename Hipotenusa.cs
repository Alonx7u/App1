using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Hipotenusa
    {
        public Hipotenusa()
        {
            // Calcular la hipotenusa 
            Console.WriteLine("Ingresa el valor del cateto A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el valor del cateto B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("La hipotenusa es : " + c);

        }
    }
}
