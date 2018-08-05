using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==================================
               Treść zadania:
    ==================================
    Napisz w klasie fibonacci dwie metody, które będą nazywać się: fib_rekurencyjnie, fib_iteracyjnie. Program
    ma się zapytać w pierwszej kolejności użytkownika jak woli policzyć n-ty element ciągu czy rekurencyjnie
    czy iteracyjnie W zależności od wyboru program liczy n-ty element korzystając ze sposobu, który wybrał użytkownik. 

    założenia ciągu Fibonacciego: 
    F0 = 0
    F1 = 1

    wzór:
    Fn = Fn-1 + Fn-2
*/
namespace fibb_rek_ite
{
    class Fibonacci
    {
        public static int Fib_rekurencyjnie(int n)
        {
            if(n <= 2)
            {
                return 1;
            }

            return Fib_rekurencyjnie(n - 2) + Fib_rekurencyjnie(n - 1);
        }
        #region  przykładowe działanie iteracyjne(rozwiń aby zobaczyć)
        // załóżmy, że n = 3
        // 3 <= 2? NIE
        // return Fib_rekurencyjnie(1) + Fib_rekurencyjnie(2);

        // skupiamy się na Fib_rekurencyjnie(1)
        // 1 <= 2? TAK
        // return 1

        // skupiamy się na Fib_rekurencyjnie(2)
        // 2 <> 2? TAK
        // return 1

        // zatem odpowiedź:
        // return 1 + 1
        // czyli 2
        #endregion

        public static void Fib_iteracyjnie()
        {
            Console.WriteLine("Który element ciągu Fibonacciego policzyć?");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int a = 0;  
            int b = 1;
            int wynik = 0;

            // jeżeli chcemy policzyć element 0 lub 1 
            // odpowiedź jest znana odrazu
            if(liczba < 2)
            {
                wynik = liczba;
            }
            else
            {
                 for(int i = 2; i <= liczba; i++)
                 {
                     wynik = a + b; // podstawiamy pod wynik sumę poprzednią
                     a = b;         
                     b = wynik;
                 }
            }

            Console.WriteLine("\n\nWynik = " + wynik);
        }
        #region przykładowe działanie iteracyjne(rozwiń aby zobaczyć) 

        // liczba = 3
        // a = 0
        // b = 1
        // wynik = 0
        // liczba < 2? NIE

        // i = 2
        // 2 <= 3? TAK
        // wynik = 0 + 1
        // a = 1
        // b = 1

        // i = 3
        // 3 <= 3? TAK
        // wynik = 1 + 1
        // a = 1
        // b = 2

        // i = 4
        // 4 <= 3? NIE
        // koniec
        // wynik = 2
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz sposób policzenia n-tego elementu ciągu Fibonacciego");
            Console.WriteLine("1. Iteracyjnie\n2. Rekurencyjnie");
            int decyzja = Convert.ToInt32(Console.ReadLine());

            if(decyzja == 1)
            {
                Fibonacci.Fib_iteracyjnie();
            }
            else if(decyzja == 2)
            {
                Console.WriteLine("Podaj numer elementu, który chcesz policzyć: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nWynik = " + Fibonacci.Fib_rekurencyjnie(liczba));
            }
            else
            {
                Console.WriteLine("Blad!");
            }


            Console.ReadLine();
        }
    }
}
