using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Switch
    {
        public Switch()
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
                default: Console.WriteLine(dia + "No es un día de la semana");
                    break;
            }
        }
    }
}
