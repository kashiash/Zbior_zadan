using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ===================================
               Treść zadania:
    ===================================
    1. Stwórz klasę samochody.
    2. Stwórz konstruktor domyślny w klasie samochody.
    3. Ustaw ten konstruktor na prywatny.
    4. Stwórz konstruktor parametryczny o argumentach:
    - string marka;
    - double poj_Silnika;
    - int rocznik;
    - int przebieg;
    5. Stwórz trzy obiekty za pomocą konstruktora parametrycznego.
    6. Wyświetl te obiekty w ustalony przez siebie sposób. Pełna dowolność.

     ===================================
               Utrwalisz sobie:
     ===================================
    -> Jak tworzymy klasę? Co to jest klasa? 
    -> Co to jest konstruktor domyślny a co to konstruktor parametryczny? 
    -> Typy dostępów do pól i metod. Jakie są? Gdzie mamy do nich dostęp?
    -> w jaki sposób wyświetlić dane obiektów?
*/

namespace konstr_para
{
    class Samochody
    {
        public string marka;
        public double poj_Silnika;
        public int rocznik;
        public int przebieg;

        // przypomnienie:
        // nie podając żadnego modyfikatora domyślnie dostaje modyfikator "private"
        Samochody() { }

        public Samochody(string marka, double poj_Silnika, int rocznik, int przebieg)
        {
            this.marka = marka;
            this.poj_Silnika = poj_Silnika;
            this.rocznik = rocznik;
            this.przebieg = przebieg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekty za pomocą konstruktora parametrycznego
            Samochody bmw = new Samochody("BMW", 2100, 2005, 200000);
            Samochody honda = new Samochody("HONDA", 1660, 1999, 250000);
            Samochody toyota = new Samochody("TOYOTA", 1410, 2003, 150000);

            // tablica obiektów
            Samochody[] tablicaObiektow = { bmw, honda, toyota };

            // zastosujmy petle for
            for(int i = 0; i < tablicaObiektow.Length; i++)
            {
                Console.WriteLine("Marka: " + tablicaObiektow[i].marka);
                Console.WriteLine("Pojemnosc silnika: " + tablicaObiektow[i].poj_Silnika);
                Console.WriteLine("Przebieg: " + tablicaObiektow[i].przebieg);
                Console.WriteLine("Rocznik: " + tablicaObiektow[i].rocznik);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
