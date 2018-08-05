using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uwaga:
 * jeżeli nie pamiętasz jak działa pętla for odsyłam Cię do zadania 5 gdzie przy okazji tablic
 * zostały omówione też pętle  :) 
 
    ==================================
              Treść zadania:
    ==================================

    Stwórz klasę Pętle, w której stworzysz metody for_operacyjne, wypisz_poz, wypisz_neg. Metoda for_operacyjne czeka 
    na liczbę od użytkownika, a następnie na starcie przemnaża ją przez 2,    
    jeśli wynik mnożenie będzie większy niż 30 lub reszta z dzielenia tej liczby będzie wynosiła 0 ma wywołać się
    funkcja wypisz_poz. W przeciwnym wypadku wywołana zostanie metoda  wypisz_neg i zakończy się działanie programu.
    Maksymalna wartość liczby przemnożonej nie może być większa niż 250! Pętla for co obrót zwiększa wartość liczby *2
    Dla poćwiczenia i utrwalnia wiadomości, zapisz publiczy konstruktor domyślny tej klasy.
    
    pseudokod metody wypisz_poz:
    wypisz_poz() 
    {
        wypisz na ekran 'Znaleziono dopasowanie liczby!'
    }

    pseudokod metody wypisz_neg:
    wypisz_neg(int indeks)
    {
        wypisz na ekran 'ERROR' 
    }

    =========================
           Wskazówki:
    =========================
    - zastanów się która metoda może być pusta, a która nie?
    - żeby metoda wypisz_neg wypisała indeks na którym metoda for_operacyjne wykryła błąd musimy pobrać indeks z pętli for
    nazwiemy go "indeks" zamiast i jak to zwykle mamy w zwyczaju nazywać indeks.

    ==================================================
             Utrwalisz sobie dzięki poleceniu:
    ==================================================
    - Do czego służy break? Co to jest? Gdzie możemy użyć break?
    - Czy wywołanie metody w metodzie jest dozwolone?
    - Jak stworzyć metodę, klasę?
    - Jak stworzyć obiekt?
    - Jak działa pętla for?
    - Czy w pętli for możemy umieszczać instrukcje warunkowe? Jeśli tak to jak one działają?
    - Jak działają deklaracje w pętli np. x = 100? 

        for(g = 0; g < 100; g++)
        {
         x = 100;
        ....
         }

*/
namespace for1
{
    class Petle
    {
        // publiczny konstruktor domyślny
        public Petle() { }

        public void ForOperacyjne(int liczba)
        {
            for (liczba *= 2; liczba <= 250; liczba *= 2)
            {
                if(liczba >= 30 || liczba % 2 == 0)
                {
                    WypiszPoz();
                    Console.WriteLine("Podaj kolejna liczbe: ");
                    liczba = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    WypiszNeg();
                    break;
                }
            }
        }

        private void WypiszPoz()
        {
            Console.WriteLine("Znaleziono dopasowanie liczby!");
        }

        private void WypiszNeg()
        {
            Console.WriteLine("BLAD!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzenie obiektu
            Petle obiekt = new Petle();

            Console.WriteLine("Podaj liczbe:");
            // konwersja podanego łańcucha do Int
            int liczba = Convert.ToInt32(Console.ReadLine());

            // wywołanie metody z klasy Petle
            obiekt.ForOperacyjne(liczba);


            // PS: spróbuj rozgryźć jak to się dzieje, że metoda WypiszNeg()
            // nie uruchamia się , a może się uruchomi dla jakiegoś określonego
            // zbioru liczb? Pozostawiam to do samodzielnego rozgryzienia.

            Console.ReadLine();
        }
    }
}
