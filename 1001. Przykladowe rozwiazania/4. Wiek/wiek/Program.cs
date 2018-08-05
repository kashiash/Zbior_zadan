using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Napisz metode w klasie wiek ktora policzy wiek uzytkownika. 
    Zapytaj go o date urodzenia a nastepnie program ma zapytac "Masz x lat. Dobrze mowie?". 
    Jesli uzytkownik napisze tak to napisze na ekran "Jeeej zgadlem!" jesli uzytkownik napisze
    nie to na ekranie pokaze sie "A niech to...".

    Dodatkowe zadanie: Stwórz konstruktor domyślny. Zadeklaruj go jawnie.
                                                    (jawnie oznacza, że ma być publiczny)
    
    uwaga,podpowiedz:
    Aby pobrac dzisiejsza date skorzystaj z funkcji DateTime.Now

    przykladowo:
    rok mozemy zapisac tak: 
    double rok = DateTime.Now.Year;
    */

namespace wiek
{
    // tu deklaruj klase
    class Wiek
    {
        // konstrukor domyślny zadeklarowany jawnie
        // bez zawartości, mieliśmy tylko go zadeklarować
        public Wiek() { }

        // metoda obliczenia wieku
        public void ObliczWiek(double dataUr)
        {
            double rok = DateTime.Now.Year;
            Console.WriteLine("To masz w takim razie: " + (rok - dataUr) + " lat(a)!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tu stworz obiekt klasy
            Wiek obiekt = new Wiek();

            Console.Write("Podaj rok urodzenia: ");
            double mojWiek = Convert.ToInt32(Console.ReadLine());

            obiekt.ObliczWiek(mojWiek);  

            Console.ReadLine();
        }
    }
}
