using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 ---------------------------------------------------
 Komentarz do omówienia:
 Omowienie nie zawiera objasnien a jedynie przyklady 
 i schemat wedlug ktorego powinno sie przeanalizowac 
 zaproponowany temat.
 ---------------------------------------------------




////////////////////////////////////////////////////////////////
****************************************************************
                            TEMAT:
        Funkcje, petle, instrukcje warunkowe, tablice 
****************************************************************

    1. Funkcje(Metody)
        -> co to funkcja/metoda
        -> budowa funkcji
        -> zadanie funkcji(po co nam funkcje?)
        -> przykladowe funkcje
        -> co w funkcji mozemy umieszczac?
    2. Tablice
        -> co to tablica
        -> deklaracja tablic
        -> zadania tablic
        -> przykladowe tablice
    3. Instrukcje warunkowe
        -> czym jest?
        -> zastosowanie
    4. Petle
        -> czym sa? 
        -> petle nieskoczone(do menu np.)
        -> zastosowanie
    5. Kombinacje 
        -> np. Funkcja+Petla+Instrukcja warunkowa
        -> np. Petla+Instrukcje warunkowe
*/

namespace omowienie_1
{
    class Program
    {
        // przyklad0
        // budowa funkcji:
        /*
        modyfikator_dostepu zwracany_typ(lub nic nie zwraca to void) nazwafunkcji (argumenty lub brak)
            {
                instrukcje;
                instrukcje;
                ....
            }
        
        -> funkcja skupia się na jednej odpowiedzialności np. Obsługa ruchu, resetowanie zmiennych itd itp.
        -> można wywołać kiedy potrzeba
        -> nie musimy duplikować tego samego kodu - wystarczy kolejne wywołanie
        -> schludniejszy kodzik
        -> intuicyjne działanie
        */

        // przyklad
        // funkcja pusta(void)
        private void Odkurz()
        {
            Console.WriteLine("Odkurzam pokoj...");
        }

        // przyklad
        // funkcja zwracajaca napis
        private string Pozmywaj()
        {
            return "Pozmywane naczynia";
        }

        // przyklad
        // funkcja zwracajaca 
        private int Pokazliczbe()
        {
            // komentujac return dostaniemy error
            return 1;
        }

        // przyklad
        // funkcja zwracajaca liczbe calkowita
        private int Rozmiarbuta()
        {
            Console.WriteLine("Podaj rozmiar buta: ");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            return rozmiar;
        }

        // przyklad
        // funkcja zwracajaca napis wykorzystujac argument
        private string przepisz(string tekst)
        {
            return tekst;
        }

        // przyklad
        // funkcja zwracajaca tablice liczb calkowitych
        private int[] ZwracamTablice(int[] tablica)
        {
            return tablica;
        }


        static void Main(string[] args)
        {
            // tworzenie obiektu:
            Program testy = new Program();

            // wywolanie funkcji za pomoca obiektu
            testy.Odkurz();

            // przejecie zwracanej wartosci przez funkcje
        }
    }
}
