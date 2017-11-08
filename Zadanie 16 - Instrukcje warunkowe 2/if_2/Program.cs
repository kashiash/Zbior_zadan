using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Witaj! Złożone instrukcje if, nie są Ci już straszne, wiesz już na czym polega taki if, kiedy się wykonuje dany moment
    co to jest else itd... Wiesz, że if jest dla nas bardzo przyjemny bo możemy konstruować np. menu wyboru ze  
    względu na typ danych string (czego switch nie może). 

    Przećwiczmy je jeszcze raz, a w następnym zadaniu z instrukcjami warunkowymi, zobaczysz jak dzięki nim 
    stworzyć interaktywne menu dla użytkownika. :) 

    Zadanie:
    1. Stwórz klasę warunkowa  :) 

    2. Stwórz parametry:
    public string imie;
    public string nazwisko;
    public int ocena;

    3. Stwórz metodę selekcja_uczniow(int ocena_studenta)           </ zastanów się jaki typ danych jej dać? 
                                                                    PS: czy potrzebujesz zwracac zmienna? NIE, ale 
                                                                    chcesz skorzystac z argumentu wiec musimy cos
                                                                    dac. Zastosuj trik, na swoją korzyść. Pamiętasz
                                                                    jak w metodach mówiłem, że aby przechować 
                                                                    zwracaną wartość musimy przepisać to do zmiennej 
                                                                    lub odrazu wyśwetlić? Teraz odwróć sytuację. Wręcz
                                                                    chcemy żeby wynik nam uciekł! Zatem... nigdzie
                                                                    go nie przypiszemy! Wystarczy dać 
                                                                    return .... ? ?? :) Zastanów się:) 
                                                                    Odpowiedź nie jest taka trudna jak Ci mogłoby się
                                                                    wydawać :)

    Twoja metoda będzie wyglądała mniej więcej tak:

    jesli ocena_studenta jest rowna 1
    {
        wypisz na ekran 'Uczen (tu imie, nazwisko) nie zdal'
    }
    ale jesli ocena_studenta jest rowna 2
    {
        wypisz na ekran 'Uczen (tu imie, nazwisko) moze otrzymac wpis warunkowy'
    }
    ale jesli ocena_studenta jest rowna  3 lub rowna 4 lub rowna 5
    { 
        wypisz na ekran 'Uczen (tu imie, nazwisko) zdal.
    }
    w przeciwnym wypadku
    {
        wypisz na ekran 'Nieoczekiwany blad!'
    }

    4. Stwórz 3 obiekty, daj każdemu ocenę jaką uważasz.
       Stwórz czwarty obiekt, któremu za ocene dasz 0.

    5. Każdemu obiektowi wywołaj naszą metodę selekcja_uczniow(int ocena_studenta).

    6. Przetestuj działanie programu.

    Wniosek programu:
    zauważ jak bardzo wygodne jest takie ustawianie warunków. Możemy je też wrzucać do pętli dzięki czemu
    takie "ify" nabierają wielkieeego znaczenia szczególnie dla TABLIC!. Bardzo warto jest opanować ta
    instrukcję do maksimum! W tym przypadku nie musimy sami selekcjonować kto do jakiej grupy studentów,
    program robi to za nas! Ale wygooooda ;) nie? Ify są bardzooo fajne! Pamiętaj jednak, aby nie mylić
    ich z pętlami! Pętle to co innego! Tak? :) 

    ?: o! to, w ogóle zapytajmy się co to takiego pętla? w skórcie:
    Jest to ciąg instrukcji który jest wykonywany do momentu otrzymania fałszywego warunku. :) 

    ?: a co to takiego instrukcja warunkowa?
    instrukcja która się wykona jeśli warunek jest prawdziwy.  Jeśli jest else..if to sprawdza
    kolejny warunek czy jest prawdziwy, jeśli if, else if są fałszywe i jest else to idzie do else
    (który zawsze się wykona..) a jeśli nie ma else to po prostu idzie sobie kompilator dalleeeej :).

    Więc widzisz teraz różnicę między pętlami, a instrukcjami warunkowymi? Myślę, że tak :).
    Nie myl tych pojęć! :) 


    Zatem, zapamiętaj:
    - co to takiego instrukcja warunkowa?
    - jak korzystamy z instrukcji warunkowych?
    - co oznacza w instrukcji warunkowej else?
    - co oznacza || a co && ???
    - ZAPAMIĘTAJ, że jeśli masz złożoną instrukcję np. if()....,else if()...., else if()....., else if()....., else
      to wykona się tylko ten blok instrukcji, który pierwszy jest prawdziwy (potem reszte omija, else też!) a jeśli
      żaden nie będzie prawdziwy to wykona się else. Jeśli nadal tego nie kumasz to wracaj do ćwiczenia i potestuj. 
      Stwórz kolejne obiekty, nadaj im różne oceny. Spróbuj przewidzieć co się wypisze na ekran itd :). To jest bardzo
      ważne! BARDZO WAŻNE!

*/
namespace if_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
