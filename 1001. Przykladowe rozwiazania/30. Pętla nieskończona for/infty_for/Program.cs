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
*/
namespace infty_for
{
    class Cwiczenie
    {
        public void InftyFor()
        {
            for(int i = 0; i < 1; )
            {
                Console.WriteLine("\nPodaj liczbe1: ");
                int liczba1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj liczbe2: ");
                int liczba2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wynik: " + (liczba1 + liczba2));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt
            Cwiczenie obiekt = new Cwiczenie();

            // wywolujemy metode
            obiekt.InftyFor();

            Console.ReadLine();
        }
    }
}
