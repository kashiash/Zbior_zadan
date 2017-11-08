using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Skoro już opanowane masz pętle for, while i do while, pora na ulepszenie Twojej wiedzy. Mianowicie,
    możemy robić coś takiego jak zagnieżdzanie pętli. Co to takiego zagnieżdzanie? Zagnieżdzanie to 
    umieszczanie pętli w pętli. Proste. 

    ~przykłady:

    while(....)
    {
        while(....)
        {
        ...
        }
    }

    ~albo

    for(... ;...; ...)
    {
        while(...)
        {
        ...
        }
    }

    Dzięki zagnieżdzaniu możemy stworzyć ciekawe kombinacje pętli! Pozwala to nam na tworzenie bardziej
    złożonych kodów a przy tym musisz bardziej się napocić aby wymyśleć sposób w jaki to ma działać.
    I jeszcze to trzeba sobie wyobraźić!

    Dlatego pomysł na ćwiczenie, które tak dobrze wykorzysta sentencje możliwosci zagnieżdzania
    wprost na to nie przychodzi. Jedyne to się nasuwa na myśl to operacje
    na tablicach z pętlami zagnieżdzonymi ale... no... nie mam pomysłu narazie na zadanie. 

    Poszukaj coś może w internecie. 

    A tu zadanie takie na szybko:

    1. Stwórz klasę testowanie
    2. Stwórz metodę zagniezdzanie()   <= przypomnij sobie co oznacza ten fragment zagniezdzanie() - 2 rzeczy musisz o tym 
                                          powiedzieć

    3. W metodzie zagnieżdzanie stwórz kod o następującym:

    zadeklaruj zmienna typu calkowitego ktora bedzie pokazywala ktore dzien dobry sie wypisuje np. powitanie
    int powitanie = 0;

    for(x = 0; x < 10; x++)
    {
        wypisuje na ekran 'Dzien dobry'
        zwieksza powitanie o 1
            
            for(y = 0; y < 6; y++)
            {
                    if(y % 2 == 0)
                    {
                        wypisuje na ekran 'Huraaa!'
                    }
            }      
     }

    4. Stwórz obiekt i wywołaj metody. Spróbuj rozgryźć jak działa ta pętla zagnieżdzona. Wyobraź sobie że jesteś
    kompilatorem i przejdź po kolei kroki jak on po tych pętlach. Zobaczymy wtedy czy dobrze rozumiesz pętle for
    w pętli for. :) 

    5. Jeśli już Ci się udało ogarnąć powyższy kod i wiesz co się dzieje, to znaczy kiedy dana komenda ma swoją
    kolej... to spróbuj napisać swoją pętlę zagnieżdzoną. Poćwicz aby sobie utrwalić jak taką pętlę zagnieżdzoną
    się tworzy. Wymyśl coś może ;) Tak jakoś tam pogłówkuj. A potem jak coś wymyślisz i napiszesz to przetestuj
    a następnie sobie wytłumacz jak działa twój kod, to znaczy: linijka po linijce idź po kodzie i mów sobie
    co się dzieje w danej chwili. :) Tak aby sobie to utrwalić.
*/
namespace zagniezdzona_for
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
