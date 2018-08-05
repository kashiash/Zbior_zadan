using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ========================
          Treść zadania:
    ========================
    Napisz metode w klasie wynik ktora wypelni tablice liczbami calkowitymi od 1 do ....20 (czyli tablica 20 elementowa).
    Nastepnie wyswietl ta tablice i pokaz w jakim indeksie jaka liczba sie znajduje.np. tablica[0] = 1;

    ========================
         przypomnienie:
    ========================
    deklaracja tablicy wyglada tak:
    string[] nazwa = new string[5];
    (to jest tablica typu string, która ma 5 miejsc,
    indeksując oczywiście od 0 czyli mamy o tak: 0 1 2 3 4)
    */
namespace tablice1
{
    class Wynik
    {
        public static void WypelnijTablice(int[] tablicaLiczb)
        {

            int j = 0;

            // wpisz liczby do tablicy
            // jako że chcemy wpisać elementy od 1 do 20 to musimy
            // zadbać o dwie oddzielne zmienne - jedna która będzie
            // pilnować pozycje w tablicy(czyli j) stąd zadeklarowaliśmy
            // ją wyżej abyś to widział(a) oraz drugą która
            // odpowiednie wartości wrzuci do tablic(czyli i)

            for(int i = 1; j < tablicaLiczb.Length; i++, j++)
            {
                tablicaLiczb[j] = i;
            }

            // działanie tej pętli(kilka pierwszych kroków)
            // i=1
            // j=0 
            // 0 < 20? - TAK
            // tablicaLiczb[0] = 1;
            // zwiększamy..
            // i=2
            // j=1
            // 1 < 20? - TAK
            // tablicaLiczb[1] = 2;
            // itd...
            // i=3
            // j=2
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // stworzenie tablicy liczb całkowitych(20 elementowa)
            int[] mojaTablica = new int[20];

            // wywołanie metody statycznej
            Wynik.WypelnijTablice(mojaTablica);

            // wypisanie na ekran elementów tablicy w odpowiednim
            // formacie
            for(int i = 0; i < mojaTablica.Length; i++)
            {
                Console.WriteLine("tablica[ " + i + "] = " + mojaTablica[i]);
            }

            Console.ReadLine();
        }
    }
}
