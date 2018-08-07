using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ===================================================
                        Treść zadania:
    ===================================================
    Pewnie znasz już bardzo dobrze pętle, instrukcje warunkowe to możemy przejść do takiego fajniejszego 
    zadania. Pod jakim względem fajniejszego? A pod takim, że przećwiczysz sobie właśnie te rzeczy 
    które wymieniłem na początku. 

    ===================================================
        Krótkie notki przypominające rzeczy ważne:
    ===================================================

    Zapewne pamiętasz a może nie, jak wspominałem, że pętla nieskończona jest wygodna dla nas gdy chcemy
    stworzyć "menu" użytkownika, które nie wyłącza się po jednej operacji. Naszym zadanie będzie właśnie
    stworzenie takiego menu. 

    Aby kontrolować co użytkownik wybierze musimy prosić go o wybranie jednej z opcji. Zatem powinniśmy 
    skorzystać z instrukcji warunkowych, że jeśli coś wybierze to to się wykona a nie nic innego. 

    Aby proszenie użytkownika o liczbe było ciągłe to znaczy np. wybierze powiedzmy policzenie sumy, a potem
    znowu prosi o liczbe i co innego wybiera to pobieranie od użytkownika liczby czy to znaku czy to
    słowa musi odbywać się w pętli ! 

    Pamiętaj, też że instrukcje warunkowe są dla nas zbawieniem gdy chcemy porównać łańcuchy znaków(stringi), 
    to znaczy możemy dla użytkownika stworzyć menu w którym wypisze opcje a nie będzie podawał numerki
    którą opcje chce wybrać...
    Pięknie nie?

    ===================================================
                     przykładowe menu:
    ===================================================
    dodaj
    zsumuj
    wynik

    Uzytkownik napisze:
    dodaj i zadziała!

    no, więc po takim sporym wprowadzeniu, przejdźmy do prostego zadania aby 
    spojrzeć jak tworzymy takie menu. 

    1. Stwórz klasę menu
    2. Stwórz metodę wybor()     <= ta metoda ma sprawowac kontrole nad wyborem

    pseudokod tej metody:

    for (nieskonczony!)
    jesli uzytkownik napisze 'przedstaw'
    to wypisze na ekran Jestem kompilatorem C#

    ale jesli uzytkownik napisze 'koniec'
    to program konczy dzialanie

    ale jesli uzytkownik napisze 'siema'
    to program wypisze na ekran Czesc

    w przeciwnym wypadku 
    wypisze na ekran 'Zly wybor'

    3. Stwórz obiekt a następnie wywołaj metodę wybor(). 
    4. Przetestuj wszystkie opcje. 

    Zadanie jest do samodzielnego rozwiązania dla Ciebie :)

    Jeśli czujesz, że to było za proste dla Ciebie to zabierz się za zadania ze zbioru z książki, 
    poszukaj jakiegoś bo pełno jest tego od programowania :). Albo też zmodyfikuj ten program
    aby robił poważniejsze ciekawsze rzeczy. Możesz w ramach przećwiczenia o! Stwórz metody w 
    których przećwiczysz jak się robiło np. n-ty ciąg fibonacciego, potegowanie, sumowanie, itd.. :) 
    W ramach utrwalenia wiadomości? Jeśli chcesz ;) TO proszę bardzo :) 

    Pamiętaj, że w programowaniu najważniejsze jest to żeby kombinować, przewidywać jak coś będzie
    działąć, analizować linijka po linijce! Jeśli zrobisz dużo zadania, które sobie przeanalizujesz
    jak działają to wtedy będziesz mogła je powiązywać i tworzyć ciekawe rzeczy! Pamięaj, że liczy
    się to aby zrozumieć kod który piszesz a nie to że go napiszesz w ogóle... Samo napisanie Ci 
    nie pomoże zrozumieć programowania a jedynie analizowanie tego kodu jak działa, ręcznie :)

    Powodzenia!
    Mam nadzieję, że ten zbiór coś Ci pomógł :)
*/
namespace if_3_test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
