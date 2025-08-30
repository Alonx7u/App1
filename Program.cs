namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de Hello Word:");
            HelloWord.Mostrar();

            Console.WriteLine("Ejemplo de Declaración e Inicialización de Variables:");
            Variables.DeI();

            Console.WriteLine("Ejemplo de tipos de datos:");
            TipoDato.TdD();

            Console.WriteLine("Ejemplo de Constantes:");
            Constante c = new Constante();

            Console.WriteLine("Ejemplo de Conversión de tipos de datos:");
            Conversion conv = new Conversion();

            /*  
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
