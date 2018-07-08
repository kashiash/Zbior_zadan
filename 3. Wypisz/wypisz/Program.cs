using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Treść zadania:
       Napisz metode w klasie dane ktora wypisze na ekran imie i nazwisko uzytkownika ktore podal w pieknej oprawie.
       Pamietaj! To metoda ma wyswietlic dane ktore wpisal uzytkownik!

       Co znaczy piekna oprawa?
       A no jak uzytkownik poda
       Pawel
       Kowalski

       to wypisze sie:
       Twoje imie to: Pawel
       Nazwisko: Kowalski

       To zadanie pozwoli ci przypomnieć sobie:
       - jak tworzyć metodę, 
       - jak wypisać tekst, 
       - jak pobrać tekst, 
       - jak tworzyć klasę, 

       =========================
       Uwaga, w razie problemów:
       =========================
       Wypis tekstu opisaliśmy w częsci: 2.Liczenie
       Tworzenie metody opisaliśmy w 1.Funkcje

       A my sobie przypomnijmy:
       Jak pobrać tekst?
       Odpowiedź jest prosta: za pomocą funkcji Console.ReadLine();
       
       jeżeli jednak ten tekst chcemy przechować, musielibyśmy go zapisać do 
       jakiejś zmiennej prawda?

       przykładowo: string tekst = Console.ReadLine();

    
       a co jeśli chcielibyśmy pobrać liczbe a nie tekst? - zapytasz
       Bo np. potrzebujemy dodac ta liczbe do innej liczby???
       Wtedy musimy zastosowac konwersje. Mozemy to zrobic na dwa sposoby:

       1) wykorzystujac slowko ConvertTo
       przykład: int liczba = Convert.ToInt32(Console.ReadLine());

       2) wykorzystując slowko Parse
       przykład: int liczba = int.Parse(Console.ReadLine()); 

       jezeli wydaje Ci sie ze jest to trudne do zapamietania to nie martw sie,
       zobaczysz ze jak kilka razy pocwiczysz pobieranie od uzytkownika liczb
       to zauwazysz ze jak zaczynasz pisac kod za pomoca jednego z tych 2 sposobow
       to Visual Studio pomoze Ci reszte uzupelnic(proponuje jakie rzeczy dodać) :)

       Swoja droga - warto zwracać uwagę na ten "Uzupelniacz", bo jezeli dobrze sobie
       radzimy z jezykiem angielskim to nie pamietajac jakiejs funkcji mozemy jej 
       poszukac wlasnie w tym okienku z podpowiedziami :) 

    */

namespace wypisz
{
    class Dane
    {
        public int Wypisz(string a, string b)
        {
            
            Console.WriteLine("Twoje imie to: " + a);
            Console.WriteLine("Twoje nazwisko to: " + b);

            return 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // jeden ze sposobów uzyskania rozwiązania 
            // spróbuj napisać inny
            // np. tworząc w klasie Dane zmienne które
            // będą przechowywać informacje o imieniu
            // i nazwisku, dzięki czemu twoja funkcja
            // nie będzie musiała mieć argumentów
            // do przekazania     

            // stworzenie obiektu klasy Dane o nazwie wywolaj
            Dane wywolaj = new Dane();

            Console.WriteLine("Podaj imie:");
            string x = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string y = Console.ReadLine();

            wywolaj.Wypisz(x, y);

            x = "drzewo";
            Console.WriteLine(x);
            // co wypisze x po skompilowaniu programu? 
            // imie? czy slowko "drzewo" ?

            Console.ReadKey();
        }
    }
}
