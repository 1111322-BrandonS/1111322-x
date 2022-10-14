using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace T5_Otra_version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numb = new double[3];
            string resp = "";
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese el número No." + Convert.ToString(i + 1));
                    numb[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese si la cantidad esta en GTQ o USD");
                    resp = Console.ReadLine();
                    if (resp == "GTQ")
                    {
                        Console.WriteLine("Su dato esta en GTQ");
                    }
                    else if (resp == "USD")
                    {
                        numb[i] = numb[i] / 7.83;
                        Console.WriteLine(numb[i]);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese adecuadamente la palabra");
                    }
                }
                for (int j = 0; j < numb.Length; j++)
                {
                    for (int k = j + 1; k < numb.Length; k++)
                    {
                        double aux;
                        if (numb[j] > numb[k])
                        {
                            aux = numb[j];
                            numb[j] = numb[k];
                            numb[k] = aux;
                        }
                    }
                }
                Console.WriteLine("Datos ordenados");
                for (int j = 0; j < numb.Length; j++)
                {
                    Console.Write(" | " + numb[j] + " | ");
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un dato no valido.");
                Console.ReadKey();
            }
        }
    }
}
