using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
               UWAGA!
    Zanim zaczniesz, jedna sprawa :)
    Jeśli uważasz, że możesz coś 
    szybko zapomnieć to zanotuj sobie
    to do notatnika. Stwórz sobie taki
    specjalny do programowania notatnik
    w którym będziesz przechowywać rzeczy
    do przypomnienia czy zapisuj w specjalnym
    zeszycie ręcznie. Twoja decyzja. Tak 
    aby została ta wiedza na dłużej a w 
    razie czego, żeby ją szybko sobie 
    ponieważ wiadomo, że aby dojść do 
    wprawy trzeba zrobić kilka zadań,
    trochę nad tym posiedzieć.
    Powodzenia!

    PS: Jeśli czujesz, że czegoś nie 
    rozumiesz na spokojnie spróbuj
    to przeanalizować do momentu aż
    Ci się uda pojąć o co chodzi :).

    I pamiętaj też, że jak będziesz się
    uczyć tych kodów to najważniejsze jest
    nie to że go napiszesz a że go zrozumiesz!
    To analiza kodu powoduje że utrwalasz
    programowanie i się go uczysz! Tak więc
    myśl, analizuj linijka po linijce i 
    kombinuj! A sobie poradzisz i łatwo
    zrozumiesz sentencję programowania w 
    niejednym kodzie! Naprawdę warto
    analizować samemu kod! Polecam!


                                *****************************************
                                     Temat: METODY, FUNKCJE, ZWRACANIE.
                                *****************************************
                                
    Zatem, pewnie zastanawiasz się co oznaczają METODY a co FUNKCJE. Pierwsze wyjaśnienie!
    Te dwa słowa.... to synonimy,
    zatem FUNKCJA oznacza METODĘ.
    Metoda, ładniej chyba brzmi :).

    ?: Co oznacza słowo metoda, funkcja:
    => jest to ciąg instrukcji, który zostaje "aktywowany" w momencie wywołania takiej metody. Może coś
    zwracać lub nie musi. 

    ?: to pewnie zastanawisz się, a co oznacza wywołanie funkcji? A no właśnie jej aktywację! Nic 
    prostszego jak się to zrozumie. Mówisz Masło maślane? 
    Poczekaj, idź dalej, zobacz przykłady i jeszcze raz przeczesz definicje. :)

    ?: Po co nam taka metoda?
    A no jest bardzo bardzooo użyteczna ponieważ możemy ją wykorzystać do tego aby wykonała określoną rzecz np. 
    zamieniła liczby w tablicy miejscami, wyzerowała tablicę, obliczyła na podstawie wzoru jakiś wynik itd..
    Dzięki metodzie wszystko jest pięknie czytelne dla Ciebie i dla reszty zespołu programistów. Dzięki
    temu nie zgubisz się w swoim własnym kodzie! Będzie on przejrzysty! 

    => Zobacz teraz,

    jeśli w main zapiszesz bez żadnych metod kod będzie to tak:
    
    for(...;...;...)
    {
        if(...)
        {
          ...
        }

        if(...)
        {
              for(....;...;...)
                     {
                        ....

                            for(....;....;...)
                            {
                            ....
                            }

                            for(....;.....;...)
                            {
                            ....
                            }
                     }
         }

    Swoją drogą, widzisz dlaczego wcinanie klamerek jest ważne: 
    Żeby po prostu odnaleźć się, w którym bloku jesteśmy.
    Ale po np. 3 miesiącach zaglądając wyobraź sobie do takiego kodu
    jak znalazłbyś linijkę, która np. oblicza liczbę? 

    a gdy zapiszesz metodami:

    wypisz_na_ekran()
    {
        ....
    }

    oblicz_cene(double cena, double waga)
    {
        ....
    }

    Nie dość, że wiemy od czego jest dany kod(bo np. metode nazwaliśmy wypisz) to jeszcze
    wygląda to dużo przejrzyściej i jeśli przysiadziesz do takiego kodu za np. kilka miesięcy.
    Wtedy na pewno szybciej się połapiesz który blok odpowiada za coś niż wklepując wszystko
    bez metod. 

    To skoro wiesz już nieco o metodach, teraz możemy powiedzieć o tym jak wygląda sam proces
    deklarowania metody. Jest on wręcz banalnie prosty. Wystarczy, że podasz 
    w C#, rodzaj dostępu , typ danych , nazwa metody i ewentualnie argumenty, 

    przykłady dla Ciebie do przeanalizowania:

    - public double oblicz_cene(double waga, double cena);

    double pomiędzy public a oblicz_cene oznacza, że funkcja musi koniecznie zwrócić wartość
    która ma taki typ danych, jeśli nie zwróci takowej to dostaniemy error. 

    teraz Ty przećwicz:

    - protected int policz_wiek(int rok_urodzenia)
    - public char sprawdz_znak(char wybor)
    - private float srednia(float ocena)
    - public string dane_os(string imie, string nazwisko)

    no, okej, udało się? Jeśli tak to przypomnij sobie teraz, co oznacza typ danych float? 
    Tak dla sportu, a jeśli nie pamiętasz to szybciutko poszukaj w necie bo znowu zapomnisz
    i też może zanotuj? :) 

    => Dobrze, to teraz jeszcze omówmy sobie jeden ciekawy typ jaki może mieć metoda. Nazywa się
    'void', z angielskiego oznacza pustkę, zatem rozumiesz co przez to stwórcy języka C# chcieli
    powiedzieć. Na pewno m.in to, że ta metoda nie przyjmuje żadnych argumentów i nic nie zwraca.
   
                                    A więc zapamiętaj!

               ***Funkcja typu void nie przyjmuje argumentów ani nic nie zwraca!***

    przykłady takich funkcji(metod):
    
    - public void wyswietl_wynik()
    - public void dodaj_studenta()
    - private void zmien_tablice()
    - internal void policz_sume()

    Co masz jeszcze do zapamiętania z tego faktu? Z tego void? Mianowicie:
    gdy w zadaniu będzie, żebyś stworzył dla przykładu
    funkcję mleczko() to fragment

    mleczko() mówi Ci o dwóch rzeczach!
    1) jest to funkcja, bo ma nawiasy!
    2) jest to funkcja typu void, bo nie przyjmuje argumentów! 

    więc mamy public void mleczko()...


    ...teraz Ty przećwicz, włącz wszystkie zmysły do zrobienia tego zadania, powiedz głośno 
    co robisz, zobacz, napisz tutaj itd, a więc:


    Cwiczenie: stworz metode oblicz_pi().
    Co mówi nam fragment: oblicz_pi()? 
    
    1)  wypełnij to miejsce
    2)  wypełnij to miejsce 

    Cwiczenie2: stworz metode zgarnij_kase()
    Co mówi nam fragment: zgarnij_kase()?

    1)  wypełnij to miejsce
    2)  wypełnij to miejsce


    no to jak już to przećwiczyłeś, i wiesz co to metoda, co to za szczególna metoda typu void czyli pusta
    to przejdźmy do części ostatniej czyli "zwracanie"

    => Zapisaliśmy już wcześniej taki fragment:

          /double pomiędzy public a oblicz_cene oznacza, że funkcja musi koniecznie zwrócić wartość/
          /która ma taki typ danych, jeśli nie zwróci takowej to dostaniemy error.                 /

    pamiętasz? : )
    
    słowo "zwracanie" ma dla nas bardzo ważne znaczenie, ponieważ jeśli Twoja metoda ma typ danych inny
    niż void, np. int, double, char, TO MUSI taką wartość zwrócić, inaczej będzie krzyczał o błędzie!!!

    a więc "zwracanie" po angielsku oznacza return (czyli zwróć), oznacza to oddanie wartości od funkcji 
    pod miejsce, które chcemy. Zazwyczaj to robimy w sposób taki:

    double a = obiekt.WywolajMetode(double cena);                    <= oddajemy wynik pod zmienną a
    Console.WriteLine(a);
    
    wtedy patrzac na przyklad powyzej, funkcja WywolajMetode zwraca wartosc typu double i wrzuca ja 
    pod zmienna typu double czyli a, rozumiesz? :) Pewnie się zapytasz, a skąd wiem, że funkcja 
    WywolajMetode jest typu double? A no na zdrowy rozum. Do double chcesz przypisać wartość
    double, no chyba że masz dziwne zamiary :).

    => ale jeśli chcemy ją odrazu wyświetlić to korzystamy z Console.WriteLine i tam wywołujemy metodę, tak? 
    patrz: Console.WriteLine("Wywoluje metode => " + obiekt.WywolajMetode);
    
    ?: dlaczego w sposób z WriteLine działa? Ponieważ wypiszemy wartość, którą zwróci metoda "WywolajMetode".

    A więc uwaga, jeśli nie skorzystasz z jednego z tych dwóch sposobów, to wynik który zwróci Twoja funkcja
    ucieknie! No i na dodatek nie pokaże się nam na ekranie. :((

    A teraz jeszcze zwróć uwagę, jak zwrócić wartość w metodzie, W PRAKTYCE,
    mamy np.

    public int oblicz_wiek(int rok_urodzenia)
    {
    int wiek = .... 
    return wiek;                    <= w taki sposób zwracamy zmienną
    }

    public double policz_cene(double cena)
    {
    return cena * 2.0 / 5;          <= w taki sposób zwracamy odrazu wynik      (do rekurencji!)
    }

    Kiedy, która opcja jest wygodna?
    Zależy tylko i wyłącznie od Ciebie.
    Tylko, uwaga, nie łącz tych sposobów!
    Ja Ci mogę podpowiedźieć tyle, że 
    zwracanie wyniku odrazu stosjemy
    dla rekurencji nie? To na pewno.

    a teraz spróbuj sam i zobacz czy rozumiesz:

    1) Stwórz metodę int oblicz_wiek(int wiek) i zwróć wartość wiek
    // tu wpisz odpowiedź na to zadanie

    2) Wywołaj metodę oblicz_wiek w zmiennej i potem ją wyświetl
    // tu wpisz odpowiedź na to zadanie

    3) Wywołąj metodę oblicz_wiek w Console.WriteLine odrazu
    // tu wpisz odpowiedź na to zadanie


    ~A więc skoro, wiesz już to wszystko o czym mówiliśmy, to przejdź sobie do kodu i spróbuj potworzyć kilka 
    metod, jeśli nie masz pomysłu to ja Ci coś zaproponuję, odtąd te zadania poniżej zapisuj normalnie w 
    kodzie. 

    ~A jeśli nadal masz problemy z rozróżnianiem tych definicji, tego wszystkiego o czym mówimy, to wróć do 
    teorii i przeanalizuj ją ponownie do momentu aż uda Ci się zrozumieć na czym polega. Powoli spokojnie i
    dojdziesz do wprawy :) 
    

    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Okej, większość teorii, którą chciałem Ci przekazać mamy za sobą, możesz teraz sprawdzić siebie czy
    udało Ci się ją zrozumieć. Aby tego dokonać to przejdź już do ćwiczeń, które będziesz wykonywać w kodzie
    programu. 

    1) Stwórz klasę testowanie_metod
    2) Stwórz metodę:

    a) silnik() która wypisuje na ekran "Samochód ma silnik", wywołaj ją 
    #PS: chyba nie muszę przypominać, że aby odwołać się, do metody z klasy, musisz stworzyć obiekt? :) 

    b) która przyjmuje dwa argumenty typu double, cenę i wagę, a nazwa metody to policz_cene

    c) typu void, która nazywa sie statystyka  <= (co znaczy void?)

    d) identyfikacja która będzie zwracała wartość int i będzie przyjmować jeden argument, int nr_pesel

    e) która będzie się nazywała objetosc, bedzie zwracala typ float a argumenty jakie przyjmie to 
       float dlugosc, float szerokosc, float wysokosc.

    f) to teraz jeszcze stwórz własną metodę typu pustego i umieść tam z dwie linijki kodu, np. pobranie
       od użytkownika zmiennej i wypisanie tego co podał okej? Pamiętaj , że musisz tą metodę wywołać w 
       bloku main. Zauważ, że jest to bardzo fajny sposób na to aby "odciążyć" blok main. :) 

       #Przypomnienie: to że metoda znaczy pusta, nie znaczy, że nie może mieć instrukcji :). 
       Metoda pusta oznacza tylko to, że nie przyjmuje argumentów i nie zwraca wartości
       (czyli nie ma return).

    g) a teraz stwórz metodę, która coś może zwracać, to powiedzmy liczbę całkowitą... Nazwe metody ustal 
       samodzielnie. Podpowiem tyle, że naza metody powinna być taka, która kojarzy się z funkcją jaką pełni
       ta metoda. Niech Twoja metoda przyjmuje jeden argument czyli liczbę, którą poda użytkownik,
       (też całkowitą). Zatem użytkownik podaje liczbę całkowitą, wywołujesz swoją metodę a ta metoda
       mnoży tą liczbę przez 2 i zwraca do zmiennej wynik w metodzie obliczoną wartość. (Pamiętaj, że 
       zmiennej wynik nie widzisz w main, zatem musisz zastosować się do zasady jednej z powyżej jak 
       wyświetlić wynik metody :), jeśli nie pamiętasz to zerknij do góry szybciutko!)


============

      ~A więc, jeśli przestudiowałeś to wszystko i czujesz, że udało Ci się zrozumieć to gratulację, a
       jeśli w dalszym ciągu nurtują Cię jakieś pytania, wątpliwości to koniecznie je rozwiej w sposób
       dobrowolny (czy to szukanie odpowiedzi w internecie, czy przetestowanie w kodzie jak działa to co
       chcesz sprawdzić...) i pamiętaj, żeby jeszcze do tego miejsca zajrzeć bądź spreparować sobie 
       dobrą notatkę i zerkać na nią. Albo jeśli czujesz, że za mało zrobiłaś/zrobiłeś ćwiczeń to wymyśl
       sobie zadanie o metodzie i stwórz ją tutaj. Ogranicza Cię jedynie wyobraźnia! Pamiętaj, że ćwiczenie
       utrwala teorię. Nawet nie zauważysz, że się nauczyłaś/naczyłeś rozpoznawać co dana metoda zwraca, jakiego
       typu jest itd..

       Metody(funkcje) są bardzo ważne, więc jeśli nie możesz zrozumieć jak działają, to nie uda Ci się
       pojąć dalszych kodów. Zatem postaraj się to zrozumieć w pierwszej kolejności :).

      =====> A więc, zapamiętaj z tego tematu: <======
       - jak wywołujemy metodę która coś zwraca w bloku głównym?
       - po co nam metoda?
       - jakiego typu danych może być metoda?
       - czy metoda zawsze musi mieć argumenty?
       - czy metoda musi zawsze coś zwracać?
       - co to za metoda typu void?
       - czy metoda void coś zwraca?
       - czy metoda void przyjmuje argumenty?
       - co to jest return i w jaki sposób możemy zwracać? (przez zmienną lub odrazu)
       - jak wywołujemy metodę void w bloku głównym?

        Odpowiedzi poszukaj w notatce wyżej, wszystkie znajdziesz, a jak znajdziesz to lepiej zapamiętasz :).
*/
namespace metody_wstep
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
