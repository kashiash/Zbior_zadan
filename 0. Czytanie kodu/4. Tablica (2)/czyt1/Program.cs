using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        void Zwracaj(int[] tablica)
        // uwaga, dlaczego nie trzeba public dac? 
        {
            Console.WriteLine("Podaj numerek: ");
            int w = Convert.ToInt32(Console.ReadLine());
            // uwaga, dlaczego int a nie string?
            Console.WriteLine("Wylosowales: " + tablica[w]);
        }

        int[] Przerob(int[] tablica)
        {
            int max = tablica.Length;
            
            if(0 < max) tablica[0] = 2;
            if(1 < max) tablica[1] = 3;
            if(2 < max) tablica[2] = 5;
            if (3 < max) tablica[3] = 155;
            if (4 < max) tablica[4] = 299;
            // co zabezpiecza ten if?

            return tablica;
        }

        static void Main(string[] args)
        {
            // obiekt testy klasy Program
            Program testy = new Program();

            int[] totolotek = { 1, 2, 3, 4, 5, 6, 7, 8 };
            testy.Zwracaj(totolotek);

            // funkcja2
            int[] nowe = testy.Przerob(totolotek);
            Console.WriteLine(nowe[3]);
            Console.WriteLine(nowe[4]);

            Console.ReadLine();
        }
    }
}
