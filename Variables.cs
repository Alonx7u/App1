using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Variables
    {
        public static void DeI()
        {
            int x; // Declaracion
            x = 10; // Inicializacion
            int y = 20; // Declaracion e inicializacion
            Console.WriteLine("Declaración int x");
            Console.WriteLine("Inicialización:x = " + x + "\n Resultado:" + x);
            Console.WriteLine("Declaración e inicialización int y = 20" + "\n Resultado:" + y);
            int z = x + y;
            Console.WriteLine("Suma de int z = x + y" + "\n Resultado:" + z);
        }
    }
}
