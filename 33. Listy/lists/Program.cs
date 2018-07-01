using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 ******************************
        TEMAT: LISTY
        Teoretycznie
 ******************************
 
    obrazowo opowiedzmy czym jest owa nasza ładna lista?
    <> lista to takie pudełko ale nie jest określone z góry ile mamy w nim miejsca. W tablicy musimy podać ile np. 
    pudło miało przechowywać książek pamiętasz? Daliśmy wtedy tak: string[] pudlo = { i tu 5 elementów } czyli z góry
    podaliśmy rozmiar tablicy i taka jest właśnie różnica między listą a tablicą - warto taką informację zapamiętać

    podsumujmy:
    * rozmiar tablicy jest z góry ustalony i nie można go zmienić
    * rozmiar listy nie jest ustalony i może się dynamicznie zmieniać
    
    Tak jak możemy stworzyć tablicę obiektów tak i możemy stworzyć listę obiektów.

    jak definiujemy listę? Prosto :D piszemy
    List<typ danych lub nazwa klasy>nazwa listy = new List<typ danych lub nazwa klasy>();

    i tak przykładowa lista która będzie przechowywać napisy(string):
    List<string> przechowalnik = new List<string>();

    i jak teraz dodać np. napis do tej listy? Odpowiedź jest prosta:
    przechowalnik.Add("Sondazowy jelen");
    przechowalnik.Add("Ambitny cwaniak");

    a jeżeli chcesz wyswietlic co jest w twojej liscie to ....
    uwaga - mamy do tego fajna petle - nazywa sie foreach i jest
    latwa w zrozumieniu i uzyciu (tak mi sie wydaje), 

    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    ogólna budowa pętli foreach:

    foreach (typdanych oznaczenie_wskazywanego_elementu(np. i) in lista/tablica)
    {
        instrukcje (np. wypisanie elementu to bysmy dali Console.WriteLine(oznaczenie_wskazywanego_elementu)
    }
    <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    W postaci ogólnej może to być zawiłe być może(starałem się jakoś w miarę prosto przedstawić)
    to zobaczmy na przykładzie... Jak powyższe łańcuchy(stringi) dodane do przechowalnika wyświetlić?

    foreach (string i in przechowalnik)
    {
        Console.WriteLine(i);
    }

    przeanalizujmy zatem na podstawie ogólnego schematu jak brzmi nasz kod:

    dla każdego łanucha(string) oznaczonego "i" w liscie przechowalnik
    {
        wypisz na ekran łańcuch(string) aktualnie wskazywany przez i
    }

    przypominam: for each = dla każdego


    >>>>>>>>>>>>>>
    a taka wstawka...
    Jak zrobić listę obiektów?
    Załóżmy, że mamy klase Warzywa i stworzyliśmy takie obiekty: Pomidor, Ziemniak, Ogórek

    i jak będzie zatem dla klasy Warzywa wyglądać lista obiektów?
    List<Warzywa> lista_warzyw = new List<Warzywa>();

    a żeby dodać do niej elementy zrobimy:
    lista_warzyw.Add(Pomidor);
    lista_warzyw.Add(Ziemniak);
    lista_warzyw.Add(Ogorek);



    A teraz do przecwiczenia dla ciebie:

    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Zadanie 1)
    Stwórz listę znaki_drogowe , w ktorej przechowasz kolejno znaki(napisy):
    1) Znak nakazu jazdy w prawo
    2) Znak zakazu zatrzymywania
    3) Znak STOP

    nastepnie za pomoca petli foreach wyswietl elementy listy znaki_drogowe

    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    Zadanie 2)
    Stwórz klasę Samochod a w niej parametry:
    +Marka : string
    +Pojsil : int
    +Wersja : string

    nastepnie stworz 3 obiekty klasy Samochod o podanych parametrach:
    BMW, wersja 3215, Pojsil 2800
    Honda, wersja 2156, Pojsil 1800
    Fiat, wersja 9123, Pojsil 1400

    a jak juz stworzysz te obiekty, to stworz liste ktora bedzie przechowywac te trzy obiekty, 
    nazwij ja jak chcesz.

    nastepnie wyswietl za pomoca petli foreach dane kazdego z obiektow z tej listy

    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
*/

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {



            //przyklad z teorii do przećwiczenia:
            List<string> przechowalnik = new List<string>();
            przechowalnik.Add("Sondazowy jelen");
            przechowalnik.Add("Ambitny cwaniak");

            foreach (string i in przechowalnik)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
