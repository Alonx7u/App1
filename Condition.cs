using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Condition
    {
        public static void IfStatements()
        {
            Console.WriteLine("Ingresa un número:");
            string input = Console.ReadLine();
            int numero;
            if (int.TryParse(input, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("La entrada no es un número válido.");
            }
        }
        public static void SwitchStatements()
        {
            Console.WriteLine("¿Qué día de la semana es hoy?");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Es Lunes");
                    break;
                case "Martes":
                    Console.WriteLine("Es Martes");
                    break;
                case "Miércoles":
                    Console.WriteLine("Es Miércoles");
                    break;
                case "Jueves":
                    Console.WriteLine("Es Jueves");
                    break;
                case "Viernes":
                    Console.WriteLine("Es viernes");
                    break;
                case "Sabado":
                    Console.WriteLine("Es Sabado");
                    break;
                case "Domingo":
                    Console.WriteLine("Es Domingo");
                    break;
                default:
                    Console.WriteLine(dia + "No es un día de la semana");
                    break;
            }
        }
        public static void Logic()
        {
            // &&  AND
            // ||  OR
            Console.WriteLine("¿Cuál es la temperatura?");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura >= 15 && temperatura <= 30)
            {
                Console.WriteLine("Hace Calor");
            }
            else if (temperatura <= 30 || temperatura >= 50)
            {
                Console.WriteLine("Temperatura Extrema");
            }
        }
    }
}
