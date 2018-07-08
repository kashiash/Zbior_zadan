using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    1. Stwórz klasę Zwierzeta
    2. Napisz konstruktor domyślny, ustaw go na prywatny.
    3. Napisz konstruktor statyczny bądź parametryczny(publiczny), aby móc jakoś tworzyć obiekty...
    4. W klasie zwierzęta stwórz pola:
    - string nazwa_zwierzaka;
    - int wiek_zwierzaka;
    - int rok_ur;
    - double waga;
    - string kolor;
    - string gatunek;
    zastanów się czy lepiej te pola dać publiczne czy prywatne, a jeśli inne to jakie?
    5. Stwórz trzy dowolnie ustalone przez siebie obiekty.
    6. Stwórz metodę zlicz_wartosc, która będzie przyjmować argumenty: wiek_zwierzaka, nazwa_zwierzaka, kolor
    7. W metodzie masz zastosować wzór dzieki któremu policzysz ile warte jest twoje zwierze (chodzi o cenę...)

    Jeśli kolor będzie złoty to wzór dodatkowo pomnożony zostanie przez 4 czyli: (wiek_zwierzaka * 0.1 + 3.14)*4
    Jeśli kolor będzie inny niż złoty to wzór będzie następujący: wiek_zwierzaka * 0.1 + 3.14

    8. Stworzyć tablicę obiektów. 
    9. Wyświetlić dane tych obiektów i wywołać dla nich metodę zlicz. 

    Zastanów się i dokonaj researchu ewentualnego - a następnie sobie odpowiedz tutaj albo do notatnika wpisz:
    - jakie mamy sposoby dostępu do zmiennych, metod i jak działają (public, private, internal, protected)
      (odsyłamy do Zadania 0) :)
    - co to konstruktor domyślny, konstruktor statyczny, konstruktor parametryczny. Czym się wyróżniają?
    - co znaczy "this"? 
      #pełni rolę takiego wskaźnika - mówi dosłownie, że ta konkretna wartość ma być wzięta, użyteczne
      przy klasach i metodach w tych klasach jak bierzemy np. jakąś wartośc z main do metody z klasy ;)
    - jak tworzyć obiekty?
    - Co to jest instrukcja warunkowa? Jak wygląda? Jak działa?
    - CO to jest || a co &&. Czy jest różnica między & a && i | a || ? 
    - Co to jest ~?
    - Co znaczy operator != (NOT)?

    && - AND (koniunkcja)
    || - OR (alternatywa)
   
*/
namespace zwierzeta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
