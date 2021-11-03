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
            int dex = adatok.Count - 1;
            //2. feladat
            Console.WriteLine("2. Feladat");
            while (adatok[dex].beki != 0)
                dex--;
            Console.WriteLine("{0}. nap rendszám: {1}", adatok[dex].nap, adatok[dex].rendszam);
            //3. feladat
            Console.WriteLine("3. Feladat");
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
            // Adja meg, hogy hány autó nem volt bent a hónap végén a parkolóban!
            Console.WriteLine("4. Feladat");
            int lopott = 0;
            for (dex = 0; dex < adatok.Count; dex++)
            {
                if (adatok[dex].beki == 0)
                    lopott++;
                else
                    lopott--;
            }

            Console.WriteLine("A hónap végén {0} autót nem hoztak vissza.", lopott);


            //5. Feladat
            //Készítsen statisztikát, és írja ki a képernyőre mind a 10 autó esetén az ebben a hónapban
            //megtett távolságot kilométerben! A hónap végén még kint lévő autók esetén az utolsó
            //rögzített kilométerállással számoljon! A kiírásban az autók sorrendje tetszőleges lehet.
            Console.WriteLine("5. Feladat");
            int indi = 0;
            int tav = 0;
            string ipse;
            int maxidex = 0;
            int ex;
            string sanyi;



            ex = 0;
            dex = adatok.Count-1;
            while (adatok[ex].rendszam != "CEG300")
                ex++;
            while (adatok[dex].rendszam != "CEG300")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;
            
            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG301")
                ex++;
            while (adatok[dex].rendszam != "CEG301")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG302")
                ex++;
            while (adatok[dex].rendszam != "CEG302")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG303")
                ex++;
            while (adatok[dex].rendszam != "CEG303")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG304")
                ex++;
            while (adatok[dex].rendszam != "CEG304")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG305")
                ex++;
            while (adatok[dex].rendszam != "CEG305")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG306")
                ex++;
            while (adatok[dex].rendszam != "CEG306")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG307")
                ex++;
            while (adatok[dex].rendszam != "CEG307")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG308")
                ex++;
            while (adatok[dex].rendszam != "CEG308")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            ex = 0;
            dex = adatok.Count - 1;
            while (adatok[ex].rendszam != "CEG309")
                ex++;
            while (adatok[dex].rendszam != "CEG309")
                dex--;
            tav = adatok[dex].km - adatok[ex].km;

            Console.WriteLine("{0} {1} km", adatok[dex].rendszam, tav);

            //6. Feladat
            //Határozza meg, melyik személy volt az, aki az autó egy elvitele alatt a leghosszabb
            //távolságot tette meg! A személy azonosítóját és a megtett kilométert a minta szerint írja a
            //képernyőre!(Több legnagyobb érték esetén bármelyiket kiírhatja.)
            Console.WriteLine("6. Feladat");
            int maxitav = 0;
            int aktualtav = 0;

            for (dex=0; dex<adatok.Count; dex++)
            {
                if (dex < adatok.Count - 1)
                    ex = dex + 1;
                else
                    ex = dex;
                while (ex < adatok.Count-1 && adatok[dex].id != adatok[ex].id)
                {
                    ex++;
                }
                if ( adatok[ex].beki == 1 && adatok[dex].id == adatok[ex].id)
                {

                aktualtav = adatok[ex].km - adatok[dex].km;
                    if ( aktualtav > maxitav)
                {

                    maxitav = aktualtav;
                    maxidex = ex;
                }
                }
            }


            Console.WriteLine("Leghosszabb út: {0} km, személy: {1}", maxitav, adatok[maxidex].id);


        }
    }
}
