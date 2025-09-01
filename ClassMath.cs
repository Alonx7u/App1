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
            double x = 5.7;
            double redondeado = Math.Round(x); // Redondeo
            Console.WriteLine("Redondeo de 5.7: " + redondeado);
            double piso = Math.Floor(x); // Piso
            Console.WriteLine("Piso de 5.7: " + piso);
            double techo = Math.Ceiling(x); // Techo
            Console.WriteLine("Techo de 5.7: " + techo);
            
            // Maximo y Minimo
            double a = 10;
            double b = 20;
            double maximo = Math.Max(a, b);
            double minimo = Math.Min(a, b);
            Console.WriteLine("Máximo entre 10 y 20: " + maximo);
            Console.WriteLine("Mínimo entre 10 y 20: " + minimo);

        }
    }
}
