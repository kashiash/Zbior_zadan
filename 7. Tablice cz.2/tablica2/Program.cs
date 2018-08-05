using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =================================
              Treść zadania:
    =================================
    Stwórz klasę "Zwierzęta". Dodaj do niej kilka obiektów (minimum 3).
    Niech każdy obiekt ma przynamniej 2 parametry (np. nazwa, wiek..).
    Stwórz następnie tablicę obiektów i ją wyświetl.

    =================================
             #! podpowiedzi:
    =================================

    tworzylismy tablice obiektow w taki sposob:

    nazwa klasy[] nazwa tablicy = {nazwa obiektu, nazwa obiektu}

    i pamietaj, ze aby wyswietlic elementy tablicy, musisz skorzystac z petli !
    (ktora bedzie indeks przesuwac po tablicy!!!)

    Pamiętaj aby podchodzić do zadania krok po kroku :)

    =================================
      Utrwalisz sobie w ten sposób:
    =================================
    - Po co nam tablica obiektów?
    // żeby odwoływać się do kilku obiektów jednocześnie

    - Czemu akurat w pętli musimy wyświetlić obiekty z tablicy?
    // jeżeli chcemy wyświetlić dany "atrybut" każdego z obiektów to trzeba to zrobić w pętli
    // jeżeli chcemy informacje od jednego obiektu - nie musimy, tak naprawdę...

    - Po co nam "klasa"?
    // aby mieć przygotowany "przepis" na stworzenie obiektu i go się trzymać
    // podczas tworzenia tych obiektów

    - Jak stworzyć obiekty klasy?
    // typowy sposób: nazwa klasy nazwa obiektu = new nazwa klasy();
    // ale możemy tez na inne sposoby... np. z parametrami(czyli za pomocą konstuktora parametrycznego)

    - Jak przypisać do obiektów parametry np. wiek?
    // obiekt.wiek = 15; przykładowo lub tworząc obiekt za pomocą konstruktora parametrycznego..

    - Co to indeks? Jak działa "indeks" w tablicy? Wyobraź sobie jak indeks chodzi po tablicy.
    // indeks to coś co wskazuje jakieś jedno miejsce, chodzi po tablicy tak jak my będziemy tego sobie życzyć
    // czy to np. po wartościach parzystych, czy co 4 czy ... no tyle ile sobie wymyślimy

    - Co to jest tablica jednowymiarowa?
    // mamy tylko jeden wymiar w który możemy wrzucać dane
    // czyli wyobrażamy sobie tablice mniej wiecej tak:  [][][][][][][][]
    
    ==================================================
    ?: Panie, a co z tablicami wielowymiarowymi?
    ==================================================

    Taaak. Mamy jeszcze coś takiego jak tablice wielowymiarowe, ale powiem Ci szczerze - jeszcze nie spotkałem się
    z sytuacją skorzystania z tablicy wielowymiarowej a sporo już przerobiłem programowania. Przyznam, że 
    raz skorzystałem z dwuwymiarowej w projekcie z Enigmą... ale po przemyśleniu sytuacji.. zdałem sobie
    sprawę że wystarczyła mi tablica jednowymiarowa. 

    zróbmy jednak taką "wspominkę" o tych tablicach, żebyś miał/miała świadomość o nich

    konstrukcja zadeklarowania tablicy wielowymiarowej z określeniem rozmiaru:
    typ_danych[,] nazwa_tablicy = new [x,y]
    gdzie za x i y podajesz liczby lub zmienne calkowite ktore przechowuja liczby..

    przykład:
    int[,] tabka = new int[3,2];

    dzięki czemu stworzymy tablice o wymiarach 3x2 czyli taką(obrazowo)
     
       0        1        2
    ---------------------------
    |       |        |        |  0
    |       |    3   |        |
    ---------------------------
    |       |        |        |  1
    |       |        |        |
    ---------------------------

     i dla przykładu, aby odwołać się do miejsca w tablicy gdzie jest zapisana nasza 3 musielibyśmy napisać:
     Console.WriteLine(tabka[1,0]);       => wypiszemy 3 na ekran w ten sposób

    ?: a jeżeli chcemy zadeklarować tablice wielowymiarową z przypisaniem elementów odrazu to możemy zrobić to tak:

    => przykład:
            int[,] tablicaWrym = new int[,] { { 5, 6, 7 }, { 1, 2, 1 } };
    
    otrzymamy w ten sposób taką tablicę:

        0       1
    -----------------
    |   5   |   1   |   0
    -----------------
    |   6   |   2   |   1
    -----------------
    |   7   |   1   |   2
    -----------------

    =================================
                Pamiętasz?
    =================================
      Tablice omówiliśmy w zadaniu 6. Tablice cz1
      (w razie potrzeby wróć do tego projektu)

    */

namespace tablica2
{
    // tu stwórz klasę

    class Pokaz
    {
        int wiek;
        string imie;

        // konstruktor parametryczny
        public Pokaz(int wiek, string imie)
        {
            this.wiek = wiek;
            this.imie = imie;
            // poprzez słówko /this/ mówimy, że ta "konkretna" zmienna ma przechowywać wiek, imie
            // działa to trochę jak a'la wskaźnik tylko wg. mnie łatwiejszy
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Wiek: " + wiek);
            Console.WriteLine("Imie: " + imie);
        }
    }

    class Program
    {
        int wiek;

        static void Main(string[] args)
        {
          
            // do sprawdzenia tablicy wielowymiarowej(odkomentuj jak chcesz sprawdzić)
            // int[,] tablicaWrym = new int[,] { { 5, 6, 7 }, { 1, 2, 1 } };
            // Console.Write("Element: " + tablicaWrym[0, 0]);

            /* PRZYKLADY */
            // w razie jeżeli przykłady będą Ci przeszkadzać,
            // usuń je 

            Program obiekt1 = new Program();
            Program obiekt2 = new Program();

            // 1: tablica obiektów klasy Program
            Object[] tablica = { obiekt1, obiekt2 };

            // 2: przypisanie do obiektów parametrów
            obiekt1.wiek = 15;
            obiekt2.wiek = 20;

            // 3: wyświetlenie parametru obiektu:
            Console.WriteLine("Wiek obiektu1 = " + obiekt1.wiek);

            // 4: utworzenie obiektów i nadanie im parametrów
            // wykorzystując konstruktor parametryczny

            Pokaz obiekt100 = new Pokaz(15, "Dariusz");
            Pokaz obiekt500 = new Pokaz(19, "Mariusz\n\n");

            // 5: przykładowe wyświetlenie parametrów
            obiekt100.WyswietlInformacje();



            Console.ReadLine();
        }
    }
}
