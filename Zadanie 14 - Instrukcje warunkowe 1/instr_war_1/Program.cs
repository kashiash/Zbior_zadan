using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Instrukcje warunkowe są równie proste co pętle, poświęć im troszkę czasu :)
 * no i oczywiście bardzo przydatne... :) i załapiesz - na 100% 
 * poniżej mini wstęp z instrukcji warunkowych więc możesz tam się zapoznać jak
 * masz ochotę
 
    Treść zadania:
    1. Stwórz klasę decyzje.
    2. Stwórz w niej metodę porownywarka. 
    3. Twoja metoda musi być zbudowana według następującego pseudokodu:
    - zastanów się czy Twoja metoda cokolwiek musi zwracać, czy musi mieć argumenty, a może dać jej typ void?

    PSEUDOKOD:

    zapytaj uzytkownika jaka wartosc inwestycji?
    pobierz cene

    jeśli cena < 25
    {
        wypisz na ekran 'Nie oplaca sie inwestowac.
    }
    lub jeśli cena > 25 i cena < 55
    {
        wypisz na ekran 'Inwestycja jest ryzykowna.
    }
    lub jeśli cena > 100 i cena < 120
    {
        wypisz na ekran 'Warto przemyslec ten pomysl'
    }
    lub jesli cena > 540 i cena < 590 
    {
        wypisz na ekran 'Idealna propozycja. Mozesz w to wejsc.
    }
    w przeciwnym wypadku
    {
        wypisz na ekran 'Nic ciekawego, nie warto nawet zwracac uwagi.
    }

    4. Wywołaj metodę porownywarka.

    Utrwalisz sobie dzięki powyższemu zadaniu:
    - Budowa, definicja, dzialanie instrukcji warunkowych.
    - Tworzenie metody, klasy, obiektu.
    - Co znaczy zwracanie wartosci z metody?
    - Co znaczy że metoda jest typu void? Jak wygląda?


    ################################### 
            krótko teoretycznie:
    ################################### 

    Konstrukcja if'a:
    if ( warunek )
    {
       instrukcje;
       instrukcje;
    }

    ewentualnie jeśli masz tylko jedną instrukcję to możesz śmiało napisać wersją skróconą:
    if ( warunek ) instrukcja;

    jeżeli masz więcej warunków to dajemy else if więc będziemy mieli:
    if ( warunek )
    {

    }
    else if ( warunek )
    {

    }
    else if (warunek ) 
    { 

    }
    ...itd

    komentarz:
    te else if'y możemy przetłumaczyć "a jeżeli poprzednie fałszywe to czy .... (i tu warunek) 
    Pamiętaj, że z tych wszystkich if..else if..else if...else if... tylko jeden się wykona!!!
    Załóżmy, że wykona się drugi else if ( warunek ) w powyższym szablonie to wtedy dalej nie 
    będą sprawdzane warunki, no bo nie ma największego sensu - logiczne prawda?:)

    a jeżeli chcesz dodać fragment który wykona się jeżeli żaden z warunków nie będzie prawdziwy to zastosujesz
    else, czyli mamy tak o:

    if ( warunek )
    {

    }
    else if ( warunek )
    {

    }
    else if (warunek ) 
    { 

    }
    else
    {
        Console.WriteLine("nic nie bylo prawdziwe");
    }


*/

namespace instr_war_1
{
    class Program
    {
        static void Main(string[] args)
        {



            // przykładowa "długa" instrukcja warunkowa (zawiera więcej niż 1 instrukcje)
            if (5 < 6)
            {
                Console.WriteLine("5");
                Console.WriteLine("jest wieksze");
                Console.WriteLine("od 6");
            }

            // przykładowa "krótka" instrukcja warunkowa
            if (3 < 5) Console.WriteLine("5");

            Console.ReadLine();
        }
    }
}
