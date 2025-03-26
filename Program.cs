using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StrandC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Furdo> furdok = BeolvasStrandAdatok("strandadatok.txt");

            // 7. feladat
            Console.WriteLine("7. feladat:");
            Console.WriteLine($"Fürdők száma: {furdok.Count}");

            // 8. feladat
            Console.WriteLine("8. feladat");
            double atlagAr = furdok.Average(f => f.Ar);
            Console.WriteLine($"A fürdőbelépők átlagos ára: {atlagAr:F1}");

            // 9. feladat
            Console.WriteLine("9. feladat");
            Furdo leghidegebb = furdok.OrderBy(f => f.Vizhofok).First();
            Console.WriteLine($"A leghidegebb víz a(z) {leghidegebb.Nev} nevű fürdőben van.");

            // 10. feladat
            Console.WriteLine("10. feladat");
            Console.Write("Kérem, adja meg a fürdő nevét!\n");
            string keresettNev = Console.ReadLine();


            Furdo keresettFurdo = furdok.FirstOrDefault(f => f.Nev == keresettNev);
            if (keresettFurdo != null)
            {
                Console.WriteLine($"A fürdő {keresettFurdo.Telepules()} településen van, az irányítószám: {keresettFurdo.IRSZ()}");
            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű fürdő!");
            }

            Console.ReadKey();
        }

        static List<Furdo> BeolvasStrandAdatok(string fajlnev)
        {
            List<Furdo> furdok = new List<Furdo>();
            string[] sorok = File.ReadAllLines(fajlnev);
            for (int i = 1; i < sorok.Length; i++) // Fejléc kihagyása
            {
                furdok.Add(new Furdo(sorok[i]));
            }
            return furdok;
        }

    }
}