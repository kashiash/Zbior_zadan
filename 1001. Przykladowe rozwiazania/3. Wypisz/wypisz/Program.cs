using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       -------------------------
       Rozwiązanie(inny sposób)
       -------------------------

       Treść zadania:
       Napisz metode w klasie dane ktora wypisze na ekran imie i nazwisko uzytkownika ktore podal w pieknej oprawie.
       Pamietaj! To metoda ma wyswietlic dane ktore wpisal uzytkownik!

       Co znaczy piekna oprawa?
       A no jak uzytkownik poda
       Pawel
       Kowalski

       to wypisze sie:
       Twoje imie to: Pawel
       Nazwisko: Kowalski
    */

namespace wypisz
{
    class Dane
    {
        public void Wypisz()
        {
            Console.Write("Imie? ");
            string imie = Console.ReadLine();

            Console.Write("\nNazwisko? ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("\nTwoje imie to:  " + imie);
            Console.WriteLine("Nazwisko:  " + nazwisko);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {    
            // stworzenie obiektu klasy Dane o nazwie wywolaj
            Dane wywolaj = new Dane();

            wywolaj.Wypisz();

            Console.ReadKey();
        }
    }
}
