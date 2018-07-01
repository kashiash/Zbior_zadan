using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Zapewne dokładnie już wiesz jak działa pętla for a tym bardziej pętla while. Jeśli nie to ja Ci przypomnę.
    Te dwie pętle, które wymieniłem wyżej mają coś wspólnego, co? Obie przed wejściem do tak zwanego
    "bloku instrukcji" sprawdzają WARUNEK! Czyli najpierw sprawdzają warunek!!

    To pewnie zapytasz a co z pętlą do ... while? Zobacz, jak się pisze do-while (pl. zrób-gdy) to rzuca nam się
    w oczy, że najpierw robi a potem sprawdza... Dokładnie! Słuchaj, jeśli chodzi o pętle do-while to często
    mówi się też, że "wykona się minimum jeden raz". A dlaczego? No bo niezależnie od tego jaki będzie warunek
    najpierw pętla wejdzie do "bloku instrukcji" i wykona go, a dopiero potem sprawdzi warunek, czy to nie 
    jest łatwe, proste i przyjemne?

    A więc pierwsze zadanie, które wprowadzi Cię do tej pętli brzmi:

    1. Stwórz klasę testowanie
    2. Stwórz w niej metodę zrob_gdy()   <= jak myslisz, co oznacza ze sa puste nawiasy? Wiesz pewnie! 
    3. W stworzonej metodzie skonstruuj pętle do... while według tego pseudokodu:

    do 
    {
    wypisuje 'Ja sie wykonuje w bloku instrukcji. Pss, to gdzie teraz pisze to blok instrukcji w tych 
    klamrach'

    wypisuje 'Ej ja tez nadal jestem w bloku instrukcji'
    }
    while (x != 0)

    Tylko zadeklaruj nad petla, zmienną x. 

    4. Standardowo, stworz obiekt. Zrób to za pomoca konstruktora domyślnego.

    5. Wywołaj metodę zrob_gdy().
    a) gdy zmienna x, w metodzie wynosi: x = 0
    b) gdy zmienna x, w metodzie wynosi: x = 1

    6. Czy takich efektów się spodziewałeś? Jak nie, to spróbuj przetłumaczyć sobie "ręcznie" powyższą
    pętlę. Jak tak to i tak spróbuj to przetłumaczyć, żebyś na przyszłość wiedział jak taką pętlę 
    napisać. Ta pętla nie jest taka trudna a może się czasem przydać z racji właśnie tego, że
    [jak brzmi definicja...] WYKONA się minimum jeden raz niezależnie od tego czy warunek prawdziwy
    czy nie! 

    Jeśli nadal mi nie wierzysz... albo wierzysz i chcesz się upewnić czy dobrze myślisz... :) 
    
    Zadanie dodatkowe:
    Dorzuć do powyższej klasy metodę gdy. Gdy bo będzie to po prostu pętla while. 
    Umieść w niej tą samą zawartość instrukcji co w pętli do while.
    I pamiętaj o zmiennej x. 

    Wywołaj obie metody. 
    pod warunkiem że metoda gdy() ma x = 0, metoda zrob_gdy() ma x = 0

    zobacz różnicę.... i przeanalizuj co się zdarzyło. 


    Zapamiętaj z zadań:
    - co to jest takiego pętla do ... while?
    - jak działa pętla do ... while?
    - jak jest zbudowana pętla do ... while?
    - co oznacza, że metoda jest typu pustego?
    - co to takiego pętla while, jak ją tworzymy? 
    - jaka jest różnica między pętla while a do...while?
    - co to takiego zmienna? Jakiego typu może być(wymień 4 typy)

*/

namespace do_while_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
