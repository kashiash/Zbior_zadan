using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Stwórz klasę "Zwierzęta". Dodaj do niej kilka obiektów (minimum 3).
    Niech każdy obiekt ma przynamniej 2 parametry (np. nazwa, wiek..).
    Stwórz następnie tablicę obiektów i ją wyświetl.

    #! podpowiedz:
    tworzylismy tablice obiektow w taki sposob:

    nazwa klasy[] nazwa tablicy = {nazwa obiektu, nazwa obiektu}

    i pamietaj, ze aby wyswietlic elementy tablicy, musisz skorzystac z petli !
    (ktora bedzie indeks przesuwac po tablicy!!!)

    Zastanów się jak to wyglądało wszystko, od czego zacząć? Uporządkuj sobie wiedze,
    myśl fragmentami to znaczy: zbuduj kod idąc krok po kroku. Kombinuj. 

    Utrwalisz sobie w ten sposób:
    - Po co nam tablica obiektów?
    // żeby odwoływać się do kilku obiektów jednocześnie :)

    - Czemu akurat w pętli musimy wyświetlić obiekty z tablicy?
    // jeżeli chcemy wyświetlić dany "atrybut" każdego z obiektów to trzeba to zrobić w pętli
    // jeżeli chcemy informacje od jednego obiektu - nie musimy tak naprawdę...

    - Po co nam "klasa"?
    // aby mieć przygotowany "przepis" na stworzenie obiektu i go się trzymać
    // podczas tworzenia tych obiektów

    - Jak stworzyć obiekty klasy?
    // typowy sposób: nazwa klasy nazwa obiektu = new nazwa klasy();
    // ale możemy tez na inne sposoby... np. z parametrami

    - Jak przypisać do obiektów parametry np. wiek?
    // obiekt.wiek = 15; przykładowo lub tworząc obiekt za pomocą konstruktora parametrycznego

    - Co to indeks? Jak działa "indeks" w tablicy? Wyobraź sobie jak indeks chodzi po tablicy.
    // indeks to coś co wskazuje jakieś jedno miejsce, chodzi tak jak my będziemy tego sobie życzyć

    - Co to jest tablica jednowymiarowa?
    // mamy tylko jeden wymiar w który możemy wrzucać dane
    // czyli wyobrażamy sobie tablice mniej wiecej tak:  [][][][][][][][]

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
            // poprzez słówko this mówimy, że ta "konkretna" zmienna ma przechowywać wiek, imie
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
