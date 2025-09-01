using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Ramdom
    {
        public Ramdom() 
        {
            // Clase Número Aleatrios
            Random rand = new Random();
            int numeroAleatorio1= rand.Next(1, 101); // Número aleatorio entre 1 y 100
            int numeroAleatorio2= rand.Next(1, 101);
            int numeroAleatorio3= rand.Next(1, 101);
            Console.WriteLine("Número aleatorio entre 1 y 100: " + numeroAleatorio1);
            Console.WriteLine("Número aleatorio entre 1 y 100: " + numeroAleatorio2);
            Console.WriteLine("Número aleatorio entre 1 y 100: " + numeroAleatorio3);



        }
    }
}
