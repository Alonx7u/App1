using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class StringMethod
    {
        public StringMethod()
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
