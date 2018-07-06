using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // obiekt testy klasy Program
            Program testy = new Program();

            // proste tablice
            
            int[] tablica = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Troche informacji: ");
            Console.WriteLine("Tablica = " + tablica.Length);
            Console.WriteLine("Szczesliwy numer to: " + tablica[3]);

            Console.WriteLine("tu jest" + (tablica[3] - 2 + 1));  // wyswietli = 
            Console.WriteLine("tu jest" + tablica[2]);            // wyswietli = 
            tablica[2] = 5;
            Console.WriteLine("tu jest" + tablica[2]);            // wyswietli = 
            Console.WriteLine("tu jest" + (tablica[3] - 2 + 1));  // wyswietli = 

            string[] paczka = new string[5];    // jaki ma rozmiar tablica "paczka"? 5 czy 6?
            paczka[2] = "truskawka";
            paczka[3] = "jablko";
            Console.WriteLine("Pod numerem 3 kryje sie... " + paczka[4]);

            string tekst = paczka[2];
            Console.WriteLine(tekst);    // wyswietli = 

            int war = paczka.Length;
            Console.WriteLine(war - 1);  // wyswietli =
        
            Console.ReadLine();
        }
    }
}
