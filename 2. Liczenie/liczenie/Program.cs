using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Teorię mamy za sobą więc teraz zabierzmy się za praktyczne rozwiązania 
    W ten sposób - pokażemy, że nie trzeba wkuwać na pamięć możliwości środowiska
    tylko wystarczy je przećwiczyć w zadaniu, zrozumieć i pobawić się tym samemu :) 

    Treść zadania:
    Napisz metode w klasie zlicz ktora zsumuje trzy liczby podane przez uzytkownika.
    Niech twoja metoda zwraca wartosc typu float.

    A więc do tego zadania przypomnimy sobie:
    - jak tworzyć metodę w klasie?
    - jak tworzyć klasę?
    - jak wczytywać liczbę od użytkownika?
      // podpowiedź: musimy Console.Readline skonwertować do liczby albo Parsem albo ConvertTo 
    - jak wywołać funkcję z klasy? 
      // shhhh, obiekt, stwórz obiekt.

    przykład działania twojego programu:
    Podaj liczbe1: 2
    Podaj liczbe2: 5
    Podaj liczbe3: 6
    2+5+6=13

    #! #! #! UWAGA #! #! #! 
    przypomnijmy sobie:
    możliwości wypisania na ekran informacji są dwie:
    1) Console.Write();
    2) Console.WriteLine();

    różnią się od siebie tym, że ta pierwsza nie tworzy nowej linii...

    ale zobaczmy różnicę na przykładzie:
    pisząc:
    Console.Write("moj");
    Console.Write("kot");
    Console.Write("lubi");
    Console.Write("mnie");

    dostaniemy na ekran w jednej linii: moj kot lubi mnie 

    natomiast gdyby powyższe napisać za pomoca drugiej mozliwosci:
    Console.WriteLine("moj");
    Console.WriteLine("kot");
    Console.WriteLine("lubi");
    Console.WriteLine("mnie");

    dostaniemy na ekran: 
    moj
    kot
    lubi
    mnie

    #! #! #! dla przypomnienia #! #! #! 
    mozemy w obu sposobach wyswietlania tekstu zastosowac zwrot \n ktory spowoduje "zalamanie linii"
    dzieki temu gdybysmy napisali np:
    Console.Write("moj\nkot\nlubi\nmnie\n");

    to otrzymalibyśmy taki sam efekt na ekranie co pisząc w ten sposób:
    Console.WriteLine("moj");
    Console.WriteLine("kot");
    Console.WriteLine("lubi");
    Console.WriteLine("mnie");
    
    A wiec warto pamietac o obu sposobach wypisu tekstu i o zalamaniu linii za pomoca \n
    bo czasem wygodniej Ci bedzie korzystac z np. Console.Write a innym razem z
    Console.WriteLine - to kiedy danej rzeczy użyć, zależy od Ciebie 

    No i oczywiście możemy też wypisać na ekran tekst przechowywany przez zmienną

    przykładowo:
    string wiek = "czternascie";
    Console.WriteLine(wiek);
    */
namespace liczenie
{
    // tu leci klasa od Ciebie 

    class Program
    {
        static void Main(string[] args)
        {
            // tu stworzyć musisz obiekt który będzie odwoływał się do klasy

            //przyklad1: 
            Console.WriteLine("Przyklad1:");
            Console.Write("moj\nkot\nlubi\nmnie\n");

            Console.WriteLine("\nPrzykład2:");
            //przyklad2: 
            Console.WriteLine("moj");
            Console.WriteLine("kot");
            Console.WriteLine("lubi");
            Console.WriteLine("mnie");

            // skompiluj aby zobaczyć 
            // że oba przykłady dają ten
            // sam efekt. Różnica jest
            // taka że w przykładzie2 musimy
            // więcej linii kodu wrzucić



            Console.ReadLine(); // potrzebne aby nam okienko nie ucieklo po skompilowaniu
                                // ewentualnie mozemy uzyc Console.ReadKey();
        }
    }
}
