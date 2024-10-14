using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_04_ismetles
{
    internal class Program
    {
        static List<string> szinek = new List<string>();
        static void Main(string[] args)
        {
            /* ismétlés
             * Vezérlő szerkezetek
             * programozási tételek
             * metosudok
             * struktura
             * osztalyok
             * oroklodes + scope
             * fajlbeolvasas
             */

            // generaljon 20db 6 jegyu hexadecimalis szamot . ez egy hexa szin kod adja meg a szinek rgb decimalis szin kodjat
            Generalas(szinek);
            Valto();
            Console.ReadKey();
        }

        private static void Valto()
        {
            for (int i = 0; i < szinek.Count; i++)
            {
                int r = atvalt(szinek[i][0]) * 16 + atvalt(szinek[i][1]);
                int g = atvalt(szinek[i][2]) * 16 + atvalt(szinek[i][3]);
                int b = atvalt(szinek[i][4]) * 16 + atvalt(szinek[i][5]);
                Console.WriteLine($"{szinek[i]} -> R:{r} G:{g} B:{b}");

            }
        }

        private static int atvalt(char a)
        {
            switch (a)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    return 0;
            }
        }

        private static void Generalas(List<string> szinek)
        {
            Random rnd = new Random();

            while (szinek.Count < 20)
            {
                string hex = "";
                while (hex.Length < 6)
                {
                    
                    int szam = rnd.Next(0, 16);
                    if (szam > 9)
                    {
                        switch (szam)
                        {
                            case 10:
                                hex += 'A';
                                break;
                            case 11:
                                hex += 'B';
                                break;
                            case 12:
                                hex += 'C';
                                break;
                            case 13:
                                hex += 'D';
                                break;
                            case 14:
                                hex += 'E';
                                break;
                            case 15:
                                hex += 'F';
                                break;
                         }
                    }
                    else
                    {
                        hex += Convert.ToString(szam);
                    }
                }

                szinek.Add(hex);
            }
                
        }
    }
}
