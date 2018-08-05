using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    ==============================================
                    Treść zadania:
    ==============================================
    1. Stwórz klasę wybór.
    2. Stwórz w niej konstruktor domyślny, który będzie publiczny.
    3. Stwórz metodę decyzja, która przyjmie jeden argument (czyli wybór użytkownika). 
       A więc może to wyglądać np. tak: public int Decyzja(int wybor)
       Twoja metoda ma zawierać instrukcję switch, której pseudokod jest następujący:

    switch(wybor)
    {
        case 1:
        wypisuje na ekran 'Wybrales opcje 1'
        break;

        case 2:
        wypisje na ekran 'Wybrales opcje 2'
        break;

        case 3:
        wypisuje na ekran 'Wybrales opcje 3'
        break;

        case 4:
        wypisuje na ekran 'Wybrales opcje 4'
        break;

        default:
        wypisuje na ekran 'Nic nie wybrales'
        break;
    }

    =======================
            Wniosek:
    =======================
    Widzisz, poszczególne case oznaczają 'opcje'. W zależności co będzie pod zmienną wybor aktywuje się odpowiednia
    gałąź bloku switch(wybor), np. powiedzmy wybor = 3, to switch przejdzie do case 3. Zapamietaj, że switch działa tylko i 
    wyłącznie dla zmiennych, które są liczbami lub pojedynczymi znakami (czyli char)! Czyli wybor NIE MOŻE być tutaj
    typu string! Po każdym 'case' zauważ, że jest instrukcja break. Co ona robi? Odpowiedź jest prosta: zapobiega
    aby case'y poniżej tego, który użytkownik wybierze nie wykonały się. Bo widzisz, gdybyś nie dała 
    (załóżmy w tym przykładzie) breaka po każdym case, a użytkownik wybierze opcje 1 to na ekran pokaże się wszystko
    czyli: 

    Wybrales opcje 1 
    Wybrales opcje 2
    Wybrales opcje 3
    NIc nie wybrales

    Najlepiej jak napiszesz już cały program i sprawdzisz to samemu usuwając break z każdego case i uruchamiając program. 
    Wtedy utrwalisz sobie w praktyce po co nam w switch taka instrukcja break. 

    Wiadomo, że w praktyce lepiej to się zapamięta niż w teorii, która niejako musiała być wstępem do tego.
    no i PS: default znaczy domyślny blok, wykona się jeśli nic z opcji powyżej nie pasowało do "caseów".

    4. Stwórz obiekt za pomocą, którego będziesz mógł dostać się do metody.
    lub uczyń swoją metodę statyczną. 
    5. Zapytaj w głównej części bloku użytkownika, którą opcję chce wybrać (1, 2, 3 lub 4 ?)
    6. Wywołaj metodę decyzja, która przyjmuje argument wybór!
    7. Sprawdź czy działa.

    8*. Jeżeli działa tak jak trzeba, sprawdź teraz co się stanie gdy usuniesz breaki z caseów w switchu.
        (o ile wcześniej tego nie zrobiłeś)
*/

namespace switch_1
{
    class Wybor
    {
        public Wybor() { }

        public static void Decyzja(int wybor)
        {
            switch(wybor)
            {
                case 1:
                    Console.WriteLine("Wybrales opcje1");
                    break;
                case 2:
                    Console.WriteLine("Wybrales opcje2");
                    break;
                case 3:
                    Console.WriteLine("Wybrales opcje3");
                    break;
                case 4:
                    Console.WriteLine("Wybrales opcje4");
                    break;
                default:
                    Console.WriteLine("nic nie wybrano");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe (najlepiej od 1 - 4)");
            int decyzja = Convert.ToInt32(Console.ReadLine());
            Wybor.Decyzja(decyzja);
            Console.ReadKey();
        }
    }
}
