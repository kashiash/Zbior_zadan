using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =========================
          Treść zadania:
    =========================
    Jak już poznałeś/poznałaś zasadę działania instrukcji switch, wykorzystamy ją teraz to ciut większego programu.

    1. Stwórz klasę blok_decyzyjny.
    2. Stwórz metody:
    - decyzja(int wybor)
    - przedstawienie_sie()
    - iloczyn_2liczb()
    - pokaz_informacje()
    Zastanów się czy muszą coś zwracać, czy może nic? jaki typ danych im nadać jeśli coś zwracają?

    3. Pseudokod dla metody decyzja(int wybor):

    switch(wybor)
    {
    case 1:
           przedstawienie_sie()
           break;
    case 2:
           iloczyn_2liczb()
           break;
    case 3:
           pokaz_informacje()
           break;
    default:
           wypisz 'Nie wybrano nic'
           break;
    }

    4. Pseudokod dla metody przedstawienie_sie():
    wypisuje na ekran:
    'Czesc, jestem kompilator i wykonuje caly ten kod od gory do dolu.
    Pamietam ze == to sprawdzenie czy lewa = prawej stronie a jeden 
    znak = to operator przypisania!'

    5. Pseudokod dla metody iloczyn_2liczb():
    prosi uzytkownika o podanie 1 liczby
    wczytuje liczbe 1
    prosi uzytkownika o podanie 2 liczby
    wczytuje liczbe 2 
    wykonuje dzialanie liczba 1 * liczba 2 i podaje wynik.

    6. Pseudokod dla metody pokaz_informacje():
    wypisuje na ekran:
    'Kompilator 2.0, C#'
    'Visual Studio 2017 Community'

    7. Stwórz obiekt.

    8. Wywołaj metodę decyzja od wyboru który podał użytkownik.

    9. Przetestuj czy wszystkie funkcje działają prawidłowo.

    ==================================================
                    Utrwalisz sobie:
    ==================================================
    - wszystko o instrukcji switch
    - Co to takiego metoda, klasa, obiekt?
    - Co to takiego break?
    - Co to takiego metoda typu void?
*/

namespace switch_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
