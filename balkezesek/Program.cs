using balkezesek;
using System;
using System.Text.Json.Nodes;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<BAlkezes> jatekosok = new List<BAlkezes>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("balkezesek.csv");
            jatekosok.Skip(1);
            while (!sr.EndOfStream)
            {
                string[] tomb = sr.ReadLine().Split(';');
            }
            sr.Close();

            Console.WriteLine($"3. feladat: {jatekosok.Count()}");

            Console.WriteLine(jatekosok[4]);

            /*
            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérek egy 1990 és 1999 közötti évszámot!: ");
            int beirtAdat = Convert.ToInt32(Console.ReadLine());
            int seged = 0;
            do
            {

                Console.WriteLine("Hibás adat! Kérek egy 1990 és 1999 közötti ávszámot!: ");
                seged = Convert.ToInt32(Console.ReadLine());
                beirtAdat = seged;
            } while (beirtAdat <1990 ||beirtAdat >1999);
            */
        }
    }
}