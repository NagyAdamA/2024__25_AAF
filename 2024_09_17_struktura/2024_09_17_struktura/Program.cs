using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_17_struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya();
        }

        struct Kutya
        {
            string nev, fajta;
            int kor, suly;
            bool chip;
        }
    }
}
