using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ############################################
    # ostatnia aktualizacja notatki: 03.08.18r #
    ############################################

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
    uczyć rozumieć kody to najważniejsze jest
    nie to że go napiszesz a że go zrozumiesz!
    To analiza kodu powoduje że utrwalasz
    programowanie i się go uczysz! Tak więc
    myśl, analizuj linijka po linijce i 
    kombinuj! A sobie poradzisz i łatwo
    zrozumiesz sentencję programowania w 
    niejednym kodzie! Naprawdę warto
    analizować samemu kod! Polecam!

    I nie bój się próbować, a osiągniesz
    to co chcesz osiągnąć.

    To tyle słowem wstępu, przejdźmy to 
    naszego tematu.











                               *******************************************
                               |     Temat: METODY, FUNKCJE, ZWRACANIE.  |
                               *******************************************
                               |            wstęp teoretyczny            |
                               *******************************************
                                
    Zatem, pewnie zastanawiasz się co oznaczają METODY a co FUNKCJE. Pierwsze wyjaśnienie!
    Te dwa słowa.... to uwaga... synonimy (nie zaskoczyłem? - pewnie tak..)
    zatem FUNKCJA oznacza METODĘ. Metoda, ładniej chyba brzmi :)

    ?: Co oznacza słowo metoda, funkcja:
    => jest to ciąg instrukcji, który zostaje "aktywowany" w momencie wywołania takiej metody. Może coś
    zwracać lub nie musi. Możemy coś tej funkcji w dodatku przekazać lub nic. Dzięki funkcjom nie musimy
    powielać kodu... np. gdy będziemy potrzebowali wywołać ją w kilku miejscach, to tylko zapisujemy jedną
    linijkę - wywołanie bez kopiowania kodu dzięki czemu nasz projekt jest schludny i czytelny.

    ?: to pewnie zastanawisz się, a co oznacza to wywołanie funkcji? 
    => A no właśnie jej aktywację! Nic prostszego jak się to zrozumie. Mówisz Masło maślane? 
    Poczekaj, idź dalej, zobacz przykłady i jeszcze raz przeczesz definicje i załapiesz. :)

    ?: Po co nam taka metoda Panie Tłumaczu jak to nic innego jak bloczek instrukcji??? 
    A no jest bardzo bardzooo użyteczna ponieważ możemy ją wykorzystać do tego aby wykonała określoną rzecz np. 
    zamieniła liczby w tablicy miejscami, wyzerowała tablicę, obliczyła na podstawie wzoru jakiś wynik itd..
    Dzięki metodzie wszystko jest pięknie czytelne dla Ciebie i dla reszty zespołu. Dzięki temu zabiegowi
    nie zgubisz się w swoim własnym kodzie! Będzie on przejrzysty! No i jeżeli planujemy ten kod wykorzystać
    wielokrotnie to nie musimy duplikować niepotrzebnie kodu tak jak to wcześniej wspomnieliśmy.

    => Zobacz teraz,
    jeśli w main zapiszesz bez żadnych metod kod będzie to tak:
    (załóżmy, że rzeczywiście twój kod tak wygląda)

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
    jak znalazłbyś linijkę, która np. oblicza liczbę gdyby nie wcięcia? 

    a gdy zapiszesz swój program dołączając metody:

    wypisz_na_ekran()
    {
        ....
    }

    oblicz_cene(double cena, double waga)
    {
        ....
    }

    i potem w części głównej(main) programu np.
    double suma = oblicz_cene(15,20);
    wypisz_na_ekran();

    to o wiele lepiej widać co się dzieje :)
    a gdy zrobisz go obiektowo dodając np. klasy
    to fiu fiu, jeszcze lepiej! :) 

    Nie dość, że wiemy od czego jest dany kod(bo np. metode nazwaliśmy wypisz) to jeszcze
    wygląda to dużo przejrzyściej i jeśli przysiadziesz do takiego kodu za np. kilka miesięcy.
    Wtedy na pewno szybciej się połapiesz który blok odpowiada za coś niż wklepując wszystko
    bez metod. Potwierdzone info :) Przy okazji, pamiętaj o czymś takim jak "region" dzięki czemu
    możemy upychać kody do takich "paczek" i w razie potrzeby rozwijać je. Z czasem przecież twój
    kod może ulec takiemu zwiększeniu, że ciężko będzie się pracowało jeśli co chwile będziesz musiał
    jeździć suwakiem od dołu do góry, prawda? :) 

    przykładowe użycie region:
    (jako, że daje tam sam zwykły tekst to oczywiście muszę go zakomentować czy to jednowierszowo czy wielowierszowo)

    #region Blok Tekstu
    // Ten kod tutaj jest w "bloku"/regionie
    // to moj tekst
    #endregion

    PS: jak chcesz sprawdzić jak działa, zjedź niżej na moment do bloku main, tam znajduje się ten kodzik:)





    To skoro wiesz już nieco o metodach, tooo teraz możemy powiedzieć o tym jak wygląda sam proces
    deklarowania/tworzenia metody - jak zwał tak zwał. Jest on wręcz banalnie prosty. Wystarczy, że
    podasz w C#, rodzaj dostępu , typ danych , nazwa metody i ewentualnie argumenty, 

    !!! mini-uwaga:
    jeżeli nie podasz rodzaju dostępu(public, private, internal lub protected) to taka metoda domyślnie
    będzie metodą "private" - prywatną


    przykłady metod dla Ciebie:

    1) public double Oblicz_cene(double waga, double cena);

    i teraz kilka słów o niej:
    => public oznacza dostęp do tej funkcji, w tym przypadku public oznacza, że jest dostępna "wszędzie i zawsze"

    => double pomiędzy public a oblicz_cene oznacza, że funkcja musi koniecznie zwrócić wartość
    która ma typ danych double, jeśli nie zwróci takowej to dostaniemy error/dostajemy error! 

    => oblicz_cene to nazwa funkcji(nazwy funkcji zaczynamy zwykle od dużej litery i staramy się ją nazwać tak
    aby było wiadomo co ona robi np. wyzerujTablice, przesuńElementyTablicy itd..

    => w nawiasie podano argumenty waga(który jest typu double) oraz cena(także typu double), argumenty czyli
    to co chcemy przekazać do funkcji aby wykonać na nich jakieś operacje. Gdy będziemy próbować wywołać tą
    metodę to musimy "podrzucić" w miejsca argumentów odpowiednie rzeczy aby funkcja mogła prawidłowo działać. 

    np. Oblicz_cene(5.0, 2.3);
    lub podając zmienne które przechowują odpowiednie wartości..
    np. Oblicz_cene(mojaWaga, mojaCena);                            => zakładając, że takie zmienne zadeklarowaliśmy...

    teraz Ty przećwicz i spróbuj opisać poniższe funkcje:
    no i w razie czego wyjaśnijmy sobie kwestię dostępów do funkcji:
    * protected - funkcja będzie widoczna tylko w obrębie klas, które dziedziczą z klasy która ma funkcję protected
    * public - dostępna funkcja wszędzie i zawsze
    * private - dostępna funkcja tylko w obrębie klasy
    * jest jeszcze rzadko używany internal 
    - widzimy funkcję tylko w tym namespace(przestrzeni nazw) w którym go zdefiniowaliśmy

    - protected int Policz_wiek(int rok_urodzenia)
    - public char Sprawdz_znak(char wybor)
    - private float Srednia(float ocena)
    - public string Dane_os(string imie, string nazwisko)

    no, okej, udało się?
    
    Jeśli tak to przypomnij sobie teraz, co oznacza typ danych float? 
    Tak dla sportu, a jeśli nie pamiętasz to szybciutko poszukaj w necie bo znowu zapomnisz
    i też może zanotuj? 

    => Dobrze, to teraz jeszcze omówmy sobie jeden ciekawy typ jaki może mieć metoda. Nazywa się
    'void', z angielskiego oznacza /pustkę/ /pusta/, zatem rozumiesz co przez to stwórcy języka C# chcieli
    powiedzieć. Na pewno m.in to, że ta metoda.. nic nie zwraca. Puste jak cholera :O 

                                    A więc zapamiętaj!
                          ***Funkcja typu void nie nic nie zwraca!***

    przykłady takich funkcji(metod):
    
    - public void Wyswietl_wynik(int ostatni)
    - public void Dodaj_studenta(string imieStudenta)
    - private void Zmien_tablice()
    - internal void Policz_sume(int wynik)

    Co masz jeszcze do zapamiętania z tego faktu? Z tego void? Mianowicie:
    gdy w zadaniu będzie, żebyś stworzył dla przykładu
    funkcję mleczko() to fragment

    mleczko() mówi Ci o tym, że jest to funkcja, bo ma nawiasy

    więc mamy o tak:
    public void mleczko() 
    { 
            // kod idzie tutaj
    }

    ...teraz Ty przećwicz, włącz wszystkie zmysły do zrobienia tego zadania, powiedz głośno 
    co robisz, zobacz, napisz tutaj - utrwalisz sobie ten nawyk, a więc:


    Cwiczenie: stworz metode Oblicz_pi().
    Co mówi nam fragment: Oblicz_pi()? 
    
    1)  <wypełnij to miejsce>           (o ile chcesz..)

    Cwiczenie2: stworz metode Zgarnij_kase()
    Co mówi nam fragment: Zgarnij_kase()?

    1)  <wypełnij to miejsce>


    no to jak już to przećwiczyłeś, i wiesz co to metoda, co to za szczególna metoda typu void czyli pusta
    to przejdźmy do części ostatniej czyli "zwracanie"

    => Zapisaliśmy już wcześniej taki fragment:

          /double pomiędzy public a oblicz_cene oznacza, że funkcja musi koniecznie zwrócić wartość/
          /która ma taki typ danych, jeśli nie zwróci takowej to dostaniemy error.                 /

    pamiętasz? : )  (taaaaak)
    
    słowo "zwracanie" ma dla nas bardzo ważne znaczenie, ponieważ jeśli Twoja metoda ma typ danych inny
    niż void, np. int, double, char itd., TO MUSI taką wartość zwrócić, inaczej będzie krzyczał o błędzie!!!

    a więc "zwracanie" po angielsku oznacza return (czyli zwróć), oznacza to oddanie wartości od funkcji 
    pod miejsce, które chcemy. Zazwyczaj to robimy w sposób taki:

    double a = obiekt.WywolajMetode(double cena);                    <= oddajemy wynik pod zmienną a aby go nie utracić
    Console.WriteLine(a);
    
    Wtedy patrzac na przyklad powyzej, funkcja WywolajMetode zwraca wartosc typu double i wrzuca ja 
    pod zmienna typu double czyli a, rozumiesz? :) Pewnie się zapytasz, a skąd wiem, że funkcja 
    WywolajMetode jest typu double? A no na zdrowy rozum. Do double chcesz przypisać wartość
    double, no chyba że masz dziwne zamiary i próbujesz jakichś czarów :O .

    Z kolei, jeżeli zrobilibyśmy tak:
    obiekt.WywolajMetode(double cena);
    to nie "wyłuskamy" i nie "wykorzystamy" tego co wypluła ta funkcja, ona po prostu się wykonała, zrobiła
    to co miała i tyle...

    => A co jeśli chcemy ją odrazu wyświetlić to korzystamy z Console.WriteLine i tam wywołujemy metodę, tak? 
    patrz, o to mi chodzi: Console.WriteLine("Wywoluje metode => " + obiekt.WywolajMetode);
    
    ?: dlaczego w sposób z WriteLine działa? Ponieważ wypiszemy wartość, którą zwróci metoda "WywolajMetode".
    (oczywiście moglibyśmy także skorzystać z Write)
    
    \\Mini-wniosek:
    A więc uwaga, jeśli nie skorzystasz z jednego z tych dwóch sposobów, to wynik który zwróci Twoja funkcja
    ucieknie! No i na dodatek nie pokaże się nam na ekranie. :(( Dbaj o ten nawyk. Jeżeli masz funkcję ze zwracaniem
    to albo wypisz na ekran albo zapisz wynik do zmiennej!!!

    A teraz jeszcze zwróć uwagę, jak zwrócić wartość w metodzie, W PRAKTYCE,
    mamy np.

    public int Oblicz_wiek(int rok_urodzenia)
    {
    int wiek = .... 
    return wiek;                    <= w taki sposób zwracamy zmienną
    }

    public double Policz_cene(double cena)
    {
    return cena * 2.0 / 5;          <= w taki sposób zwracamy odrazu wynik
    }

    Kiedy, która opcja jest wygodna?
    Zależy tylko i wyłącznie od Ciebie.
    Tylko, uwaga, nie łącz tych sposobów!

    a teraz spróbuj sam i zobacz czy rozumiesz:

    1) Stwórz metodę int Oblicz_wiek(int wiek) i zwróć wartość wiek
    // tu wpisz odpowiedź na to zadanie

    2) Wywołaj metodę Oblicz_wiek w zmiennej i potem ją wyświetl
    // tu wpisz odpowiedź na to zadanie

    3) Wywołąj metodę Oblicz_wiek w Console.WriteLine odrazu
    // tu wpisz odpowiedź na to zadanie


    ~A więc skoro, wiesz już to wszystko o czym mówiliśmy, to przejdź sobie do kodu i spróbuj potworzyć kilka 
    metod, jeśli nie masz pomysłu to ja Ci coś zaproponuję, odtąd te zadania poniżej zapisuj normalnie w 
    kodzie. 

    ~A jeśli nadal masz problemy z rozróżnianiem tych definicji, tego wszystkiego o czym mówimy, to wróć do 
    teorii i przeanalizuj ją ponownie do momentu aż uda Ci się zrozumieć na czym polega. Powoli spokojnie i
    dojdziesz do wprawy :) 

    ~W bloku main jest pare przykładów, zajrzyj tam potem :)
    

    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Okej, większość teorii, którą chciałem Ci przekazać mamy za sobą, możesz teraz sprawdzić siebie czy
    udało Ci się ją zrozumieć. Aby tego dokonać to przejdź już do ćwiczeń, które będziesz wykonywać w kodzie
    programu. 

    1) Stwórz klasę Testowanie_metod
    2) Stwórz metodę:

    a) Silnik() która wypisuje na ekran "Samochód ma silnik", wywołaj ją 
    #PS: chyba nie muszę przypominać, że aby odwołać się, do metody z klasy, musisz stworzyć obiekt? :) 

    #PS2: chyba, że zaczynasz to - tworzymy obiekt pisząc w ten sposób:
    nazwaKlasy nazwaobiektu = new nazwaKlasy();
    
    - uwaga - powyższy sposób działa o ile nie ustawiłeś konstruktora domyślnego na "private"

    b) która przyjmuje dwa argumenty typu double, cenę i wagę, a nazwa metody to Policz_cene

    c) typu void, która nazywa sie Statystyka  <= (co znaczy void???)

    d) Identyfikacja która będzie zwracała wartość int i będzie przyjmować jeden argument, int nr_pesel

    e) która będzie się nazywała Objetosc, bedzie zwracala typ float a argumenty jakie przyjmie to 
       float dlugosc, float szerokosc, float wysokosc.

    f) to teraz jeszcze stwórz własną metodę typu pustego i umieść tam z dwie linijki kodu, np. pobranie
       od użytkownika zmiennej i wypisanie tego co podał okej? Pamiętaj , że musisz tą metodę wywołać w 
       bloku main. Zauważ, że jest to bardzo fajny sposób na to aby "odciążyć" blok main. :) 

       #Przypomnienie: to że metoda znaczy pusta, nie znaczy, że nie może mieć instrukcji :). 
       Metoda pusta oznacza tylko to, że nie nie zwraca wartości
       (czyli nie ma return mówiąc "po chłopsku").

       #Przypomnienie2:
       pobranie tekstu przykładowo: string tekst = Console.ReadLine();
       wypisanie tekstu w nowej linii: Console.WriteLine(tekst);

    g) a teraz stwórz metodę, która coś może zwracać, to powiedzmy liczbę całkowitą... Nazwe metody ustal 
       samodzielnie. Podpowiem tyle, że naza metody powinna być taka, która kojarzy się z funkcją jaką pełni
       ta metoda. Niech Twoja metoda przyjmuje jeden argument czyli liczbę, którą poda użytkownik,
       (też całkowitą). Zatem użytkownik podaje liczbę całkowitą, wywołujesz swoją metodę a ta metoda
       mnoży tą liczbę przez 2 i zwraca do zmiennej wynik w metodzie obliczoną wartość. (Pamiętaj, że 
       zmiennej wynik nie widzisz w main, zatem musisz zastosować się do zasady jednej z powyżej jak 
       wyświetlić wynik metody :), jeśli nie pamiętasz to zerknij do góry szybciutko!)


===================================================================================================================

      ~A więc, jeśli przestudiowałeś to wszystko i czujesz, że udało Ci się cokolwiek zrozumieć albo wszystko
       to gratulację i ciesze się z tego powodu, a jeśli w dalszym ciągu nurtują Cię jakieś pytania, wątpliwości
       to koniecznie je rozwiej w sposób dobrowolny (czy to szukanie odpowiedzi w internecie, czy przetestowanie
       w kodzie jak działa to co chcesz sprawdzić...) i pamiętaj, żeby jeszcze do tego miejsca zajrzeć bądź spreparować
       sobie dobrą mininotatkę i zerkać na nią. Albo jeśli czujesz, że za mało zrobiłaś/zrobiłeś ćwiczeń to wymyśl
       sobie zadanie o metodzie i stwórz ją tutaj. Ogranicza Cię jedynie wyobraźnia! Pamiętaj, że ćwiczenie
       utrwala teorię. Nawet nie zauważysz, że się nauczyłaś/naczyłeś rozpoznawać co dana metoda zwraca, jakiego
       typu jest itd..

       Metody(funkcje) są bardzo ważne, więc jeśli nie możesz zrozumieć jak działają, to nie uda Ci się
       pojąć dalszych kodów. Zatem postaraj się to zrozumieć w pierwszej kolejności :). 
       
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
       Zaakceptuj dobroć jaką oferuje metoda i nie bój się jej wykorzystywać - ratuje programistę :)
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

      =====> A więc, co bym chciał abyś zapamiętał/zapamiętała z tego tematu: <======
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

        Odpowiedzi poszukaj w notatce wyżej, przy okazji sobie powtórzysz materiał :D
*/
namespace metody_wstep
{
    class Program
    {
        // ********************************
        // kilka przykładów metod(funkcji)
        // ********************************


        public void MetodaPusta()
        {
            // metoda typu void nic nie zwraca
        }

        public int OddajLiczbe(int war)
        {
            // metoda typu int zatem musi zwrócić int(liczbe calkowita)
            // jeżeli jeszcze nie wiemy jaką zmienną  
            // będziemy zwracać to żeby nie wkurzał
            // podkreślony błąd można napisać return i 
            // wartosc w postaci typu który będziemy zwracać
            // czyli w tym przypadku liczba całkowita, to np. damy 3
            return 3;
        }

        public string PodajTekst(string okej)
        {
            okej = "czesc";
            // analogiczny przykład co powyzej tylko metoda ma zwrócić string
            // ja tu napisalem ze zwracamy tekst ze zmiennej okej
            return okej;
        }

        static void Main(string[] args)
        {
            // przykładowe stworzenie obiektu przy pomocy konstruktora domyślnego:
            Program obiekt = new Program();

            // słówko region(sprawdź sobie)
            #region Blok Tekstu
            // Ten kod tutaj jest w "bloku"/regionie
            // to moj tekst
            #endregion

            // twoje odpowiedzi, ćwiczenia umieszczaj tutaj


            Console.ReadLine();             // ta linijka sprawi, że okienko nie ucieknie po skompilowaniu
                                            // i wykonaniu poleceń
        }
    }
}
