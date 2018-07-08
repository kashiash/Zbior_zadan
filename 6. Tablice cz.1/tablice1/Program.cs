using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * #aktualizacja (lipiec 2018)
 * Poniżej podjeśliśmy akcję rozjaśnienia sensu istnienia tablicy 
 * na życiowym przykładzie myślę
 * polecam się zapoznać przed przejściem do zadania :):):)
 
    Treść zadania:
    Napisz metode w klasie wynik ktora wypelni tablice liczbami calkowitymi od 1 do ....20 (czyli tablica 20 elementowa).
    Nastepnie wyswietl ta tablice i pokaz w jakim indeksie jaka liczba sie znajduje.np. tablica[0] = 1;

    przypomnienie:
    deklaracja tablicy wyglada tak:
    string[] nazwa = new string[5];
    (to jest typu string tablica, która ma 6 miejsc bo od 0 do 5 jest 6!)

    Utrwalasz sobie dzięki temu zadaniu m.in:
    - jak stworzyc tablice
    - jak wpisac do niej elementy (podpowiedz: petla :D)
    - jak korzystac z indeksu w petli
    - jak wypisać tablicę
    - jak stworzyć metodę, klasę?
    - jak wywołać metodę?

    Weźmy liźnijmy trochę teorii - no co to takiego tablica? 
    obrazowo: tablica to takie pudło do którego możemy włożyć rzeczy, wyciągać je z niego, podmieniać, dodawać, robić coś 
    dla wszystkich rzeczy, wyszukać konkretną rzecz z pudła, sprawdzić czy jakaś rzecz jest w pudle a jeśli nie ma to
    np. dodać itd itp itp itd. Tablica ma wiele zastosowań ale generalnie robimy tablicę po to aby oszczędzić sobie 
    nadmiernej pisaniny. Zobaczysz to poniżej. 

    idźmy tym luźnym tropem.... przy okazji zauważ jak tablica dopełnia się z pętlami :) , myślę że w 
    poniższych przykladach to zauwazysz a jezeli nie to bedziemy cos tam kminic wspolnie jak to by
    wygladalo . Przeanalizuje je na spokojnie :) 

    załóżmy, że masz pudło w którym zmieści się 5 książek, są to: Mrok, Rapapa, Czekala, Info, Patriota
    umieściłeś książki od spodu tak jak wypisaliśmy, czyli na samej górze jest książka "Patriota"
    => w C# byśmy zapisali: string[] pudlo = { "Patriota", "Info", "Czekala", "Rapapa", "Mrok" }

    wspominaliśmy, że oszczędza to pisaniny - wyobraź sobie jakby wyglądał powyższy przykład bez tablicy?
    string tytul1 = "Patriota";
    string tytul2 = "Info";
    string tytul3 = "Czekala";
    string tytul4 = "Rapapa";
    string tytul5 = "Mrok";
    musielibyśmy tutaj przypisywać każdą książkę do oddzielnej zmiennej i na dodatke gdybyśmy np. teraz
    chcieli sprawdzić czy książką którą poda użytkownik jest w zbiorze to by to wyglądało np. tak:

    if (podana == tytul1 )
    {

    }
    else if ( podana == tytul2 )
    {

    }
    itd...

    Widzisz, tutaj masz tylko 5 elementów - wyobraź sobie co by było dla 100 :) - tragednia nie? 
    Z ratunkiem przybywa TABLICA :) ale dobra, koniec wywodu - wróćmy do przykładów z życia :D


    1) chcesz wyjąć książkę Rapapa - jak to zrobisz w życiu?
    Otworzysz pudło, patrzysz czy górna książka to Rapapa? Nie? to zdejmujesz ksiazke i zagladasz dalej.
    Czy nastepna ksiazka to Rapapa? Nie? zdejmujesz kolejna ksiazke i zagladasz dalej
    Czy nastepna ksiazka to Rapapa? Tak! To usmiechasz sie ze znalazles i wyciagasz ja zeby przeczytac :) 

    => w C# byśmy to zinterpretowali tak:
    string[] pudlo = { "Patriota", "Info", "Czekala", "Rapapa", "Mrok" }

    for (int i = 0; i < pudlo.Length; i++)
    {
        if (pudlo[i] == "Rapapa")
        {
            string reka = pudlo[i];                         // wyjmujemy ksiazke
            Console.WriteLine("Znalazlem ksiazke!!" + reka);
            break;                                          // jak znalazłem to wychodze z pętli
        }
    }

    i mamy :), widzisz jakie to jest "życiowe" ? :)

    2) chcesz włożyć np. książkę Dudu do pudla 
    Otworzysz pudlo, jest zapelnione - musisz zastapic jedna ksiazke ksiazka Dudu
    Wyjmujesz np. gorna ksiazke i wkladasz w jej miejsce ksiazke Dudu - koniec :)

    => w C# byśmy to zinterpretowali tak:
    string[] pudlo = { "Patriota", "Info", "Czekala", "Rapapa", "Mrok" }

    pudlo[0] = "Dudu";  // wlozylismy za Patriota ksiazke Dudu do pudla :)


    mam nadzieje, że troche Ci to pokazało jak taka tablica funkcjonuje i jaka ona jest zyciowa,
    a wiec jak podejmiesz sie zadania z tablic - albo planujesz taka tablice wprowadzic to wyobrazaj
    sobie ja jak takie pudelko :)

    jako, że podaliśmy tyle pełynch przykładów to nie będę już tam wrzucał do bloku programu, w razie
    jak chcesz przetestować je do smialo skopiuj i sprawdz jak dzialaja :) 

    */
namespace tablice1
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.ReadLine();
        }
    }
}
