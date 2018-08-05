using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Napisz metode w klasie zlicz ktora zsumuje trzy liczby podane przez uzytkownika.
    Niech twoja metoda zwraca wartosc typu float.

    jak ma działać?
    podaj liczbe1: 
    podaj liczbe2: 
    podaj liczbe3:
    wynik 2,3 + 5 + 5,3 = 12,6
*/

namespace liczenie
{
    // tu leci klasa od Ciebie 
    class Zlicz
    {
        public float ZwrocSume(float a, float b, float c)
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tu stworzyć musisz obiekt który będzie odwoływał się do klasy
            Zlicz obiekt = new Zlicz();

            Console.Write("\nPodaj liczbe1\n(uwaga: używaj przecinka, jeśli chcesz podać liczbę przecinkową): ");
            float liczba1 = float.Parse(Console.ReadLine());

            Console.Write("\nPodaj liczbe2: ");
            float liczba2 = float.Parse(Console.ReadLine());

            Console.Write("\nPodaj liczbe3: ");
            float liczba3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Wynik " + liczba1 + "+" + liczba2 + "+" + liczba3 + "=" + obiekt.ZwrocSume(liczba1, liczba2, liczba3));
            

            Console.ReadLine(); // potrzebne aby nam okienko nie ucieklo po skompilowaniu
                                // ewentualnie mozemy uzyc Console.ReadKey();
        }
    }
}
