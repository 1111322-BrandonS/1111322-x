using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                if (n2 < n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    if (n1 < n3)
                    {
                        Console.WriteLine(n1);
                        Console.WriteLine(n3);
                        Console.WriteLine(n2);
                    }
                    else
                    {
                        Console.WriteLine(n3);
                        Console.WriteLine(n1);
                        Console.WriteLine(n2);
                    }
                }
            }
            else
            {
                if (n1 < n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    if (n2 < n3)
                    {
                        Console.WriteLine(n2);
                        Console.WriteLine(n3);
                        Console.WriteLine(n1);
                    }
                    else
                    {
                        Console.WriteLine(n3);
                        Console.WriteLine(n2);
                        Console.WriteLine(n1);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
