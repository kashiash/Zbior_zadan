using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==================================
                Treść zadania:
    ==================================
    Napisz w klasie potega dwie metody, które będą nazywać się: potega_rekurencyjnie, potega_iteracyjnie. Program
    ma się zapytać w pierwszej kolejności użytkownika jak woli policzyć potege czy rekurencyjnie czy iteracyjnie.
    W zależności od wyboru program liczy potege korzystając ze sposobu, który wybrał użytkownik. 

    ==================================
        przykładowy wynik programu:
               (propozycja)
    ==================================
    Program: Witaj! Jak chcesz policzyć potege? 
    Program: wpisz 'rekurencyjnie' 
    Program: lub
    Program: wpisz 'iteracyjnie'
    Uzytkownik: iteracyjnie
    <program uaktywnia metodę potega_iteracyjnie>
    Program: Potege jakich liczb chcesz policzyć?
    itd....
*/
namespace potega_rek_ite
{
    class Potega
    {
        // w skrócie: mnozymy zmienna liczba przechowywaną w "wynik" tyle razy dopóki wykładnik nie jest 0 
        public static int PotegaRekurencyjnie(int liczba, int wykladnik, int wynik)
        {
            // jezeli wykladnik jest 0 to nie musimy
            // wiecej mnozyć - zatem zwróć wynik
            if(wykladnik == 0)
            {
                return wynik;
            }

            return wynik = wynik * liczba * PotegaRekurencyjnie(liczba, wykladnik - 1, wynik);
        }

        public static void PotegaIteracyjnie()
        {
            Console.WriteLine("Podaj liczbe: ");
            // musimy skonwertować wartość podaną przez użytkownika do inta
            int liczba = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik: ");
            int wykladnik = Convert.ToInt32(Console.ReadLine());

            // tu bedziemy przechowywac wynik
            int wynik = 1;

            // wykonujemy tyle razy petle for ile podano w wykladniku
            // np chcemy podniesc do 3 potegi, to petla wykona sie 3 razy itd
            for(; wykladnik > 0; wykladnik--)
            {
                wynik = wynik * liczba;
            }

            Console.WriteLine("\n\nWynik = " + wynik);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do liczenia potegi\n<wybierz jakim sposobem obliczyc potege>");
            Console.WriteLine("1. Iteracyjnie\n2. Rekurencyjnie");
            int decyzja = Convert.ToInt32(Console.ReadLine());

            if (decyzja == 1)
            {
                Potega.PotegaIteracyjnie();
            }
            else if (decyzja == 2)
            {
                Console.WriteLine("Podaj liczbe: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj wykładnik: ");
                int wykladnik = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nWynik = " + Potega.PotegaRekurencyjnie(liczba, wykladnik, 1));
            }
            else
            {
                Console.WriteLine("Blad!");
            }

            Console.ReadLine();
        }
    }
}
