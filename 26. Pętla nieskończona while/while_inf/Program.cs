using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ================================================
                    Treść zadania:
    ================================================
    Jak wiesz lub nie pętla nieskończona oznacza, że będzie wykonywała swoje instrukcje cały czas. 
    W tym programie skorzystasz z takiej możliwości w pętli while, chociaż pewnie dotychczas już 
    ją wykorzystywałeś to w takim razie zadanie będzie proste. 
    
    *W razie co cofnij się do zadania 5, przy okazji potegi omowilismy tam petle nieskoczona while
    *i podany zostal rowniez przyklad takiej petli w kodzie:)

    a więc...
    1. Stwórz klasę Petle
    2. Stwórz metodę Nieskonczona_petla() 
    3. W metodzie Nieskonczna_petla() stwórz pętle while, która dopóki będzie prawdziwa, wypisze na
    ekran Kotek. Więc aby stworzyć Pętlę nieskończną musimy ustawić
    jej warunek na sztucznie prawdziwy. Jak to robimy?

    Zapamiętaj raz a dobrze:
    W C# wystarczy w warunku napisać słowo true aby otrzymać pętlę nieskończoną np. while(true)
    bądź wystarczy napisać warunek który zawsze będzie prawdziwy np. x == 5 , ustawiamy x = 5 
    i nie zmieniamy x. Wtedy cały czas warunek będzie prawdziwy. Sprawdź sobie oba przypadki
    żeby Ci się lepiej utrwaliły. 
    
    4. Stwórz konstruktor statyczny (dla przećwiczenia).
    5. Za pomocą konstruktora statycznego stwórz obiekt.
    6. Wywołaj funkcję Nieskonczona_petla(). Skompiluj program i uruchom. 
    7. Zaobserwuj efekt. 

    ================================================
          A więc utrwalisz sobie/powtórzysz:
    ================================================
    - Wszystko o pętli While
    - Metoda typu void - czym jest, jak ją użyć?
    - Jak tworzymy pętlę nieskończoną sztucznie? (dwa sposoby)
    - Jak tworzymy klasę, metodę, obiekt, konstruktor statyczny i definicje tych pojęć.

    ==================================================================
    PO ZADANIU ! 
    Dodatek:
    Jak wykonasz już główne zadanie, to teraz polecam Ci sprawdzić czy rzeczywiście ta teoria
    powyżej ma sens na podstawie doświadczenia.

    stwórz zmienną typu całkowitego np. int liczba = 10, i daj w warunku while(liczba) A
    w środku pętli umieść liczba--.

    twój program ma na ekran drukować kolejno te liczby, czyli powinien zrobić tak:
    10
    9
    8
    .... itd.. (czyli te liczby ze zmiennej int liczba tak?)

    Te doświadczenie pokaże Ci, że gdy pętla natrafi na 0, zakończy działanie (a więc nie będzie nieskończona).
*/

namespace while_inf
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
