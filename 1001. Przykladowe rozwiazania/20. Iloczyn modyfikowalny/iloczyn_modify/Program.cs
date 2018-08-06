using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ================================================================
                             Treść zadania:
    ================================================================
    Jako, że poznałeś/poznałaś już działanie pętli for, oraz działanie metod n możemy
    przejść do następnego poziomu. Tutaj również będziesz musiała/musiał wykorzystać tablicę i indeksy, które
    także już poznałeś/poznałaś. 

    Zatem...

    Twoim zadaniem jest stworzyć program który obliczy iloczyn tylu liczb ile poda użytkownik, czyli może np. 
    użytkownik chce zrobić tak: 4 * 4 * 2 albo 3 * 5 * 10 * 5 ... itd... Ogranicz jednak rozmiar swojej tablicy
    do 100 elementów Tak, aby przechować te wszystkie liczby, które poda użytkownik wykorzystamy tablicę.

    1. Stwórz klasę Iloczyn

    2. W funkcji main stwórz tablicę, do której użytkownik będzie wpisywał liczby, które chce wymnożyć.
    Jeśli użytkownik wpisze "koniec" to program wywoła funkcje Mnożenie_modyfikowalne z klasy Iloczyn!

    3. Stwórz metodę Mnożenie_modyfikowalne, które przyjmie tablicę liczb, które wpisał użytkownik.

    4. Za pomocą pętli for w tej metodzie wymnażaj kolejne elementy aż do otrzymania wyniku. 
       Zastanów się jak rozwikłać problem warunku w pętli for. Mógłby brzmieć tak:
       "i < zlicz" gdzie zlicz to liczba elementów ile podał użytkownik do przemnożenia.

       a więc propozycja: zmodyfikuj wygląd swojej metody mnożenie_modyfikowalne i dodaj do niej argument:
       int zlicz czyli będzie tak: mnożenie_modyfikowalne(int tablica, int zlicz). Zlicz będzie zwiększane
       za każdym razem gdy użytkownik poda liczbę. Teraz to zaimplementuj.

    5. Pamiętaj o stworzeniu obiektu aby odwołać się do swojej metody oczywiście z klasy iloczyn.
       lub ustaw metodę jako statyczną(static)

    6. Wyświetl wynik mnożenia. Możesz dorzucić metodę void, która wypisze go, bądź skorzystać z klasycznego
    Console.Writeline... 

    ================================================================
                            Utrwalisz sobie:
    ================================================================
    - wszystko o tablicach jednowymiarowych
    - co to jest indeks w tablicy
    - jak działa pętla for, jak ją budujemy
    - co to metoda, klasa, obiekt?
*/

namespace iloczyn_modify
{
    class Iloczyn
    {
        public static void MnozenieMod(int[] tablica, int zlicz)
        {
            int wynik = 1;

            for(int i = 0; i < zlicz; i++)
            {
                Console.WriteLine("tablica[" + i + "]=" + tablica[i]);
                wynik = wynik * tablica[i];
            }

            Console.WriteLine("Wynik mnożenia podanych liczb: " + wynik);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb = new int[100];

            int licznik = 0;

            Console.WriteLine("Iloczyn modyfikowalny");
            Console.WriteLine("Podawaj liczby(max 100) potwierdzając każdą przyciskiem ENTER");
            Console.WriteLine("Uwaga: Aby skończyć wpisywanie liczb wpisz 0 i potwierdź ENTER");
            // wiemy że cokolwiek pomnożone przez 0 daje 0 więc po co mielibyśmy mnożyć kilkanaście
            // liczb po to żeby pomnożyć je przez 0 i otrzymać wynik końcowy 0 ? - możemy zatem
            // skorzystać z 0 jako "wyjścia" z trybu wpisywania liczb

            for(int i = 0; i < tablicaLiczb.Length; i++)
            {
                int liczba = Convert.ToInt32(Console.ReadLine());

                if(liczba == 0)
                {
                    Iloczyn.MnozenieMod(tablicaLiczb, licznik);
                    break;
                }

                tablicaLiczb[i] = liczba;
                licznik++;
            }

            Console.ReadLine();
        }
    }
}
