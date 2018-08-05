using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==========================================================================
                                Treść zadania:
    ==========================================================================
    Witaj! Złożone instrukcje if, nie są Ci już straszne, wiesz już na czym polega taki if, kiedy się wykonuje dany moment
    co to jest else itd... Wiesz, że if jest dla nas bardzo przyjemny bo możemy konstruować np. menu wyboru ze  
    względu na typ danych string? PEwnie.

    Przećwiczmy je jeszcze raz, a w następnym zadaniu z instrukcjami warunkowymi, zobaczysz jak dzięki nim 
    stworzyć interaktywne menu dla użytkownika. :) 

    Zadanie:
    1. Stwórz klasę Warunkowa  :) 

    2. Stwórz parametry(cechy):
    public string imie;
    public string nazwisko;
    public int ocena;

    3. Stwórz metodę Selekcja_uczniow(int ocena_studenta, string imie, string nazwisko)          

    Twoja metoda będzie wyglądała mniej więcej tak:

    jesli ocena_studenta jest rowna 1
    {
        wypisz na ekran 'Uczen (tu imie, nazwisko) nie zdal'
    }
    ale jesli ocena_studenta jest rowna 2
    {
        wypisz na ekran 'Uczen (tu imie, nazwisko) moze otrzymac wpis warunkowy'
    }
    ale jesli ocena_studenta jest rowna  3 lub rowna 4 lub rowna 5
    { 
        wypisz na ekran 'Uczen (tu imie, nazwisko) zdal.
    }
    w przeciwnym wypadku
    {
        wypisz na ekran 'Nieoczekiwany blad!'
    }

    4. Stwórz 3 obiekty, daj każdemu ocenę jaką uważasz.
       Stwórz czwarty obiekt, któremu za ocene dasz 0.

    5. Każdemu obiektowi wywołaj naszą metodę selekcja_uczniow(int ocena_studenta).

    6. Przetestuj działanie programu.
*/
namespace if_2
{
    class Warunkowa
    {
        public string imie;
        public string nazwisko;
        public int ocena;

        public void Selekcja_uczniow(int ocena_studenta, string imie, string nazwisko)
        {
            if(ocena_studenta == 1)
            {
                Console.WriteLine("Uczeń: " + imie + " " + nazwisko + " nie zdal");
            }
            else if(ocena_studenta == 2)
            {
                Console.WriteLine("Uczeń: " + imie + " " + nazwisko + " moze otrzymac wpis warunkowy");
            }
            else if(ocena_studenta == 3 || ocena_studenta == 4 || ocena_studenta == 5)
            {
                Console.WriteLine("Uczeń: " + imie + " " + nazwisko + " zdal");
            }
            else
            {
                Console.WriteLine("Blad!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // stwórzmy teraz obiekty za pomocą konstruktora domyślnego
            // i potem nadajmy im cechy
            Warunkowa Kowalencki = new Warunkowa();
            Warunkowa Anton = new Warunkowa();
            Warunkowa Czech = new Warunkowa();
            Warunkowa Gad = new Warunkowa();

            Kowalencki.imie = "Adam";
            Kowalencki.nazwisko = "Kowalencki";
            Kowalencki.ocena = 3;

            Anton.imie = "Piotr";
            Anton.nazwisko = "Anton";
            Anton.ocena = 4;

            Czech.imie = "Rafal";
            Czech.nazwisko = "Czech";
            Czech.ocena = 1;

            Gad.imie = "Gad";
            Gad.nazwisko = "Gad";
            Gad.ocena = 0;

            // wywołujemy metodę dla każdego z obiektów:
            // zróbmy to pętlą for na tablicy obiektów, 
            // żeby aż tyle nie pisać :D

            Warunkowa[] tablicaObiektow = { Kowalencki, Anton, Czech, Gad };

            for(int i = 0; i < tablicaObiektow.Length; i++)
            {
                tablicaObiektow[i].Selekcja_uczniow(tablicaObiektow[i].ocena, tablicaObiektow[i].imie, tablicaObiektow[i].nazwisko);
            }

            Console.ReadLine();
        }
    }
}
