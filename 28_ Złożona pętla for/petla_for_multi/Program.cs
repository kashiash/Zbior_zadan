/*
    Treść zadania: 
    Znasz już dokładnie budowę pętli for i to w jaki sposób działa. Teraz pokażę Ci, jak możemy rozbudować taką pętle.
    Zacznijmy od tego,  że wiesz już że pętla for ma trzy takie "fragmenty", 
    1) deklaracja (wykonuje się tylko raz)
    2) warunek
    3) zwiększanie/zmniejszanie itd...
    
    jej budowa jest następująca:
    for (deklaracja ; warunek ; zwiekszanie/zmniejaszanie)
    {
    instrukcje;
    }

    A czy wiesz, że możesz wpisać do niej więcej deklaracji, więcej warunków, więcej zwiększań/zmniejszeń? 
    Możesz je łączyć za pomocą operatorów typu || i && (co to za operatory? Przypomnij sobie).

    przykładowa budowa takiej pętli:
    for(x = 0, y = 5, z = 3; x < z && z > y; z++, x++, y = y * 1.5)
    {
    instrukcje...
    }

    Zatem, jak już poznaliśmy o co chodzi z taką bardziej złożoną pętlą for to, 

    1) Stwórz klasę obsluga.
    2) Stwórz w niej metodę zliczanie()   <= zastanów się co oznaczają puste nawiasy? Może już wiesz :) 
    3) W tej metodzie stwórz pętlę for w której:

    a) zadeklarujesz TYLKO raz zmienne: cena = 3; dlugosc = 10; rozmiar = 20

    b) stworzysz warunek, który będzie brzmiał: 
    "Jeżeli cena jest większa od długości i rozmiar jest większy od długości lub
     Jeżeli długość jest wieksza od ceny"
    
    c) stworzysz zwiekszanie/zmniejszanie: cena++; dlugosc--; rozmiar /= 5; 
    *Przy okazji, wiesz co oznacza skróty rozmiar /= 5 i dlugosc-- ? Rozpisz je. 
    
    a w bloku instrukcji po prostu wypiszesz na ekran wartości tych liczb w takiej kolejności:
    Cena = ....
    Dlugosc = ....
    Rozmiar = .... 

    4) Stwórz obiekt za pomocą którego odwołasz się do metody. (To już wiesz pewnie tak?)
    5) Wywołaj metodę zliczanie()
    6) Sprawdź program. 

    Zapamiętaj:
    - pętle nie mają SZTYWNEJ budowy, MOŻEMY ich "miejsca" rozbudowywać! np. 
    pętla while może być while(x == 0 || x == 1 || x == 3) itd..
    - działanie pętli for, jej budowę!
    - co to jest metoda, a co klasa, a co obiekt?
    - co to jest || a co && ? 
    - zastanów się czy nawiasy mają jakieś znaczenie w priorytetach jeśli chodzi o wykonywanie działań
    w kompilatorze? Jeśli tak to jakie? Kiedy są wykonywane? 


    WNIOSEK po wykonaniu ćwiczenia.
    Pętla for jak pętla for, tylko ja ją nazwałem na potrzeby ćwiczenia "multifunkcyjną" bo z tym mi się
    kojarzy gdy dostajemy więcej deklaracji, warunków itd... To jest po prostu rozbudowana pętla for.
    Zapamiętaj, że w taki sposób możemy rozbudowywać pętle czyli nie jesteśmy ograniczeni do jednej 
    deklaracji, jednego warunku czy jednego zwiększania. Wiedza o tym może Ci się kiedyś przydać :).

*/

namespace petla_for_multi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
