using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separador_de_Palabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una oracion");
            string oracion = Console.ReadLine();

            char delimitador = ' ';
            string[] palabras = oracion.Split(delimitador);
            string[] finales = new string[palabras.Length];
            int[] frecuencia = new int[oracion.Length];

            for (int i = 0; i < palabras.Length; i++)
            {
                finales[i] = "";
                frecuencia[i] = 0;
            }

            for (int i = 0; i < palabras.Length; i++)
            {
                for (int j = 0; j < finales.Length; j++)
                {
                    if (finales[j] == "")
                    {
                        finales[j] = palabras[i];
                        frecuencia[j]++;
                        break;
                    }
                    else if (palabras[i] == finales[j])
                    {
                        frecuencia[j]++;
                        break;
                    }
                }
            }
            for (int i = 0; i < finales.Length; i++)
            {
                Console.WriteLine("Palabra: " + finales[i] + " frecuencia" + frecuencia[i]);

            }

            Console.WriteLine("PALABRAS UNICAS ");
            for (int i = 0; i < finales.Length; i++)
            {
                if (frecuencia[i] == 1)
                {
                    Console.WriteLine(finales[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
