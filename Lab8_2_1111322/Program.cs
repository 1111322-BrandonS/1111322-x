using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_1111322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());

            while (num > 18)
            {
                Console.WriteLine("Aun estas a salvo");
                Console.WriteLine("Ingrese otro numero");

                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Veamos...");

            }
            Console.WriteLine("Ya no estas a salvo");
            Console.ReadKey();

            do
            {
                Console.WriteLine("Este es el do while");
            }
            while (num > 18);

            Console.ReadKey();
        }
    }
}
