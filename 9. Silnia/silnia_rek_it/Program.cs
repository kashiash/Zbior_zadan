using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * pamiętasz - np. 3 silnia to ile??? ->  1*2*3 albo jak inni wolą 3*2*1

    Treść zadania:
    Napisz w klasie silnia dwie metody, które będą nazywać się: silnia_rekurencyjnie, silnia_iteracyjnie. Program
    ma się zapytać w pierwszej kolejności użytkownika jak woli policzyć silnię czy rekurencyjnie czy iteracyjnie.
    W zależności od wyboru program liczy silnię korzystając ze sposobu, który wybrał użytkownik. 

    przykładowy wynik programu:
    Program: Witaj! Jak chcesz policzyć silnię? 
    Program: wpisz 'rekurencyjnie' 
    Program: lub
    Program: wpisz 'iteracyjnie'
    Uzytkownik: iteracyjnie
    <program uaktywnia metodę silnia_iteracyjnie>
    Program: Silnię jakiej liczby chcesz policzyć?
    itd....

    Utrwalisz sobie:
    - Co to jest silnia?
    - Jak liczymy silnię iteracyjnie a jak rekurencyjnie?
    - Jak implementujemy silnie do programu?
    - Co to jest klasa, metoda?
    - Co to jest instrukcja warunkowa? Jak z niej korzystać? Jak działa?
    - Jakie wyróżniamy pętle? 

    #! Podpowiedzi:

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

    przykładowe działanie rekurencyjne:
    podajemy że chcemy podniesc 2(x) do potegi 3(n) to wtedy twoja funkcja powinna zadzialac tak:
    2 * rekurencja(2,3-1)
    2 * 2 * rekurencja(2,2-1)
    2 * 2 * 2 * rekurencja(2,1-1)
    i musimy dodac warunek w funkcji na poczatku że if (n == 0 ) zwroc np. 1 bo jak pomnozymy przez 1 
    to nie zmieni to wyniku prawda? Wiec ostatecznie bedzie tak:
    2 * 2 * 2 * 1 = 8 - dziala :0 :)

    w razie gdyby byly nadal z tym problemy zerknij na rozwiazanie tutaj:
    https://github.com/trolit/Programowanie/blob/master/potega_rekurencyjnie/potega_rekurencyjnie.cpp

*/
namespace silnia_rek_it
{
    class Silnia
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 

            Console.ReadLine();
        }
    }
}
