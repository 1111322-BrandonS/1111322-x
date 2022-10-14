using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_1111322_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            { 
                if (n1 > n3)
                {
                    Console.WriteLine("El primer numero es el mayor");
                }
                else
                {
                    if (n1 == n3)
                    {
                        Console.WriteLine("El primer y tercer numero son los mayores");
                    }
                    else
                    {
                        Console.WriteLine("El tercer numero es el mayor");
                    }
                }
            }
            else
            {
                if (n1 == n2)
                {
                   if (n1 > n3)
                    {
                        Console.WriteLine("El tercer numero es el mayor");
                    }
                    else
                    {
                        if (n1 == n3)
                        {
                            Console.WriteLine("Todos los numeros son iguales");
                        }
                        else
                        {
                            Console.WriteLine("El segundo y tercer numero son los mayores");
                        }
                    }
                }
                else
                {
                    if (n2 > n3)
                    {
                        Console.WriteLine("El segundo numero es el mayor");
                    }
                    else
                    {
                        if (n2 == n3)
                        {
                            Console.WriteLine("El segundo y tercer numero son los mayores");
                        }
                        else
                        {
                            Console.WriteLine("El tercer numero es el mayor");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
