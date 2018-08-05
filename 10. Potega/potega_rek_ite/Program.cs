using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==================================
                Treść zadania:
    ==================================
    Napisz w klasie potega dwie metody, które będą nazywać się: potega_rekurencyjnie, potega_iteracyjnie. Program
    ma się zapytać w pierwszej kolejności użytkownika jak woli policzyć potege czy rekurencyjnie czy iteracyjnie.
    W zależności od wyboru program liczy potege korzystając ze sposobu, który wybrał użytkownik. 

    ==================================
        przykładowy wynik programu:
               (propozycja)
    ==================================
    Program: Witaj! Jak chcesz policzyć potege? 
    Program: wpisz 'rekurencyjnie' 
    Program: lub
    Program: wpisz 'iteracyjnie'
    Uzytkownik: iteracyjnie
    <program uaktywnia metodę potega_iteracyjnie>
    Program: Potege jakich liczb chcesz policzyć?
    itd....

    ==================================
             Utrwalisz sobie:
    ==================================
    - Jak liczymy potege iteracyjnie a jak rekurencyjnie?
    - Jak implementujemy potege do programu?
    - Co to jest klasa, metoda?
    - Co to jest instrukcja warunkowa? Jak z niej korzystać? Jak działa?
    - Jakie wyróżniamy pętle? 
    - Co to jest rekurencja?
    - Czy rekurencja musi mieć jakiś warunek?

    ==================================
              #! Podpowiedzi:
    ==================================

    Potega iteracyjnie to musimy stworzyć pętlę np. for
    jak użytkownik poda że chce 2 do 3 podnieść to ta petla musi sie
    wykonac 3 razy i bedzie robic tak: 
    pierwszy obrót: 2*2 = 4
    drugi obrót: 4*2 = 8
    trzeci obrót: 8*2 = 16 
    i mamy :)

    Potega rekurencyjnie
    (rekurencyjnie czyli funkcja musi wywolywac sama siebie) 
    - musisz stworzyc funkcje ktora bedzie zwracac siebie sama
    np. return x * rekurencja(x, n-1)
    x to podstawa
    n to wykladnik

    =====================================
     przykładowe działanie rekurencyjne:
    =====================================
    podajemy że chcemy podniesc 2(x) do potegi 3(n) to wtedy twoja funkcja powinna zadzialac tak:
    2 * rekurencja(2,3-1)
    2 * 2 * rekurencja(2,2-1)
    2 * 2 * 2 * rekurencja(2,1-1)
    i musimy dodac warunek w funkcji na poczatku że if (n == 0 ) zwroc np. 1 bo jak pomnozymy przez 1 
    to nie zmieni to wyniku prawda? Wiec ostatecznie bedzie tak:
    2 * 2 * 2 * 1 = 8 - dziala :0 :)
*/
namespace potega_rek_ite
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
