using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_25_classgyakorlas
{

    internal class Program
    {
        static List<Foglalas> foglalasok = new List<Foglalas>();
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            Console.WriteLine(f.Feladat2());
            f.Feladat3();
            Console.ReadLine();
        }


    }

    class Feladatok
    {
        List<Foglalas> foglalasok = new List<Foglalas> { };
        List<Honap> honapok = new List<Honap> { };

        // konstruktor
        public Feladatok()
        {
            FajlBeolvasasFoglalas();
            FajlBeolvasasHonap();
        }


        // Fajlbeolvasas
        void FajlBeolvasasHonap()
        {
            StreamReader f = new StreamReader("honapok.txt");
            while (!f.EndOfStream)
            {
                honapok.Add(new Honap(f.ReadLine(), Convert.ToInt32(f.ReadLine()), Convert.ToInt32(f.ReadLine())));
            }

            f.Close();
        }
        void FajlBeolvasasFoglalas()
        {
            StreamReader f = new StreamReader("pitypang.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] sv = f.ReadLine().Split(' ');
                foglalasok.Add(new Foglalas(
                    Convert.ToInt32(sv[0]), Convert.ToInt32(sv[1]), Convert.ToInt32(sv[2]),
                    Convert.ToInt32(sv[3]), Convert.ToInt32(sv[4]), Convert.ToInt32(sv[5]), 
                    sv[6])
                );
            }

            f.Close();
        }

        // Feladatok
        public string Feladat2()
        {
            int maxi = 0;
            for (int i = 0; i < foglalasok.Count; i++)
            {
                if (foglalasok[maxi].tavozas - foglalasok[maxi].erkezes < foglalasok[i].tavozas - foglalasok[i].erkezes)
                {
                    maxi = i;
                }
            }

            return $"{foglalasok[maxi].azonosito} ({foglalasok[maxi].erkezes}) - {foglalasok[maxi].tavozas - foglalasok[maxi].erkezes}";
        }

        public void Feladat3()
        {
            StreamWriter iro = new StreamWriter("bevetel.txt");
            for (int i = 0; i < foglalasok.Count; i++)
            {
                int osszar = 0;
                int szobaar = SzobaAr(i);

                osszar += szobaar * (foglalasok[i].tavozas - foglalasok[i].erkezes);
                osszar = VendegAgy(i, osszar);
                osszar = ReggeliAr(i, osszar);

                iro.WriteLine($"{foglalasok[i].sorszam}:{osszar}");

            }
            iro.Close();
        }

        private int ReggeliAr(int i, int osszar)
        {
            if (foglalasok[i].reggeli)
            {
                osszar += (foglalasok[i].tavozas - foglalasok[i].erkezes) * foglalasok[i].vendegek_szama * 1100;
            }

            return osszar;
        }

        private int VendegAgy(int i, int osszar)
        {
            if (foglalasok[i].vendegek_szama > 2)
            {
                osszar += (foglalasok[i].tavozas - foglalasok[i].erkezes) * 2000;
            }

            return osszar;
        }

        private int SzobaAr(int i)
        {
            int szobaar;
            if (foglalasok[i].erkezes > honapok[0].kezdonap && foglalasok[i].erkezes < honapok[3].vegnap)
            {
                szobaar = 9000;
            }
            else if (foglalasok[i].erkezes > honapok[4].kezdonap && foglalasok[i].erkezes < honapok[7].vegnap)
            {
                szobaar = 10000;
            }
            else
            {
                szobaar = 8000;
            }

            return szobaar;
        }
    }

    class Honap
    {
        // Mezok
        public string nev;
        public int kezdonap;
        public int vegnap;
        public int napokszama;

        // Konstruktor
        public Honap(string nev, int napokszama, int kezdonap)
        {
            this.nev = nev;
            this.napokszama = napokszama;
            this.kezdonap = kezdonap;

            vegnap = (kezdonap + napokszama) - 1;
        }
    }
    class Foglalas
    {
        // Mezok
        public int sorszam, szobaszam, erkezes, tavozas, vendegek_szama;
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
}
