using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
    Treść zadania:
    Napisz metode ktora obliczy potege liczby podanej przez uzytkownika. 
    Jesli potega bedzie  wieksza niz 30 to wypisze na ekran "Duza ta liczba".
    Jesli mniejsza to wypisze "Co tak malo?"

    podpowiedz:
    aby obliczyc potege nalezy skorzystac z petli while lub for. Pętle są bardzo ciekawymi, fajnymi i użytecznymi
    narzędziami. Jak przysiadasz do programowania to musisz być świadom, że komputer nie jest w stanie zająć się
    wszystkim na raz... wyobraźmy sobie, że chcesz dowiedzieć się ile osób w książce ma na imie Jan? On nie jest 
    w stanie zrobić tak: zerkne sobie i o, widze gdzie jest Jan... niee. Tylko jak? A no właśnie pętlą. Będzie sobie
    kroczył z linijki na linijkę i będzie ją przyrównywał - czy obecna linijka ma w sobie Jana? Nie - ide dalej,tak -
    wypisuje ją. Pętle są naprawdę spoko - tylko trzeba je zaakceptować i ich się nie bać a zobaczysz, że nie będziesz
    mógł bez nich żyć w świecie programowania.

    Utrwalisz sobie do tego zadania:
    - jak korzystać z pętli for, a jak z pętli while
    - jak są zbudowane pętle, co znaczy wogóle pętla
    - co to jest instrukcja warunkowa? Jak ja napisać? Jak dziala?
    - jak pobrać od użytkownika zmienne? 
    - jak wywołać metodę (funkcję)?
    - jak można zwrócić wynik metody?
    - jak wypisać na ekran tekst?
    - pomyśl jak będzie wyglądać kod. Co gdzie umieścić? Zastanów się.

    dla przypomnienia wrzućmy tu konstrukcje pętli:

    for (coś ; warunek ; inkrementacja/dekrementacja)   
      {
            instrukcje;
      }

    Pamiętaj, że nie musisz podawać wszystkich części pętli for, ale musisz trzymać się jej struktury
    przykładowo:
    for ( ; i < 100; )...  <= jest prawidłowo
    for (i < 100; )... <= jest nieprawidłowo
    średniki w pętli for to ŚWIĘTOŚC - sakrament!!!!

    no i dla przypomnienia omówmy każdy fragment pętli:
    coś - w to miejsce wstawiamy jakieś zmienne jeżeli chcemy które będą "żyły" tylko na potrzeby tej pętli,
    przydatne w tablicach 
    warunek - określasz kiedy ma pętla for się wykonać
    inkrementacja/dekrementacja - określasz co ma się zadziać po wykonaniu obrotu w pętli (czy np. zwiększyć o 1 coś
    a może zmniejszyć, a może pomnożyć itd...)


    a teraz lecimy z pętla while
    ale zanim Ci pokażę jej szablon to zapamiętaj taki jeden fakcik:

    Jaka jest różnica między pętlą while a do...while? - to jest strasznie typowe pytanie i dosyć proste
    odpowiedź: pętla do...while wykona się przynajmniej raz! (dlaczego? - bo w pętli do..while najpierw masz instrukcje
    a dopiero potem jest sprawdzenie warunku)

    ale teraz wróćmy... SZABLON PĘTLI WHILE

    while(warunek)
    {
        instrukcje;
    }

    i finito, tak wygląda pętla while... czyli najpierw sprawdzany jest warunek - jeżeli prawidłowy to lecimy do 
    środka pętli i są wykonywane instrukcje - a jeżeli fałsz w warunku - koniec działania pętli while

    Skoro mowa o pętli while... Możemy ją zrobić nieskończoną - jak? możemy np. napisać
    while(true)
    {

    }
    i nigdy się nie skończy :O , magia, ps; poniżej podałem przykład, sprawdź jeśli chcesz :)
    
    i ruszaj potem do zadania =]
    */
namespace potega
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Przykładowy nieskończony program:
             * Sprawdź go, jeżeli chcesz, tylko usuń
             * komentarze albo przekopiuj go niżej 
            int zlicz = 1;
            while(true)
            {
                Console.WriteLine("Czesc! Napisalem to: " + zlicz + " raz");
                zlicz++;
                Thread.Sleep(500);
            }
            */
        }
    }
}
