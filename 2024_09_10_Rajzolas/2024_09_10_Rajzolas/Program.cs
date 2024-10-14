using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2024_09_10_Rajzolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 10);
            
            int x = 0;
            int y = 0;

            Console.SetCursorPosition(x, y);
            Console.Write("*");

            ConsoleKeyInfo c;

            

            do
            {
                c = Console.ReadKey();
                switch (c.Key)
                {
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                }

                Console.SetCursorPosition(x, y);
                Console.Write("*");

            } while (c.Key != ConsoleKey.Escape);

            Console.ReadLine();
        }
    }
}
