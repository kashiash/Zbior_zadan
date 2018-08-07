using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ==========================================================================================
                 a więc... wróćmy do zadania... "Kalkulator prosty - switch".
    ==========================================================================================

    1. Stwórz klasę Kalkulator
    2. Stwórz metodę Wybieranie()     
    3. Twoja metoda Wybieranie() ma zawierać instrukcję switch.
    4. Instrukcja switch ma zależeć od znaku jaki poda użytkownik, dla przykładu: 
    jeśli użytkownik poda znak + to switch pójdzie do case '+', i uruchomi się metoda suma
    jeśli użytkownik poda znak * to switch pójdzie do case '*', i uruchomi się metoda iloczyn
    jeśli użytkownik poda znak - to switch pójdzie do case '-', i uruchomi się metoda roznica
    jeśli użytkownik poda jakikolwiek inny znak to do "default" i wypisze 'Nie znam takiego znaku'
   
    5. Widzisz zatem, ze będą potrzebne Ci trzy metody, Suma(), Iloczyn(), Roznica(). 
    Zastanów się przy okazji, czemu zasugerowałem Ci, że te metodą mogą być puste?
    Odpowiedź nie jest aż taka skomplikowana. Zapytam Cię tak. Czy o liczby musisz 
    pytać użytkownika w metodzie wybieranie() do obliczeń albo w ogóle w main? 

    6. Metody Suma(), Iloczyn(), Roznica() mają działać na zasadzie, że użytkownik
    może dokonać danego działania na ilu liczbach chce. A gdy wpisze kombinacje
    liczb 097 to wtedy kompilator zwróci wynik. Będzie to troszkę kodu ale...

    Mam dla Ciebie dobrą wiadomość, taką wskazówkę. Jeśli uda Ci się napisać jedną
    z tych metod, to pozostałe dwie będą polegały na tym samym tylko będzie
    trzeba pozmieniać pewne linijki kodu czyli działania itd... chyba wiesz :) 

    7. Po tej wyczerpującej pracy, możesz przystąpić do "deseru", czyli 
    stworzenia obiektu, wywołania metody, która zawiera instrukcję switch
    i przetestowaniu programu.

    8. Jak wszystko działa, to bądź dumny/dumna i zerknij na drugą część.

    =============================================
                   Część 2 zadania:
        jest do samodzielnego rozwiązania
    =============================================
*/

namespace kalka_switch
{
    class Kalkulator
    {
        public void Wybieranie(char decyzja)
        {
            // instrukcja switch ze względu na podany znak
            // przez użytkownika w instrukcji main
            switch (decyzja)
            {
                case '+':
                    Suma();
                    break;
                case '-':
                    Roznica();
                    break;
                case '*':
                    Iloczyn();
                    break;
                default:
                    Console.WriteLine("Bledny znak!");
                    break;
            }
        }

        public void Roznica()
        {
            // przechowywacz wyniku
            int wynik = 0;

            // licznik aby policzyć ile już liczb podano
            int licznik = 0;

            for(int i = 1; i < 2; )
            {
                Console.WriteLine("Podaj liczbe: " + "(podano ogółem: " + licznik + " liczb)");
                Console.WriteLine("Jeżeli chcesz zakończyć tryb wpisywania wpisz: 097");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba == 097)
                {
                    Console.WriteLine("Wynik: " + wynik);
                    break;
                }

                // jeżeli kombinacja klawiszy nie była 097 to zaktualizuj
                // zmienną wynik i zwiększ licznik
                wynik = liczba - wynik;
                licznik++;
            }
        }

        public void Iloczyn()
        {
            // tu wynik musimy ustawić na 1, gdybyśmy zostawili na 0 to przemnażalibyśmy
            // nasze liczby przez 0 to byśmy dostali w efekcie zawsze 0
            int wynik = 1;
            int licznik = 0;

            for (int i = 1; i < 2;)
            {
                Console.WriteLine("Podaj liczbe: " + "(podano ogółem: " + licznik + " liczb)");
                Console.WriteLine("Jeżeli chcesz zakończyć tryb wpisywania wpisz: 097");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba == 097)
                {
                    Console.WriteLine("Wynik: " + wynik);
                    break;
                }

                wynik = liczba * wynik;
                licznik++;
            }
        }

        public void Suma()
        {
            int wynik = 0;
            int licznik = 0;

            for (int i = 1; i < 2;)
            {
                Console.WriteLine("Podaj liczbe: " + "(podano ogółem: " + licznik + " liczb)");
                Console.WriteLine("Jeżeli chcesz zakończyć tryb wpisywania wpisz: 097");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba == 097)
                {
                    Console.WriteLine("Wynik: " + wynik);
                    break;
                }

                wynik = liczba + wynik;
                licznik++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt
            Kalkulator obiekt = new Kalkulator();

            Console.WriteLine("Kalkulator prosty: ");
            Console.WriteLine("Wpisz znak + aby rozpocząć operacje dodawania");
            Console.WriteLine("Wpisz znak - aby rozpocząć operacje odejmowania");
            Console.WriteLine("Wpisz znak * aby rozpocząć operacje mnożenia");
            char decyzja = Convert.ToChar(Console.ReadLine());

            // wywołujemy metodę wybieranie ze względu na znak który 
            // podał użytkownik
            obiekt.Wybieranie(decyzja);

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc dzialanie programu..");
            Console.ReadLine();
        }
    }
}


















