using System;
using System.Collections.Generic;
using System.IO;

namespace cegesauto
{
    class autooo
    {
        public int nap;
        public string oraperc;
        public string rendszam;
        public int id;
        public int km;
        public int beki;
        public int marad;
    }
    class Program
    {

        static List<autooo> adatok = new List<autooo>();

        static void beolvas()
        {
            StreamReader sr = new StreamReader("autok.txt");
            int marad = 0;
            string egysor;
            while ((egysor = sr.ReadLine()) != null)
            {
                string[] egysordarabok = egysor.Split(' ');
                autooo egyadat = new autooo();

                egyadat.nap = Convert.ToInt32(egysordarabok[0]);
                egyadat.oraperc = egysordarabok[1];
                egyadat.rendszam = egysordarabok[2];
                egyadat.id = Convert.ToInt32(egysordarabok[3]);
                egyadat.km = Convert.ToInt32(egysordarabok[4]);
                egyadat.beki = Convert.ToInt32(egysordarabok[5]);
                if (egyadat.beki == 1)
                    marad++;
                else
                    marad--;
                egyadat.marad = marad;
                adatok.Add(egyadat);
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            beolvas();
            //1. feladat
            Console.WriteLine("Beolvasott rekordok száma: {0}", adatok.Count);
            int dex = adatok.Count-1;
            //2. feladat
            Console.WriteLine("2. feladat");
            while (adatok[dex].beki != 0)
                    dex--;
            Console.WriteLine("{0}. nap rendszám: {1}", adatok[dex].nap, adatok[dex].rendszam);
            //3. feladat
            Console.WriteLine("3. feladat");
            Console.Write("Nap: ");
            int sussfelnap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Forgalom a(z) {0}. napon:", sussfelnap);
            for (dex = 0; dex < adatok.Count; dex++)
                if (adatok[dex].nap == sussfelnap)
                {
                    Console.Write("{0} {1} {2} ", adatok[dex].oraperc, adatok[dex].rendszam, adatok[dex].id);
                    if (adatok[dex].beki == 1)
                        Console.WriteLine("be");
                    else
                        Console.WriteLine("ki");

                }
            //4. Feladat


        }
    }
}
