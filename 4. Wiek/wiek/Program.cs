using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Napisz metode w klasie wiek ktora policzy wiek uzytkownika. 
    Zapytaj go o date urodzenia a nastepnie program ma zapytac "Masz x lat. Dobrze mowie?". 
    Jesli uzytkownik napisze tak to napisze na ekran "Jeeej zgadlem!" jesli uzytkownik napisze
    nie to na ekranie pokaze sie "A niech to...".

    Dodatkowe zadanie: Stwórz konstruktor domyślny. Zadeklaruj go jawnie.
                                 => (jawnie oznacza, że ma być publiczny)
    
    ?: uwaga,podpowiedz:
    Aby pobrac dzisiejsza date skorzystaj z funkcji DateTime.Now

    ?: przykladowo:
    rok mozemy zapisac tak: 
    double rok = DateTime.Now.Year;
    
    ----------------
          uwaga:
    ----------------
    DateTime.Now jest typu DateTime wiec nie mozemy go wrzucic do odejmowania od tak..
    i w dodatku DateTime.Now przechowuje nie tylko rok, ale i miesiac, dzien, godziny, minuty 
    itd... Zatem musimy wyciagnac tylko rok tak jak to pokazano w przykladzie i zapisalismy
    wynik tego polecenia do zmiennej typu double bo chcemy potem odjąć od niej rok urodzenia
    osoby X, wiec potrzebujemy roku jako liczby a nie jako lancucha bo moglibysmy rownie 
    dobrze pobrac rok z DateTime.Now jako tekst. 

    W razie, jeśli nadal nie wiesz jak to wykonać, zerknij do bloku "main" i zobacz przykład.

    ===============================================================================================
    Do tego zadania utrwalisz sobie:
    - jak przypisac wynik liczenia do zmiennej odrazu?
    - jak stworzyć metodę?
    - zastanów się jaki typ danych będzie zwracać funkcja oblicz wiek? Czy musi w ogóle coś zwracać?
    - jak pobrać od użytkownika rok który poda?
    - jak korzystać z instrukcji warunkowych? Jak są zbudowane?
    - jak stworzyć klasę? 
    ===============================================================================================

    */

namespace wiek
{
    // tu deklaruj klase

    class Program
    {
        static void Main(string[] args)
        {
            // tu stworz obiekt klasy

            // przykładowe obliczenie wieku dla osoby urodzoenj w 1990
            double rok = DateTime.Now.Year;
            double wiek = rok - 1990;
            Console.Write(wiek);

            Console.ReadLine();
        }
    }
}
