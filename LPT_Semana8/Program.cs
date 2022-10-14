using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPT_Semana8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do {
                Console.Clear();
                Console.WriteLine("****BIENVENIDO ****");
                Console.WriteLine("INGRESE UNA OPCION PARA CONTINUAR");
                Console.WriteLine("1. Emitir una factura"); //Ejercicio 11
                Console.WriteLine("2. Obtener el resultado de la suma de los primeros 100 numeros naturales"); //Ejercicio 13
                Console.WriteLine("3. Resultado de ecuaciones ingresando el valor de X"); //Ejercicio 21 y 22
                Console.WriteLine("4. Presupuesto anual"); //Ejercicio 24
                Console.WriteLine("5. Salario Neto"); //Ejercicio 25
                Console.WriteLine("6. Operacion Matematica de 2 numeros"); //Ejercicio 35
                Console.WriteLine("0. SALIR");

                Console.WriteLine("");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        string product;
                        int precio, n1, impuestos;
                        Console.WriteLine("EJERCICIO 11 EN EJECUCION");
                        Console.WriteLine("Ingrese el nombre del producto que ha comprado");
                        product = Console.ReadLine();
                        Console.WriteLine("Ingrese cantidad de productos comprados");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio del producto adquirido");
                        precio = int.Parse(Console.ReadLine());

                        impuestos = (precio * n1);

                        if (impuestos > 1000)
                        {
                            int IVA, resultado, total;
                            IVA = (int)(((int)precio * n1) * 0.15);
                            total = n1 * precio;
                            resultado = (int)(int)total - IVA;
                            Console.WriteLine("FACTURA EMITIDA, debido a SubTotal se ha realizado un descuento del 15% por el producto " + product);
                            Console.WriteLine("El total es: " + resultado);
                        }
                        else if (impuestos < 0)
                        {
                            Console.WriteLine("Valor ingresado no valido, intentelo nuevamente");
                        }
                        else
                        {
                            int IVA, resultado, total;
                            IVA = (int)(((int)precio * n1) * 0.13);
                            total = n1 * precio;
                            resultado = (int)(int)total - IVA;
                            Console.WriteLine("FACTURA EMITIDA, debido a SubTotal se ha realizado un descuento del 13% por el producto " + product);
                            Console.WriteLine("El total es: " + resultado);
                        }
                        break;

                    case 2:
                        Console.WriteLine("EJERCICIO 13 EN EJECUCION");
                        int n = 100;
             
                        for (int i = 1; i <= 100; i++)
                        {
                            n = i * (i + 1) / 2;
                        }
                        Console.WriteLine("El resultado de la suma de los primeros 100 numeros naturales es: "+ n);
                        break;

                    case 3:
                        Console.WriteLine("EJERCICIO 21 Y 22 EN EJECUCION");
                        int num, r1, r2, r3;
                        Console.WriteLine("Ingrese el valor de x");
                        num = int.Parse(Console.ReadLine());

                        r1 = ((int)(3 * (Math.Pow(num, 3)) - Math.Pow(num, 1 / 3) + (4 * Math.Pow(num, 2))));
                        Console.WriteLine("Y1 = (3 * (x ^ 3)) - (x ^ (1 / 3)) + (4 * (x ^ 2)): " + r1);

                        r2 = (((int)((int)(4 * Math.Pow(num, 3)) - (3 * (Math.Pow(num, 2))) + (2 * num) - 5)));
                        Console.WriteLine("Y2 = ((4 * (x ^ 3)) - (3 * (x ^ 2) + (2 * x) - 5): " + r2);

                        r3 = (((int)((int)(5 * Math.Pow(num,1/3)) + (4 * (Math.Pow(num, 2)))) + 6));
                        Console.WriteLine("Y3 = ((5 * (x ^^1/3) + (4 * (x ^ 2)) + 6): " + r3);
                        break;

                    case 4:
                        Console.WriteLine("EJERCICIO 24 EN EJECUCION");
                        int pr, rh, manu, empa, publi, rrh, rmanu, rempa, rpubli;
                        Console.WriteLine("BIENVENIDO TRABAJOR :)");
                        Console.WriteLine("Ingrese el valor de presupuesto para este año de la empresa");
                        pr = Convert.ToInt32(Console.ReadLine());

                        rh = (int)(pr * 0.50);
                        rrh = (int)(int)pr - rh;
                        Console.WriteLine("La dinero presupuestado para el departamento de Recursos Humanos (50%) es de: " + rrh);

                        manu = (int)(pr - (pr * 0.25));
                        rmanu = (int)(int)pr - manu;
                        Console.WriteLine("La dinero presupuestado para el departamento de Manufactura (25%) es de: " + rmanu);

                        empa = (int)(pr - (pr * 0.15));
                        rempa = (int)(int)pr - empa;
                        Console.WriteLine("La dinero presupuestado para el departamento de Empaquetado (15%) es de: " + rempa);

                        publi = (int)(pr - (pr * 0.10));
                        rpubli = (int)(int)pr - publi;
                        Console.WriteLine("La dinero presupuestado para el departamento de Publicidad (10%) es de: " + rpubli);
                        break;

                    case 5:
                        Console.WriteLine("EJERCICIO 25 EN EJECUCION");
                        int sal, isss, afp, renta, tot;
                        Console.WriteLine("BIENVENIDO EMPLEADO");
                        Console.WriteLine("Ingrese el valor de su salario NETO");
                        sal = int.Parse(Console.ReadLine());

                        isss = (int)(sal * 0.09);
                        afp = (int)(sal * 0.07);
                        renta = (int)(sal * 0.10);
                        tot = sal - (isss + afp + renta);

                        Console.WriteLine("Su salario base es de: " + sal);
                        Console.WriteLine("DESCUENTOS POR REALIZAR");
                        Console.WriteLine("ISSS: " + isss);
                        Console.WriteLine("AFP: " + afp);
                        Console.WriteLine("RENTA: " + renta);
                        Console.WriteLine("Salario total devengar es de: " + tot);
                        break;

                    case 6:
                        Console.WriteLine("EJERCICIO 35 EN EJECUCION");
                        int num1, num2;
                        string var;

                        Console.WriteLine("Ingrese primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lo que desea realizar con los dos numeros ingresados (+, -, *, /, Mod)");
                        var = Console.ReadLine();

                        if (var == "+")
                        {
                            int resu1;
                            resu1 = num1 + num2;
                            Console.WriteLine("La suma de los dos numeros ingresados es: " + resu1);
                        }
                        else if (var == "-")
                        {
                            int resu2;
                            resu2 = num1 - num2;
                            Console.WriteLine("La suma de los dos numeros ingresados es: " + resu2);
                        }
                        else if (var == "*")
                        {
                            int resu3;
                            resu3 = num1 * num2;
                            Console.WriteLine("La suma de los dos numeros ingresados es: " + resu3);
                        }
                        else if (var == "/")
                        {
                            int resu4;
                            resu4 = num1 / num2;
                            Console.WriteLine("La suma de los dos numeros ingresados es: " + resu4);
                        }
                        else if (var == "Mod")
                        {
                            int resu5;
                            resu5 = num1 % num2;
                            Console.WriteLine("La suma de los dos numeros ingresados es: " + resu5);
                        }
                        else
                        {
                            Console.WriteLine("Operador ingresado incorrecto, intente nuevamente");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Se cerrara la consola");
                        break;

                    default:
                        Console.WriteLine("Ha ingresado un valor incorrecto");
                        break;
                }
                Console.ReadKey();
            }
            while (opcion != 0);
        }
    }
}
