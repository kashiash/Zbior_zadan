using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

**********************************************
              TEMAT: RZUTOWANIE
**********************************************

    Czym jest rzutowanie? 

    Zacznijmy od tego, że czasami potrzebujesz jakiejś informacji w innym typie danych, wtedy
    zamiast robić nową zmienną możesz zrzutować do jakiegoś typu danych którego potrzebujemy!!

    przykładowo:
    mamy zmienną reszta typu double, ktora oblicza ile reszty zostaje, oraz zmienna typu int kwota
    (czyli ile dal pieniedzy klient - zalozmy ze dal rowno np. 20zl) oraz zmienna cena czyli cena
    produktu ktory kupuje klient

    int kwota;
    double cena;

    double reszta = kwota - cena;

    wiemy, że powyższa linika nie zadziała... dlaczego? Bo mamy błąd typów... próbujemy od kwota(typu Int)
    odjać cene(typu double) zatem aby się tego pozbyć musimy wykorzystać rzutowanie... 
    (rzutowanie to znaczy dosłownie" rzucić jakąś zmienną w formie innego typu)

    zatem napiszemy tak:

    int kwota;
    double cena;

    double reszta = (double)kwota - cena;

    i szybko sie okaze, ze solucja poskutkowala i mozemy cieszyc sie dzialajaca zmienna :) 


    Na ten moment nie mam zadnego pomyslu na zadanie wiec zostawiam po prostu sam wstep teoretyczny :)
    Jezeli zabierzesz sie powazanie za programowanie zobaczysz ze rzutowanie bedzie twoim "drugim przyjacielem"
    zaraz obok tablic, petli for,while, do ...while, instrukcji warunkowych if itd :) Warto rzutowanie rozumieć
    bo przydaje sie dosyc czesto w różnych przypadkach... np w wlasnie warunku w instrukcji warunkowej


*/

namespace rzutowanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* niedzialajacy kod - BLAD TYPOW
             * odkomentuj lub skopiuj aby zobaczyc ze rzeczywiscie nie dziala
            int kwota = 5;
            double cena = 3.3;

            double reszta = double - cena;
            */


            /* dzialajacy kod, z wykorzystaniem rzutowania
            int kwota = 5;
            double cena = 3.3;

            double reszta = (double)kwota - cena;
            */
             
        }
    }
}
