using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
    ===============
     Treść zadania:
    ===============
    Napisz metode ktora obliczy potege liczby podanej przez uzytkownika. 
    Jesli potega bedzie  wieksza niz 30 to wypisze na ekran "Duza ta liczba".
    Jesli mniejsza to wypisze "Co tak malo?"
    */

namespace potega
{
    class Program
    {
        public static void PoliczPotege()
        {
            Console.WriteLine("Podaj liczbe: ");
            int potega = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do której potęgi ją podnieść?");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int wynik = 1;

            // liczymy potege iteracyjnie
            for(int i = 0; i < liczba; i++)
            {
                wynik = wynik * potega;
            }

            Console.WriteLine("Wynik = " + wynik);

            // wywołujemy metodę sprawdzającą czy liczba jest większa niż 30, czy mniejsza-równa
            SprawdzWynik(wynik);
        }

        public static void SprawdzWynik(int wartosc)
        {
            // instrukcje warunkowe mamy jednoliniowe zatem możemy zapisać je
            // bez klamerek
            if (wartosc > 30) Console.WriteLine("Duza ta liczba");
            else if (wartosc <= 30) Console.WriteLine("Co tak malo?");
        }

        static void Main(string[] args)
        {
            // wywołujemy metodę statyczną
            PoliczPotege();

            Console.ReadLine();
        }
    }
}
