using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =============================================
                    Treść zadania: 
    =============================================
    Zatem, chcemy stworzyć program, który wypisze słowo, które wprowadził użytkownik. Ale! Żeby wykorzystać
    naszą pętlę do while... zalóżmy sobie, że jeśli użytkownik wpisze koniec to koniec ma się wyświetlić i
    dopiero program ma się skończyć. Przy okazji stworzymy powiedzmy: licznik komend, zmienną która będzie
    pokazywać, którą z kolei komenede już wpisujemy, okej? No to jak wiesz jak będzie mniej wiecej działać
    nasz kod, bierzemy się za robotę. :D

    1. Stwórz klasę Konsola.

    2. Stwórz metodę, Do_while_dwa()

    Twoja metoda ma być zbudowana w taki sposób:

    pobierasz od użytkownika zmienną typu string
    deklarujesz zmienną typu całkowitego która będzie pokazywała która komenda już to jest((np. licznik_komendy)

    a w pętli do while... pseudokod:

    do
    {
        wypisuje na ekran licznik_komendy - wypisz na ekran slowo ktore podal uzytkownik  to np. tak wyswietla (1 - golabek)
        licznik_komendy++;
    }
    while(slowo ktore podal uzytkownik nie jest 'koniec')

    3. Stwórz obiekt, dzięki któremu będzie można wywołać metodę.

    4. Wywołaj metodę i sprawdź jak działa pętla do...while.


    Jeśli chcesz, zmodyfikuj swój program aby troszkę bardziej skomplikowane zadania wykonywał. 
    Wymyśl coś sama :). 

    A więc zapamiętaj pętlę do...while, jak działa, bo może kiedyś Ci się przyda. Zapamiętaj jaka jest
    różnica między nią a innymi pętlami (while, for) ... naprawdę warto znać je wszystkie bo czasem 
    może się okazać że będziemy potrzebować innego efektu niż to zwykle bywa 
*/
namespace do_while_2
{
    class Konsola
    {
        public void DoWhileDwa()
        {
            int licznik = 1;

            Console.WriteLine("Podaj napis: ");
            Console.WriteLine("Aby zakończyć napisz koniec");
            string napis = Console.ReadLine();

            do
            {
                Console.WriteLine(+licznik + " " + napis);
                licznik++;

                Console.WriteLine("Podaj kolejny napis lub koniec aby zakończyć");
                napis = Console.ReadLine();
            }
            while (napis != "koniec");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt
            Konsola obiekt = new Konsola();

            // wywołujemy naszą metodę
            obiekt.DoWhileDwa();

            Console.WriteLine("\nwyszedles z petli do..while\nnacisnij dowolny klawisz aby wylaczyc program");
            Console.ReadLine();
        }
    }
}
