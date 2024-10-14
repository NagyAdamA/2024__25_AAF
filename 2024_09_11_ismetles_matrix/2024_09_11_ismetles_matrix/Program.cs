using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_11_ismetles_matrix
{
    internal class Program
    {
        static int[,] matrix;
        static int oszlop, sor;
        static void Main(string[] args)
        {
            MatrixGen();
            MatrixFeltolt();
            MatrixKiir();
            Console.ReadKey();
        }

        private static void MatrixKiir()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void MatrixFeltolt()
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int rand = r.Next(3, 125) * 20;
                    matrix[i, j] = rand;

                }
            }
        }

        private static void MatrixGen()
        {
            Console.WriteLine("Adja meg a szerkezet oszlopainak számát: ");
            oszlop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a szerkezet sorainak számát:");
            sor = Convert.ToInt32(Console.ReadLine());

            matrix = new int[oszlop, sor];
        }
    }
}
