using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_09_24_pitypang
{
    internal class Program
    {
        static List<Foglalas> foglalasok = new List<Foglalas>();

        struct Honap
        {
            // Mezok
            string nev;
            int kezdonap;
            int vegnap;
            int napokszama;

            // Konstruktor
            public Honap(string nev, int napokszama,int kezdonap)
            {
                this.nev = nev;
                this.napokszama = napokszama;
                this.kezdonap = kezdonap;

                vegnap = (kezdonap + napokszama) - 1;
            }
        }
        struct Foglalas
        {
            // Mezok
            public int sorszam;
            public int szobaszam;
            public int erkezes;
            public int tavozas;
            public int vendegek_szama;
            public bool reggeli;
            public string azonosito;

            //Konstruktor

            public Foglalas(int sorszam, int szobaszam, int erkezes, int tavozas, int vendegek_szama, int reggeli, string azonosito)
            {
                this.sorszam = sorszam;
                this.szobaszam = szobaszam;
                this.erkezes = erkezes;
                this.tavozas = tavozas;
                this.vendegek_szama = vendegek_szama;
                if (reggeli == 0)
                {
                    this.reggeli = false;
                }
                else 
                {
                    this.reggeli = true;
                }
                this.azonosito = azonosito;
            }

        }
        static void Main(string[] args)
        {
            FajlBeolvasasFoglalas();
        }

        private static void FajlBeolvasasFoglalas()
        {
            StreamReader f = new StreamReader("pitypang.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] sv = f.ReadLine().Split(' ');
                foglalasok.Add(new Foglalas(Convert.ToInt32(sv[0]), Convert.ToInt32(sv[1]), Convert.ToInt32(sv[2]), Convert.ToInt32(sv[3]), Convert.ToInt32(sv[4]), Convert.ToInt32(sv[5]), sv[6]));
            }

            f.Close();
        }
    }
}
