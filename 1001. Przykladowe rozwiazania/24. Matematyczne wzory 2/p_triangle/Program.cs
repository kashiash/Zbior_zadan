using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ============================================================================
                                   Treść zadania:
    ============================================================================
    Wykorzystajmy dotychczasową wiedzę do stworzenia matematycznego programu 2!

    Stwórz klasę Matematyka a w niej metodę Policz_pole(int a, int h)         
    Metoda Policz_pole ma liczyć pole trójkąta z danych, które poda użytkownik. 
    Ma następnie wyświetlić użytkownikowi wynik. Sposób wykonania tego programu
    jest dowolny prócz tego co zostało nałożone wyżej. Powodzenia.

    Chcemy by Twój program ma działać cały czas!
    To znaczy, po obliczeniu jednego
    pola znowu pyta użytkownika o dane
    do policzenia pola, a jeżeli użytkownik
    nie chce już podawać kolejnego pola to żeby
    była możliwość wyjścia z niej(to wykorystamy
    instrukcję break w instrukcji warunkowej if) 
*/

namespace p_triangle
{
    class Matematyka
    {
        public static void PoliczPole(int a, int h)
        {
            int wynik = 0;

            for (int i = 0; i < 1;)
            {
                wynik = (a * h) / 2;
                Console.WriteLine("Twoje pole: " + wynik);

                Console.WriteLine("Podaj bok albo wyjdź z gry(wpisz wtedy 0)");
                a = Convert.ToInt32(Console.ReadLine());
                if(a == 0)
                {
                    break;
                }

                Console.WriteLine("Podaj wysokość: ");
                h = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczanie pola trójkąta(który nie jest równoboczny)");
            Console.WriteLine("Podaj bok: ");
            int bok = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc: ");
            int wys = Convert.ToInt32(Console.ReadLine());

            Matematyka.PoliczPole(bok, wys);

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby wyjsc...");
            Console.ReadLine();
        }
    }
}
