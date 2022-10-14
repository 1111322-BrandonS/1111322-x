using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_BrandonSalazar_1111322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verificador de contraseña
            string Contrasena = "";
            string Contrasena2 = "";
            Console.WriteLine("Ingrese una contraseña");
            Contrasena = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese su contraseña");
                Contrasena2 = Console.ReadLine();
            }
            while (!(Contrasena.Equals(Contrasena2)));
        }
    }
}
