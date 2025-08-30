namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siempre dar ENTER para continuar...");
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Hello Word:");
            HelloWord.Mostrar();
            Console.WriteLine("No olvides dar ENTER para continuar...");
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Declaración e Inicialización de Variables:");
            Variables.DeI();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de tipos de datos:");
            TipoDato.TdD();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Constantes:");
            Constante c = new Constante();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Conversión de tipos de datos:");
            Conversion conv = new Conversion();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Entrada de datos");
            DataEntry de = new DataEntry();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de Operadores Aritméticos:");
            Operadores op = new Operadores();
            Console.ReadLine();

            Console.WriteLine("Ejemplo de ClassMath:");
            ClassMath cm = new ClassMath();

            Console.ReadLine();


        }
    }
}
