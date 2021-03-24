using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dolgozat_1
{
    class Program
    {        
        //Első Feladat
        static int[] tomb = new int[100];

        // Második Feladat
        public static void RandomTombGeneralas()
        {   
            int min = 1000;
            int max = 9999;

            for(int i = 0; i < 100; i++)
            {
                Random rdm = new Random();
                int rand = rdm.Next(min, max);
                while(rand % 5 != 0){
                    rand = rdm.Next(min, max);
                }
                tomb[i] = rand;
                //Console.WriteLine(tomb[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Reka Dolgozata:");
            RandomTombGeneralas();
            TombKiiras();
            TombSzinesKiiras();
            TombElemekOsszege();
            TombElemekAtlaga();
            HatvanOtTobbszoros();
            HarmassalKezdodo();
            JuniorOraber();
            KerekSzazasok();
            SzuletesiIdo();
        }

        // Harmadik Feladat
        public static void TombKiiras()
        {
            Console.WriteLine();
            Console.WriteLine("Harmadik Feladat:");
            for(int i = 0; i < 100; i=i+10)
            {
                for(int j = i; j < i+10; j++)
                {
                    Console.Write(tomb[j] + " ");
                    //Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        // Negyedik Feladat
        public static void TombSzinesKiiras()
        {
            Console.WriteLine();
            Console.WriteLine("Negyedik Feladat:");
            for(int i = 0; i < 100; i=i+10)
            {
                for(int j = i; j < i+10; j++)
                {
                    if((j+1) % 7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tomb[j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }else{
                        Console.Write(tomb[j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Ötödik Feladat
        public static void TombElemekOsszege()
        {
            Console.WriteLine();
            Console.WriteLine("Ötödik Feladat:");
            Console.WriteLine(tomb.Sum());
        }

        // Hatodik Feladat
        public static void TombElemekAtlaga()
        {
            Console.WriteLine();
            Console.WriteLine("Hatodik Feladat:");
            
            int osszeg = 0;
            int darab = 0;

            for(int i = 0; i < 100; i++)
            {
                if(tomb[i] < 5000 && tomb[i] >= 4000)
                {
                    //Console.WriteLine(tomb[i] + " ");
                    osszeg = osszeg + tomb[i];
                    darab++;
                }
            }
            double atlag = osszeg/darab;
            Console.WriteLine(atlag);
        }

        // Hetedik Feladat
        public static void HatvanOtTobbszoros()
        {   
            Console.WriteLine();
            Console.WriteLine("Hetedik Feladat:");
            int i = 0;
            while(i < tomb.Length && tomb[i] % 65 != 0)
            {
                i++;
            }
             Console.WriteLine("Az első 65 többszöröse: " + tomb[i]);
             Console.WriteLine("Az indexe: " + Array.IndexOf(tomb, tomb[i]));
        }

        // Nyolcadik Feladat
        public static void HarmassalKezdodo()
        {
            Console.WriteLine();
            Console.WriteLine("Nyolcadik Feladat:");

            int darab = 0;
            for(int i = 0; i < 100; i++)
            {
                if(tomb[i] >= 3000 && tomb[i] < 4000)
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab} db 3-massal kezdodo van");
        }

        // Kilencedik Feladat
        public static void JuniorOraber(){
            Console.WriteLine();
            Console.WriteLine("Kilencedik Feladat:");

            // Brutto 3800 Forint per óra elfogadható
            int i = 0;
            while(i < tomb.Length && tomb[i] < 3800) 
            {
                i++;
            }
            Console.WriteLine("Elfogadhato junior brutto órabér indexe: " + Array.IndexOf(tomb, tomb[i]));
        }

        // Tizedik és Tizenegyedik Feladat
        public static void KerekSzazasok()
        {
            Console.WriteLine();
            Console.WriteLine("Tizedik és Tizenegyedik Feladat:");

            int[] szazasTomb = new int[100];
            int hely = 0;

            for(int i = 0; i < 100; i++)
            {
                if(tomb[i] % 100 == 0)
                {
                    szazasTomb[hely] = tomb[i];
                    
                    if(tomb[i] % 1100 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(szazasTomb[hely]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(szazasTomb[hely]);
                        Console.WriteLine();
                    }
                    
                    hely++;
                }
            }
        }

        // Tizenkettedik Feladat
        public static void SzuletesiIdo()
        {
            Console.WriteLine();
            Console.WriteLine("Tizenkettedik Feladat:");
            int szuletesiIdo = 1995;
            Console.WriteLine($"Szerepel a {szuletesiIdo} a tömbben? Válasz: " + tomb.Contains(szuletesiIdo));
        }
    }
}
