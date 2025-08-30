using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Constante
    {
        public Constante() 
        {
            Console.WriteLine("Leer lineas de código para entender las constantes");
            double pi = 3.1416;
            pi = 3.14; // No se puede cambiar el valor de una constante, pero esta no es una constante
            Console.WriteLine(pi);
            const double gravedad = 9.81; // Constante
          //double gravedad = 1.0;// No se puede cambiar el valor de una constante
            Console.WriteLine(gravedad);
        }
    }
}
