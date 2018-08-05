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
    */

namespace tablica2
{
    // tu stwórz klasę

    class Zwierzeta
    {
        // cechy klasy Zwierzeta
        public string imie;
        public int wiek;
    }

    class Program
    {

        static void Main(string[] args)
        {
            // tworzymy obiekty
            Zwierzeta lis = new Zwierzeta();
            Zwierzeta pies = new Zwierzeta();
            Zwierzeta kot = new Zwierzeta();

            // nadajemy obiektom cechy
            lis.imie = "Leszek";
            lis.wiek = 15;

            pies.imie = "Chappie";
            pies.wiek = 22;

            kot.imie = "Garfield";
            kot.wiek = 7;

            // tablica Obiektów
            Zwierzeta[] tablicaObiektow = { lis, pies, kot };
            
            // wyświetlmy tablicę Obiektów za pomocą pętli for
            for(int i = 0; i < tablicaObiektow.Length; i++)
            {
                Console.Write("Imie zwierzecia: " + tablicaObiektow[i].imie + ", wiek zwierzecia " + tablicaObiektow[i].wiek);

                // robimy nową linię
                Console.Write("\n");
            }
            
            Console.ReadLine();
        }
    }
}
