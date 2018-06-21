using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uwaga:
 * jeżeli nie pamiętasz jak działa pętla for odsyłam Cię do zadania 5 gdzie przy okazji tablic
 * zostały omówione też pętle  :) 
 
    Treść zadania:
    Stwórz klasę pętle, w której stworzysz metody for_operacyjne, wypisz_poz, wypisz_neg. Metoda for_operacyjne czeka 
    na liczbę od użytkownika, a następnie ją przemnaża przez 2(co każdy obrót pętli oczywiście...), jeśli wynik mnożenia
    będzie większy niż 30 lub reszta z dzielenia tej liczby będzie wynosiła 0 ma wywołać się funkcja wypisz_poz.
    W przeciwnym wypadku wywołana zostanie metoda  wypisz_neg. Maksymalna wartość liczby przemnożonej nie może 
    być większa niż 250! Dla poćwiczenia, napisz publiczy konstruktor domyślny tej klasy.
    
    pseudokod metody wypisz_poz:
    wypisz_poz() 
    {
        wypisz na ekran 'Znaleziono dopasowanie liczby!'
    }

    pseudokod metody wypisz_neg:
    wypisz_neg(int indeks)
    {
        wypisz na ekran 'ERROR-[numer indeksu na którym pojawił się błąd]'
        break;  
    }

    Wskazówki:
    - zastanów się która metoda może być pusta, a która nie?
    - żeby metoda wypisz_neg wypisała indeks na którym metoda for_operacyjne wykryła błąd musimy pobrać indeks z pętli for
    nazwiemy go "indeks" zamiast i jak to zwykle mamy w zwyczaju nazywać indeks.

    Utrwalisz sobie dzięki poleceniu:
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
