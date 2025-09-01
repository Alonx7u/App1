using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Logico
    {
        public Logico()
        {
            // &&  AND
            // ||  OR
            Console.WriteLine("¿Cuál es la temperatura?");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura >= 15  && temperatura <= 30)
            {
                Console.WriteLine("Hace Calor");
            }
            else if (temperatura <=30 || temperatura >=50)
            {
                Console.WriteLine("Temperatura Extrema");
            }
        }
    }
}
