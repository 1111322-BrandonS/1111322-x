using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_BrandonSalazar_1111322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre);

            Console.WriteLine("Que numero de Fibonacci desea?");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Ese numero de Fibonacci no existe");
            }
            else
            {
                if (num == 1)
                {
                    Console.WriteLine(0);
                }
                else if (num == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    int resultado = 0;
                    int numa1 = 0;
                    int numa2 = 1;
                    for (int i = 3; i <= num; i++)
                    {
                        resultado = numa1 + numa2;
                        numa1 = numa2;
                        numa2 = resultado;
                    }
                    Console.WriteLine(resultado);
                }
            }
            Console.ReadLine();
        }
    }
}
