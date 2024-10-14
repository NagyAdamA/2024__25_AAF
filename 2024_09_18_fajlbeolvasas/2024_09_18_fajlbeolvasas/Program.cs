using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_09_18_fajlbeolvasas
{
    internal class Program
    {
        static List<Feladvany> megoldasok = new List<Feladvany>();
        static int[,] feladvany = new int[10, 10];
        struct Feladvany
        {
            public string nev;
            public int[,] megoldas;
        }
        static void Main(string[] args)
        {
            FajlBeolvasas("megoldas.txt");
            MegoldasBeolvas();
            Console.ReadLine();
        }

        private static void MegoldasBeolvas()
        {
            StreamReader f = new StreamReader("feladvany.txt");
            while (!f.EndOfStream)
            {
                for (int i = 0; i < 10; i++)
                {
                    string[] sl = f.ReadLine().Split(' ');
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < sl.Length; k++)
                        {
                            feladvany[i, j] = Convert.ToInt32(sl[k]);
                        }
                    }
                }
            }
            f.Close();
        }

        private static void FajlBeolvasas(string fajlnev)
        {
            StreamReader f = new StreamReader(fajlnev);
            f.ReadLine();
            while (!f.EndOfStream) 
            {
                Feladvany sv = new Feladvany();
                sv.nev = f.ReadLine();
                int[,] matrix = new int[10,10];
                
                for(int i = 0; i < 10; i++)
                {
                    string[] sl = f.ReadLine().Split(' ');

                    for (int k = 0; k < sl.Length; k++)
                    {
                        matrix[i, k] = Convert.ToInt32(sl[k]);
                    }
                }
                sv.megoldas = matrix;
                megoldasok.Add(sv);
            }
            f.Close();
        }
    }
}
