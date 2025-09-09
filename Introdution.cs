using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Introduction
    {
        public static void Variable()
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
        public static void Constant()
        {
            Console.WriteLine("Leer líneas de código para entender las constantes");
            double pi = 3.1416;
            pi = 3.14; // No se puede cambiar el valor de una constante, pero esta no es una constante
            Console.WriteLine(pi);
            const double gravedad = 9.81; // Constante
            //double gravedad = 1.0;// No se puede cambiar el valor de una constante
            Console.WriteLine(gravedad);
        }
        public static void DataTypes()
        {
            int edad = 22;
            int edad2 = 24; // Tipo de dato entero
            Console.WriteLine("Tú edad es un tipo entero: " + edad);
            double altura = 1.60; // Tipo de dato con decimales más preciso que float
            Console.WriteLine("Tú altura es un tipo double: " + altura);
            bool comparar = edad == edad2; // Tipo de dato booleano (true o false)
            Console.WriteLine("¿Tú edad es igual a 24? " + comparar + " tipo booleano");
            char letra = 'a'; // Tipo de dato caracter (una sola letra)
            Console.WriteLine("La letra es: " + letra + " Tipo char");
            string nombre = "Juan"; // Tipo de dato cadena de texto
            Console.WriteLine("Tu nombre es un tipo string: " + nombre);
        }
        public static void Conversion()
        {
            int entero = 10;
            double doble = entero; // Implicita
            Console.WriteLine("Entero a doble: " + doble);
            double doble2 = 9.78;
            int entero2 = (int)doble2; // Explicita
            Console.WriteLine("Doble a entero: " + entero2);
            string numero = "123";
            int numero2 = int.Parse(numero); // String a int
            Console.WriteLine("String a int: " + numero2);
            int numero3 = 456;
            string numero4 = numero3.ToString(); // Int a string
            Console.WriteLine("Int a string: " + numero4);
        }
        public static void DataEntry()
        {
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + "!");
            Console.WriteLine("Por favor, ingresa tu edad:");
            string edadInput = Console.ReadLine();
            int edad;
            if (int.TryParse(edadInput, out edad))
            {
                Console.WriteLine("Tú tienes " + edad + " años.");
            }
            else
            {
                Console.WriteLine("La edad ingresada no es válida.");
            }
        }
        public static void StringMethod()
        {
            string fullName = "Alondra Lopez Gomez";
            Console.WriteLine("Nombre en mayúsculas" + fullName.ToUpper());
            Console.WriteLine("Nombre en minúsculas" + fullName.ToLower());
            Console.WriteLine("Insertar texto" + fullName.Insert(0, "M."));
            Console.WriteLine("Substring" + fullName.Substring(8, 5));

            string iniciales = fullName.Substring(0, 1) + fullName.Substring(8, 1) + fullName.Substring(14, 1);
            Console.WriteLine("Tus iniciales son: " + iniciales);

            string phone = "123-456-7890";
            phone = phone.Replace("-", " ");
            Console.WriteLine("Número de teléfono: " + phone);
        }
    }
}
