using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Treść zadania:
       Napisz metode w klasie dane ktora wypisze na ekran imie i nazwisko uzytkownika ktore podal w pieknej oprawie.
       Pamietaj! To metoda ma wyswietlic dane ktore wpisal uzytkownik!

       Co znaczy piekna oprawa?
       A no jak uzytkownik poda
       Pawel
       Idzikowski

       to wypisze sie:
       Twoje imie to: Pawel
       Nazwisko: Idzikowski

       To zadanie pozwoli ci przypomnieć sobie:
       - jak tworzyć metodę, 
       - jak wypisać tekst, 
       - jak pobrać tekst, 
       - jak tworzyć klasę, 
    */

namespace wypisz
{
    class Dane
    {
        public int Wypisz(string a, string b)
        {
            
            Console.WriteLine("Twoje imie to: " + a);
            Console.WriteLine("Twoje nazwisko to: " + b);

            return 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Dane wywolaj = new Dane();

            Console.WriteLine("Podaj imie:");
            string x = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string y = Console.ReadLine();

            wywolaj.Wypisz(x, y);

            Console.ReadKey();
        }
    }
}
