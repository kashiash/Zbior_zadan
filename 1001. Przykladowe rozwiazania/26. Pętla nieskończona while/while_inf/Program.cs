using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
    ================================================
                    Treść zadania:
    ================================================
    1. Stwórz klasę Petle
    2. Stwórz metodę Nieskonczona_petla()  
    3. W metodzie Nieskonczna_petla() stwórz pętle while, która dopóki będzie prawdziwa, wypisze na
    ekran Kotek. Więc aby stworzyć pętlę nieskończną musimy ustawić
    jej warunek na sztucznie prawdziwy. Jak to robimy?
    4. Stwórz konstruktor statyczny (dla przećwiczenia).
    5. Za pomocą konstruktora statycznego stwórz obiekt.
    6. Wywołaj funkcję Nieskonczona_petla(). Skompiluj program i uruchom. 
    7. Zaobserwuj efekt. 

    ==========================================================
           Dodatek do samodzielnego przerobienia :)
    ==========================================================

*/

namespace while_inf
{
    class Petle
    {
        // konstruktor statyczny dla przećwiczenia
        public static Petle KonstruktorStatyczny()
        {
            return new Petle();
        }

        public void NieskonczonaPetla()
        {
            while(true)
            {
                Console.WriteLine("Kotek");

                // spowolnijmy działanie pętli
                // abyśmy nie dostali paranoi od pojawiającego się błyskawicznie tekstu 
                // a zobaczymy że pętla nieskończona będzie się wywoływać przez cały czas
                // działania naszego programu
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt za pomocą konstruktora statycznego
            Petle obiekt = Petle.KonstruktorStatyczny();

            // wywolujemy nieskonczona petle
            obiekt.NieskonczonaPetla();

            Console.ReadLine();
        }
    }
}
