using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ======================================
                Treść zadania:
    ======================================
    1. Stwórz klasę Testowanie
    2. Stwórz metodę Zagniezdzanie()   
    3. W metodzie Zagnieżdzanie stwórz kod o następującym:

    zadeklaruj zmienna typu calkowitego ktora bedzie pokazywala ktore dzien dobry sie wypisuje
    np. powitanie
    int powitanie = 0;

    for(x = 0; x < 10; x++)
    {
        wypisuje na ekran 'Dzien dobry'
        zwieksza powitanie o 1
            
            for(y = 0; y < 6; y++)
            {
                    if(y % 2 == 0)
                    {
                        wypisuje na ekran 'Huraaa!'
                    }
            }      
     }

    4. Stwórz obiekt i wywołaj metody. Spróbuj rozgryźć jak działa ta pętla zagnieżdzona. Wyobraź sobie że jesteś
    kompilatorem i przejdź po kolei kroki jak on po tych pętlach. Zobaczymy wtedy czy dobrze rozumiesz pętle for
    w pętli for. :) 

    5. Jeśli już Ci się udało ogarnąć powyższy kod i wiesz co się dzieje, to znaczy kiedy dana komenda ma swoją
    kolej... to spróbuj napisać swoją jakąś pętlę zagnieżdzoną. Poćwicz aby sobie utrwalić jak taką pętlę zagnieżdzoną
    się tworzy. Wymyśl coś może ;) Tak jakoś tam pogłówkuj. A potem jak coś wymyślisz i napiszesz to przetestuj
    a następnie sobie wytłumacz jak działa twój kod, to znaczy: linijka po linijce idź po kodzie i mów sobie
    co się dzieje w danej chwili. :) Tak aby sobie to utrwalić.
*/
namespace zagniezdzona_for
{
    class Testowanie
    {
        public void Zagniezdzanie()
        {
            int powitanie = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Dzien dobry nr." + powitanie);
                powitanie++;

                for (int y = 0; y < 6; y++)
                {
                    if (y % 2 == 0)
                    {
                        Console.WriteLine("Huraaa");
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzenie obiektu
            Testowanie obiekt = new Testowanie();

            // wywołanie metody Zagniezdzanie
            obiekt.Zagniezdzanie();

            Console.ReadLine();
        }
    }
}
