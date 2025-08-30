namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");
             Console.WriteLine("\n HOLA");
             Console.WriteLine("\t HOLA2");

             /*APLICAR
              * VARIABLES
              * TIPOS DE DATOS
              */

            /*   int x; // Declaracion
               x = 10; // Inicializacion
               int y = 20; // Declaracion e inicializacion
               Console.WriteLine(x);
               Console.WriteLine(y);
               int z = x + y;
               Console.WriteLine(z);
               int edad = 22;
               int edad2 = 24; // Tipo de dato entero
               Console.WriteLine("Tú edad es: " +edad);
               double altura = 1.60; // Tipo de dato con decimales más preciso que float
               Console.WriteLine("Tú altura es: " +altura );
               bool comparar = edad == edad2; // Tipo de dato booleano (true o false)
               Console.WriteLine(comparar);
               char letra = 'a'; // Tipo de dato caracter (una sola letra)
               Console.WriteLine(letra);
               string nombre = "Juan"; // Tipo de dato cadena de texto
               Console.WriteLine("Tu nombre es: " +nombre);

               // Constantes
               double pi = 3.1416;
               pi = 3.14; // No se puede cambiar el valor de una constante, pero esta no es una constante
               Console.WriteLine(pi);
               const double gravedad = 9.81; // Constante
              // double gravedad = 10; // No se puede cambiar el valor de una constante
               Console.WriteLine(gravedad);

               // Conversion de tipos
               double numero = 10.52;
               int numero2 = Convert.ToInt32(numero); // Conversion implicita
               Console.WriteLine(numero2);

               // Entrada de datos
               Console.Write("¿Cuál es tu nombre?");
               string name = Console.ReadLine();
               Console.Write("¿Cuál es tu edad?");
               int age = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Tu nombre es: " +name);
               Console.WriteLine("Tu edad es: " +age);
               Console.ReadKey();

               //Operadores aritméticos
               int gatos = 10;
             //  gatos = gatos + 1; // Suma
              // gatos += 1; // Suma simplificada
             //  gatos++; // Incremento
             /*  gatos = gatos * 2; // Multiplicación
               gatos *= 2; // Multiplicación simplificada
               gatos = gatos - 3; // Resta
               gatos -= 3; // Resta simplificada
               gatos --; // Decremento
               gatos = gatos / 2; // División */
            // gatos /= 1; // División simplificada
            /*  int resto = gatos % 2; // Módulo (residuo de una división)
              Console.WriteLine("El residuo de la división es: " +resto);

              Console.WriteLine("Tú tienes " +gatos+ " gatos");*/

            // Class math
            int x = 4;
            double a = Math.Pow(x, 3); // Potencia
            Console.WriteLine(a);


            double raiz = Math.Sqrt(a); // Raíz cuadrada
            Console.WriteLine(raiz);

            // Mi comentario, okey aqui voy a hacer un cambio:)

            Console.ReadLine();


        }
    }
}
