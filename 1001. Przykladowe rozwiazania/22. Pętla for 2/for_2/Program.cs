using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ###########################################################
                            Treść zadania:
    ###########################################################
    1. Stwórz klasę CwiczenieFOR
    2. Stworz w niej metode petla_for_z_ifami()    <= przypomnij sobie co znaczy (), 
    psss: To jest podpowiedź co zwracać ma funkcja!
    3. W metodzie petla_for_z_ifami() stwórz kod o następującym pseudokodzie:

    pytamy sie uzytkownika jaka liczbe chce podac
    użytkownik podaje liczbę

    jeśli liczba jest większa niż 100
    wypisz na ekran 'Duza ta liczbe sobie wymysliles uzytkowniku!'
    ale jesli liczba jest mniejsza od 100 ale wieksza od 80 
    wypisz na ekran 'W miare dobra liczba, moze byc uzytkowniku!'
    ale jesli liczba jest wieksza od 40 i liczba jest mniejsza od 50 
    wypisz na ekran 'nie podoba mi sie ta liczba drogi uzytkowniku!'
    w przeciwnym wypadku
    wypisz na ekran 'Nie znam takiej liczby drogi uzytkowniku, a moze jakas inna?'

    Oczywiście to wszystko musi być w pętli for! 
    
    Proponuję zrobić pętlę która będzie nieskończona. 
    Jak to zrobimy? A, to jest bardzo proste. Jak tworzysz pętle for to wiesz, że jest blok, 
    zwiększania/zmniejszania. Wystarczy że zostawisz ten blok pusty, a zmienna, którą dałeś w pętli 
    for w deklaracji np. i = 0, w warunku musi być prawdziwy to musimy dać np. i < 5 i hop! Mamy
    pętlę, która cały czas się będzie wykonywać bo i zawsze będzie 0 a co za tym idzie spełniać
    będzie warunek i < 5. Tak? :) 

    4. Jak więc już masz metodę za sobą, teraz czas na oczywistości dla Ciebie, myślę :) czyli...
    Tworzymy obiekt (na konstruktorze domyślnym) i za jego pomocą wywołujemy naszą funkcję 
    petla_for_z_ifami().

    #Wskazówka do zapamiętania: aby wywołać funkcję, którą mamy w klasie, musimy stworzyć obiekt
    i potem przez niego dojść do metody czyli nazwa_obiektu.nazwa_metody(). Te nawiasy MÓWIĄ NAM 
    BARDZO DUŻO!!! Po pierwszej, że jest to funkcja! Po drugie, że nie przyjmuje argumentów!

    Przykład wywołania funkcji:  mleko.policz_cene(double waga, double cena)

    5. Testujemy efekty naszego programu. Pobaw się nim, żeby sprawdzić wszystkie warunki czy
    działają. 


    ==========================================================================
                                   Zadanie cz. 2 
    ==========================================================================
    Jak już wykonasz pierwszą część zadania to teraz troszkę zmienimy twój kod. Tam zrobiliśmy
    pętle nieskończoną for. Teraz chcemy pętlę skończoną! Zadbaj o to, aby wykonała się 
    maksymalnie 3 razy! 

    Po wykonaniu się pętli 3 razy, napisz w metodzie kod, który poinformuje użytkownika o tym,
    że program skończył pracę! Tylko UWAGA! Zastanów się gdzie umieścić tą linijkę? Pamiętaj,
    że chcemy ją na ekranie zobaczyć tylko raz!!!!

    odp. wystarczy że ystawimy na starcie i na 1, ograniczymy warunkiem i <= 3 pętlę
    i dodamy inkrementację i czyli i++. W środku pętli możemy napisać, że jeśli i == 3 
    to wtedy wypisuje na ekran informacje.
*/

namespace for_2
{
    class CwiczenieFor
    {
        public void PetlaForZIf()
        {
            for(int i = 0; i < 1; )
            {
                Console.WriteLine("Podaj liczbe: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba > 100) Console.WriteLine("Duza ta liczba!");
                else if (liczba < 100 && liczba > 80) Console.WriteLine("W miare dobra liczba!");
                else if (liczba > 40 && liczba < 50) Console.WriteLine("Nie podoba mi sie ta liczba!");
                else Console.WriteLine("Nie znam takiej liczby");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy obiekt
            CwiczenieFor obiekt = new CwiczenieFor();

            // wywołujemy metodę
            obiekt.PetlaForZIf();

            Console.ReadLine();
        }
    }
}
