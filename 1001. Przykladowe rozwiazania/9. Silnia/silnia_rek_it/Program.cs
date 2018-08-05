using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * pamiętasz - np. 3 silnia to ile??? ->  1*2*3 albo jak inni wolą 3*2*1

    ==============================
            Treść zadania:
    ==============================
    Napisz w klasie silnia dwie metody, które będą nazywać się: silnia_rekurencyjnie, silnia_iteracyjnie. Program
    ma się zapytać w pierwszej kolejności użytkownika jak woli policzyć silnię czy rekurencyjnie czy iteracyjnie.
    W zależności od wyboru program liczy silnię korzystając ze sposobu, który wybrał użytkownik. 

    ==============================
     przykładowy wynik programu:
    ==============================
    Program: Witaj! Jak chcesz policzyć silnię? 
    Program: wpisz 'rekurencyjnie' 
    Program: lub
    Program: wpisz 'iteracyjnie'
    Uzytkownik: iteracyjnie
    <program uaktywnia metodę silnia_iteracyjnie>
    Program: Silnię jakiej liczby chcesz policzyć?
    itd....
*/
namespace silnia_rek_it
{
    class Silnia
    {

        // działanie poniższej funkcji na przykładzie:
        // wartosc=3 , wynik=1
        // czy wartosc == 0? NIE(wartosc=3)
        // return wynik = 1 * 3 * SilniaRekurencyjnie(2, 3)
        // czy wartosc == 0? NIE(wartosc=2)
        // return wynik = 3 * 2 * SilniaRekurencyjnie(1, 6)
        // czy wartosc == 0? NIE(wartosc=1)
        // return wynik = 6 * 1 * SilniaRekurencyjnie(0, 6)
        // czy wartosc == 0? TAK 
        // return wynik czyli 6

        public static int SilniaRekurencyjnie(int wartosc, int wynik)
        // wynik - potrzebujemy aby przechować wynik
        // rekurencja czyli wywoływanie samej siebie
        {
            if (wartosc == 0)
            {
                return wynik;
            }

            return wynik = wynik * wartosc * SilniaRekurencyjnie(wartosc - 1, wynik);
        }

        public static void SilniaIteracyjnie()
        {
            Console.WriteLine("Podaj liczbe, ktorej silnie chcesz policzyc(iteracyjnie)");
            int war = Convert.ToInt32(Console.ReadLine());

            // wynik ustawiamy na 1, żeby wymnażanie było możliwe
            int wynik = 1;
            
            // w pętli for możemy opuścić pewne elementy ale musimy pamiętać o tym
            // aby zachować "odpowiedni szkielet" budowy pętli for
            for(; war > 0;)
            {
                wynik = wynik * war;
                war--;
            }

            Console.WriteLine("\n\nWynik = " + wynik);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("W jaki sposób policzyć silnię?\n 1.Rekurencyjnie\n 2.Iteracyjnie");
            int decyzja = Convert.ToInt32(Console.ReadLine());

            if(decyzja == 1)
            {
                Console.WriteLine("Podaj liczbe, ktorej silnie chcesz policzyc(rekurencyjnie)");
                int war = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nWynik = " + Silnia.SilniaRekurencyjnie(war, 1));     
            }
            else if(decyzja == 2)
            {
                Silnia.SilniaIteracyjnie();
            }
            else
            {
                Console.WriteLine("Blad!");
            }

            Console.ReadLine();
        }
    }
}
