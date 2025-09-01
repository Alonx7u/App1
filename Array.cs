using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Array
    {
        public Array()
        {
            string[] colores = { "verde", "azul", "rojo" };

            colores[0] = "morado";

            for (int i = 0; i < colores.Length; i++)
            {
                Console.WriteLine(colores[i]);

            }
        }   
    }
}
