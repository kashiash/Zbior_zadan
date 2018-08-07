using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==============================================
                    Treść zadania:
    ==============================================
    1. Stwórz klasę Testowanie
    2. Stwórz w niej metodę Zrob_gdy() 
    3. W stworzonej metodzie skonstruuj pętle do... while według tego pseudokodu:

    do 
    {
    wypisuje 'Ja sie wykonuje w bloku instrukcji. Pss, to gdzie teraz pisze to blok instrukcji w tych 
    klamrach'

    wypisuje 'Ej ja tez nadal jestem w bloku instrukcji'
    }
    while (x != 0)

    Tylko zadeklaruj nad petla, zmienną x. 

    4. Standardowo, stworz obiekt. Zrób to za pomoca konstruktora domyślnego.

    5. Wywołaj metodę Zrob_gdy().
    a) gdy zmienna x, w metodzie wynosi: x = 0
    b) gdy zmienna x, w metodzie wynosi: x = 1

    6. Czy takich efektów się spodziewałeś? Jak nie, to spróbuj przetłumaczyć sobie "ręcznie" powyższą
    pętlę. Jak tak to i tak spróbuj to przetłumaczyć, żebyś na przyszłość wiedział jak taką pętlę 
    napisać. Ta pętla nie jest taka trudna a może się czasem przydać z racji właśnie tego, że
    [jak brzmi definicja...] WYKONA się minimum jeden raz niezależnie od tego czy warunek prawdziwy
    czy nie! 
    
    ============================================================================================
                                       Zadanie dodatkowe:
                                 do samodzielnego rozwiązania:)
    ============================================================================================
*/

namespace do_while_1
{
    class Testowanie
    {
        public void Zrobgdy()
        {
            // sprawdź raz ustawiając tutaj x na 0 a raz x na 1 jaki będzie 
            // efekt działania programu i wyciągnij odpowiednie wnioski z 
            // tej pętli:) 
            int x = 0;

            do
            {
                Console.WriteLine("Ja sie wykonuje w bloku instrukcji. (to gdzie teraz pisze w klamarach");

                Console.WriteLine("Ej ja tez jestem nadal w bloku instrukcji");
            }
            while (x != 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Testowanie obiekt = new Testowanie();

            obiekt.Zrobgdy();

            Console.ReadLine();
        }
    }
}
