using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Ejercicio3
    {
        //17-09-19
        static string[][] liga;
        static string[] NombreE;
        static void Main(string[] args)
        {
            datos();
            Console.WriteLine("Presione una tecla para ver los datos de La Liga...");
            Console.ReadKey();
            mostrar();
            Console.ReadKey();
        }

        static void datos()
        {
            int equipos, jugadores;
            Console.WriteLine("¿Cuántos equipos son en la liga?");
            equipos = Convert.ToInt32(Console.ReadLine());
            liga = new String[equipos][];
            NombreE = new string[equipos];
            for (int e = 0; e < liga.Length; e++)
            {
                Console.WriteLine("\nIngrese le nombre del equipo " + (e+1) + ":");
                NombreE[e] = Console.ReadLine();
                Console.WriteLine("\nJugadores: ");
                jugadores = Convert.ToInt32(Console.ReadLine());
                liga[e] = new string[jugadores];
                for (int j = 0; j < liga[e].Length; j++)
                {
                    Console.WriteLine("\nIngrese el nombre del jugador " + (j+1) + ":");
                    liga[e][j] = Console.ReadLine();
                }
                Console.Clear();
            }
        }

        static void mostrar()
        {
            Console.Clear();
            Console.WriteLine("/////////////////////////LA LIGA DE FÚTBOL ////////////////////////////");
            Console.WriteLine("\n  EQUIPOS: ");
            for (int e = 0; e < liga.Length; e++)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\n\n°EQUIPO {0}:", NombreE[e]);
                Console.WriteLine("\nINTEGRANTES: ");
                for (int j = 0; j < liga[e].Length; j++)
                {
                    Console.WriteLine("\n" + "-" + liga[e][j] + " ");
                }
            }
            
        }
    }
}
