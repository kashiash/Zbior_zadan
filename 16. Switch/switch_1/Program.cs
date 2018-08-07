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
       A więc może to wyglądać np. tak: public int decyzja(int wybor)
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
    Po każdym 'case' zauważ, że jest instrukcja break. Co ona robi? Odpowiedź jest prosta: zapobiega
    aby case'y poniżej tego, który użytkownik wybierze nie wykonały się. Bo widzisz, gdybyś nie dał(a) 
    (załóżmy w tym przykładzie) breaka po każdym case, a użytkownik wybierze opcje 1 to na ekran pokaże się wszystko
    czyli: 

    Wybrales opcje 1 
    Wybrales opcje 2
    Wybrales opcje 3
    Nic nie wybrales

    Najlepiej jak napiszesz już cały program i sprawdzisz to samemu usuwając break z każdego case i uruchamiając program. 
    Wtedy utrwalisz sobie w praktyce po co nam w switch taka instrukcja break. 

    Wiadomo, że w praktyce lepiej to się zapamięta niż w teorii, która niejako musiała być wstępem do tego.
    no i PS: default znaczy domyślny blok, wykona się jeśli nic z opcji powyżej nie pasowało do "caseów".

    4. Stwórz obiekt za pomocą, którego będziesz mógł dostać się do metody lub uczyń 
       ją metodą statyczną!
    5. Zapytaj w głównej części bloku użytkownika, którą opcję chce wybrać (1, 2, 3 lub 4 ?)
    6. Wywołaj metodę decyzja, która przyjmuje argument wybór!
    7. Sprawdź czy działa.

    8*. Jeżeli działa tak jak trzeba, sprawdź teraz co się stanie gdy usuniesz breaki z caseów w switchu.
        (o ile wcześniej tego nie zrobiłeś)
*/

namespace switch_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
