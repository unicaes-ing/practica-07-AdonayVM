using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades;
            int mayores = 0, menores = 0;
            Console.WriteLine("Ingrese la cantidad de personas: ");
            edades = new int[Convert.ToInt32(Console.ReadLine())];
            for (int e = 0; e < edades.Length; e++)
            {

                Console.WriteLine("\nIngrese la edad de la persona {0}:", e+1);
                edades[e] = Convert.ToInt32(Console.ReadLine());
                if (edades[e] >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
            }
            Console.Clear();
            Console.WriteLine("Personas mayores de edad: " + mayores);
            Console.WriteLine("\nPersonas menores de edad: " + menores);
            Console.ReadKey();
        }
    }
}
