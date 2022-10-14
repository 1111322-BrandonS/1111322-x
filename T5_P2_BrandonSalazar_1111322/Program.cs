using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_P2_BrandonSalazar_1111322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, d = 0;
            string cod;
            try
            {
                Console.WriteLine("Ingrese el monto de la compra realizada");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Posee algun codigo de descuento? Si/No");
                cod = Console.ReadLine();

                if (cod == "Si")
                {
                    if (n1 < 400)
                    {
                        d = n1 - (n1 * 0.05);
                        Console.WriteLine("Solo tiene un 5% de descuento al total de su compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 < 1000)
                    {
                        d = n1 - ((n1 * 0.07) + (n1 * 0.05));
                        Console.WriteLine("Obtiene un 7% de descuento por el total de compra y 5% por el codigo");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 <= 5000)
                    {
                        d = n1 - ((n1 * 0.1) + (n1 * 0.05));
                        Console.WriteLine("Obtiene un 10% de descuento por el total de compra y 5% por el codigo");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 <= 15000)
                    {
                        d = n1 - ((n1 * 0.15) + (n1 * 0.05));
                        Console.WriteLine("Obtiene un 15% de descuento por el total de compra y 5% por el codigo");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 > 15000)
                    {
                        d = n1 - ((n1 * 0.25) + (n1 * 0.05));
                        Console.WriteLine("Obtiene un 25% de descuento por el total de compra y 5% por el codigo");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                }
                else if (cod == "No")
                {
                    if (n1 < 400)
                    {
                        d = n1 - (n1 * 0.05);
                        Console.WriteLine("Solo tiene un 5% de descuento al total de su compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 < 1000)
                    {
                        d = n1 - (n1 * 0.07);
                        Console.WriteLine("Obtiene un 7% de descuento por el total de compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 <= 5000)
                    {
                        d = n1 - (n1 * 0.1);
                        Console.WriteLine("Obtiene un 10% de descuento por el total de compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 <= 15000)
                    {
                        d = n1 - (n1 * 0.15);
                        Console.WriteLine("Obtiene un 15% de descuento por el total de compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                    else if (n1 > 15000)
                    {
                        d = n1 - (n1 * 0.25);
                        Console.WriteLine("Obtiene un 25% de descuento por el total de compra");
                        Console.WriteLine("Su total con descuentos aplicados es de Q" + d);
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese unicamente Si o No, utilizando letra mayuscula al inicio de su respuesta");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Has ingresado un valor invalido");
            }
            Console.ReadKey();
        }
    }
}
