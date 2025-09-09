namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("°°°Bienvenido a mi menú°°°");
                Console.WriteLine("1. Hello World");
                Console.WriteLine("2. Pruebas");
                Console.WriteLine("Elige una opción: ");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            HelloWord.Mostrar();
                            break;
                        case 2:
                            
                            break;
                        case 0:
                            Console.WriteLine("Saliendo ....");
                            break;

                        default:
                            Console.WriteLine("Opción No Valida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                }
                if (option != 0) ;
                {
                    Console.WriteLine("\nPresiona ENTER para volver al menú...");
                    Console.ReadLine();
                }
            } while (option != 0);
        }
    }
}
