using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A teraz... alternatywa do nieskonczonej petli while :) czyli nieskoczona petla for :)

    ==================================
              Treść zadania:
    ==================================
    Wiesz już jak tworzymy nieskończoną pętlę while. Przypomnę że, wystarczyło albo zapisać warunek który zawsze
    będzie spełniony, bądź po prostu w nawiasie zapisać słowo true. Jak się domyślasz
    (a może nie), w pętli do while wykorzystanie jednej z dwóch powyższych metod również da nam pętlę
    nieskończoną! Proste? Mam nadzieję :).

    na wszelki wypadek, przypomnę Ci, że pętla nieskończona to taka, która będzie zawsze prawdziwa, a co
    za tym idzie będzie cały czas się wykonywać. 

    ====================================================================
                  A jak stworzyć pętlę nieskończoną for???
    ====================================================================
    Odpowiedź jest banalna, wystarczy
    spełnić dwa następujące warunki. 

    1) warunek pętli for jest prawdziwy abyśmy weszli do środka bloku pętli for
    2) zwiększanie/zmniejszanie będzie puste

    ==================================
              Zapamiętaj je!
    ==================================

    przykładowo:

    for(x = 0; x < 10; )            <= pętla nieskończona for, zauważ dlaczego?
    {
        ....
    }
    
    no i to chyba wszystko o czym chciałem powiedzieć, przećwiczmy ją teraz.
    Przykład będzie wydaję mi się dosyć prosty. Chodzi o to aby pokazać Ci
    działanie takiej pętli. Jeśli chcesz coś co będzie dla Ciebie większym
    wyzwaniem to spróbuj po zrobieniu tego ćwiczenia zmodyfikować ten kod. 
    Wymyśl coś ciekawego :) - stwórz jakąś miniaplikacje konsolową z menu może?

    dobra....
    
    1. Stwórz klasę Cwiczenie.
    2. Stwórz metodę Infty_for() 
    3. W metodzie Infty_for()
    napisz pętlę nieskończoną for, która będzie sumowała dwie liczby podane przez użytkownika. 
    Po wypisaniu wyniku znowu sumuje dwie liczby itd...

    przykład działania programu:
    Podaj liczbe 1:
    5
    Podaj liczbe 2:
    6
    5 + 6 = 11
    Podaj liczbe 1
    .. i tak dalej.

    4. Stwórz obiekt a następnie wywołaj metodę infty_for(). 
    5. Przetestuj program.


    ====================================================================
                      #Propozycja dalszego ćwiczenia. 
    ====================================================================
    Usprawnij swój program tak aby zliczał sumę na bieżąco liczb które podaje użytkownik.
    Np.

    5
    Wynik = 5
    4
    Wynik = 9
    3
    Wynik = 12
    itd... 

    A jeśli to dla Ciebie łatwe i szybko przerobiłeś swój program, wymyśl coś i ciekawie 
    przerób ten program. Pamiętaj, że ćwicząć uczysz się :).

    A więc zapamiętaj z tego ćwiczenia jak tworzymy nieskończoną pętlę for :) !!!!
*/
namespace infty_for
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
