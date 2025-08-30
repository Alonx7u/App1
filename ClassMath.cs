using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class ClassMath
    {
        public ClassMath()
        {
            int numero = -5;
            int absoluto = Math.Abs(numero); // Valor absoluto
            Console.WriteLine("Valor absoluto de -5: " + absoluto);
            double raiz = Math.Sqrt(16); // Raíz cuadrada
            Console.WriteLine("Raíz cuadrada de 16: " + raiz);
            double potencia = Math.Pow(2, 3); // Potencia
            Console.WriteLine("2 elevado a la 3: " + potencia);
            double seno = Math.Sin(Math.PI / 2); // Seno
            Console.WriteLine("Seno de π/2: " + seno);
            double coseno = Math.Cos(0); // Coseno
            Console.WriteLine("Coseno de 0: " + coseno);
            double logaritmo = Math.Log(10); // Logaritmo natural
            Console.WriteLine("Logaritmo natural de 10: " + logaritmo);
        }
    }
}
