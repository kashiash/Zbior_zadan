using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ====================================================
                       Treść zadania: 
    ====================================================
    1) Stwórz klasę Obsluga.
    2) Stwórz w niej metodę Zliczanie()
    3) W tej metodzie stwórz pętlę for w której:

    a) zadeklarujesz TYLKO RAZ zmienne: cena = 3; dlugosc = 10; rozmiar = 20

    b) stworzysz warunek, który będzie brzmiał: 
    "Jeżeli cena jest większa od długości i rozmiar jest większy od długości lub
     Jeżeli długość jest wieksza od ceny"
    
    c) stworzysz zwiekszanie/zmniejszanie: cena++; dlugosc--; rozmiar /= 5; 
    *Przy okazji, wiesz co oznacza skróty rozmiar /= 5 i dlugosc-- ? Rozpisz je :) 
    
    a w bloku instrukcji po prostu wypiszesz na ekran wartości tych liczb w takiej kolejności:
    Cena = ....
    Dlugosc = ....
    Rozmiar = .... 

    4) Stwórz obiekt za pomocą którego odwołasz się do metody. (To już wiesz pewnie tak?)
    5) Wywołaj metodę zliczanie()
    6) Sprawdź program i przeanalizuj jak działa
*/

namespace petla_for_multi
{
    class Obsluga
    {
        public void Zliczanie()
        {
            int cena, dlugosc, rozmiar;
            
            for (cena = 3, dlugosc = 10, rozmiar = 20; (cena > dlugosc && rozmiar > dlugosc) || dlugosc > cena; cena++, dlugosc--, rozmiar /= 5)
            {
                Console.WriteLine("\nCena = " + cena);
                Console.WriteLine("Dlugosc = " + dlugosc);
                Console.WriteLine("Rozmiar = " + rozmiar);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt
            Obsluga obiekt = new Obsluga();

            // wywołujemy metodę
            obiekt.Zliczanie();

            Console.ReadLine();
        }
    }
}
