using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Ejercicio4
    {
        static Random r;

        public static int[,] nums;
        static void Main(string[] args)
        {
            Cargar();
            Mostrar();
            Console.ReadKey();
        }
        public static void Cargar()
        {

            nums = new int[5, 5];
            Console.Write("Números de matriz: ");
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    string num;
                    num = Console.ReadLine();
                    nums[f, c] = int.Parse(num);

                }
            }
        }


        public static void Mostrar()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(nums[f, c] + " ");
                }
            }
            Console.WriteLine();
        }


       

    }
}
