using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Operadores
    {
        public Operadores()
        {
            //Operadores aritméticos
            int gatos = 10;
            gatos = gatos + 1; // Suma
            gatos += 1; // Suma simplificada
            gatos++; // Incremento
            gatos = gatos * 2; // Multiplicación
            gatos *= 2; // Multiplicación simplificada
            gatos = gatos - 3; // Resta
            gatos -= 3; // Resta simplificada
            gatos --; // Decremento
            gatos = gatos / 2; // División */
            gatos /= 1; // División simplificada
            int resto = gatos % 2; // Módulo (residuo de una división)
              Console.WriteLine("El residuo de la división es: " +resto);

              Console.WriteLine("Tú tienes " +gatos+ " gatos");
            Console.WriteLine("Para entender mejor lee el código");
        }
    }
}
