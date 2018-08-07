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
