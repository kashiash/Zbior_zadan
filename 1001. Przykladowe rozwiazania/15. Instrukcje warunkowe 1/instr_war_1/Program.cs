using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Instrukcje warunkowe są równie proste co pętle, poświęć im troszkę czasu :)
 * no i oczywiście bardzo przydatne... :) załapiesz je bez problemu!
 * pod zadaniem mini wstęp z instrukcji warunkowych więc możesz tam się zapoznać jak
 * masz ochotę. Miłej nauki!
 
    ====================================
                Treść zadania:
    ====================================
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
*/

namespace instr_war_1
{
    class Decyzje
    {
        // metoda statyczna dzieki czemu nie bedzimy musieli tworzyc obiektu
        // aby sie do niej odwolac
        public static void Porownywarka()
        {
            Console.WriteLine("Jaka wartość inwestycji(podaj cenę)? ");
            int cena = Convert.ToInt32(Console.ReadLine());

            if (cena < 25)
            {
                Console.WriteLine("Nie oplaca sie inwestowac!");
            }
            else if(cena > 25 && cena < 55)
            {
                Console.WriteLine("Inwestycja jest ryzykowna");
            }
            else if(cena > 100 && cena < 120)
            {
                Console.WriteLine("Warta przemyślenia");
            }
            else if(cena > 540 && cena < 590)
            {
                Console.WriteLine("Idealna propozycja");
            }
            else
            {
                Console.WriteLine("Nic ciekawego, nie warto inwestować");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // wywołujemy metode
            Decyzje.Porownywarka();

            Console.ReadLine();
        }
    }
}
