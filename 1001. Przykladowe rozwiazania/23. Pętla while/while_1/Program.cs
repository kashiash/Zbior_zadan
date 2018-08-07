﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
    =================================
              Treść zadania:
    =================================
    Wiemy już na czym polega pętla for. Teraz czas zapoznać się z kolejną pętlą czyli while. Pętla którą
    dziś się zajmiemy ma coś wspólnego z pętlą for! Co? A już mówię. Obie pętle zanim wejdą do bloku
    instrukcji to sprawdzają warunek, czy jest prawdziwy, jeśli tak to spoko a jeśli warunek jest
    fałszywy to po prostu omijamy pętlę albo nie wykonujemy kolejny raz. W ranach informacji: potem
    zapoznasz się z pętlą, która najpierw wykonuje instrukcje a potem sprawdza warunek (może wiesz już jaka)
    ale to potem, żeby nie mącić. :)

    1. Stwórz klasę Testy
    2. Stwórz metodę Petla()   
    3. W metodzie Petla() poproś uzytkownika o liczbe, a następnie napisz pętlę while, która  wypisze wszystkie 
    liczby od niej mniejsze. Warunek jest taki ze podana liczba nie moze byc wieksza niz 19. 

    przyklad:
    Podaj liczbe:
    5
    5
    4
    3
    2
    1
    0
    Wszystkie mniejsze elementy wypisane poprawnie!

    4. Stwórz obiekt w dowolny sposób, a następnie wywołaj metodę petla().
    (lub uczyń metodę Petla statyczna... tak też można)

    5. Przetestuj ją.


    =================================
                 Część II. 
    =================================
    Skoro udało Ci się skomponować powyższą metodę, może udoskonalnmy program, aby jeszcze przećwiczyć
    manipulowanie pętlą while, okej? A więc... Do metody, którą masz dorzuć drugą pętlę while, która 
    z kolei wypisze liczby na odwrót czyli jak np. podasz 18 to ona wypisze 1. 2. 3 itd... aż do 18!
    Pomyśl jaki warunek dać, jak to zrobić. :) 

    przyklad:
    Podaj liczbe
    6
    0
    1
    2
    3
    4
    5
    6
*/
namespace while_1
{
    class Testy
    {
        public static void Petla()
        {
            Console.WriteLine("Podaj liczbe: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int kopia = liczba;
            int start = 0;

            // robimy nową linię
            Console.WriteLine();

            while(liczba >= 0)
            {
                Console.WriteLine(liczba);
                liczba--;
            }

            Console.WriteLine("\n\nLiczby na odwrót");

            while(start <= kopia)
            {
                Console.WriteLine(start);
                start++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // wywolujemy metode statyczna dzieki czemu nie musimy
            // obiektu tworzyć
            Testy.Petla();

            Console.ReadLine();
        }
    }
}
