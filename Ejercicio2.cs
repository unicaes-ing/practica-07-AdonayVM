using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int[] num;
            int pares = 0, impares = 0;
            Console.WriteLine("Ingrese la cantidad de números a usar: ");
            num = new int[Convert.ToInt32(Console.ReadLine())];
            for (int n = 0; n < num.Length; n++)
            {
                Console.WriteLine("\nNúmero {0}:", n+1);
                num[n] = Convert.ToInt32(Console.ReadLine());

                if (num[n] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.Clear();
            Console.WriteLine("Números pares ingresados: " + pares);
            Console.WriteLine("\nNúmeros impares ingresados: " + impares);
            Console.ReadKey();
        }
    }
}
