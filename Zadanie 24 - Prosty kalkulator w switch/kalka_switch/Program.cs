using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Treść zadania:
    Słowem wstępu. Za nami dwa ćwiczenia z instrukcji switch. Pewnie wiesz do czego służy i jak ją budować no
    i co to w ogóle takiego jest ta instrukcja switch...
    Ale, nawet jeśli teraz czujesz takie zniesmaczenie, bo TY to przecież umiesz, to weź sobie przypomnij mimo
    iż wiesz w 100% jak to robić, co to jest itd....
    To nie boli, a pomoże utrwalić Twoją wiedzę, w szczególności te reguły, które w pewien sposób ograniczają
    instrukcje z których chcemy skorzystać. A propo.....

    Czy pamiętasz może jakiego typu zmiennej nie możemy dawać w instrukcji switch(zmienna)? 
    odpowiedź brzmi: Switch nie umie obsłużyć typu danych .... <po odpowiedź zjedź na dół :) >

    PS: To jest ten wyjątek, który musisz zapamiętać.

    a więc... wróćmy do zadania... "Kalkulator prosty - switch".

    1. Stwórz klasę kalkulator
    2. Stwórz metodę wybieranie()      <= patrz, o czym nam mówi ten fragment: wybieranie(), podpowiedź: dwie rzeczy!
    3. Twoja metoda wybieranie() ma zawierać instrukcję switch.
    4. Instrukcja switch ma zależeć od znaku jaki poda użytkownik, dla przykładu: 
    jeśli użytkownik poda znak + to switch pójdzie do case '+', i uruchomi się metoda suma
    jeśli użytkownik poda znak * to switch pójdzie do case '*', i uruchomi się metoda iloczyn
    jeśli użytkownik poda znak - to switch pójdzie do case '-', i uruchomi się metoda roznica
    jeśli użytkownik poda jakikolwiek inny znak to do "default" i wypisze 'Nie znam takiego znaku'
   
    5. Widzisz zatem, ze będą potrzebne Ci trzy metody, suma(), iloczyn(), roznica(). 
    Zastanów się przy okazji, czemu zasugerowałem Ci, że te metodą mogą być puste?
    Odpowiedź nie jest aż taka skomplikowana. Zapytam Cię tak. Czy o liczby musisz 
    pytać użytkownika w metodzie wybieranie() do obliczeń albo w ogóle w main? 

    6. Metody suma(), iloczyn(), roznica() mają działać na zasadzie, że użytkownik
    może dokonać danego działania na ilu liczbach chce. A gdy wpisze "koniec" to 
    wtedy kompilator zwróci wynik.

    Mam dla Ciebie dobrą wiadomość, taką wskazówkę. Jeśli uda Ci się napisać jedną
    z tych metod, to pozostałe dwie będą polegały na tym samym tylko będzie
    trzeba pozmieniać pewne linijki kodu czyli działania itd... chyba wiesz :) 

    7. Po tej wyczerpującej pracy, możesz przystąpić do "deseru", czyli 
    stworzenia obiektu, wywołania metody, która zawiera instrukcję switch
    i przetestowaniu programu.

    8. Jak wszystko działa, to bądź dumny/dumna i zerknij na drugą część.

    
    ****************
    Część 2 zadania:
    
    chcesz, aby Twój program działał cały czas, to znaczy np. użytkownik
    policzy sobie sume, wypisze mu wynik i potem znowu sobie moze policzyć np. iloczyn
    to musimy skorzystać z pętli nieskończonej (czyli takiej która się nie skończy.. hehe).
    Zatem switch musisz opatrzeć pętlą tak? Pytanie jaka to będzie pętla pozostawiam Tobie.
    Pamiętaj, że w programowaniu musisz być elastycznym, tu nie ma jednej dobrej odpowiedzi.
    
    Ja Ci tylko podpowiem jedną rzecz:
    Pamiętaj, że warunek dla kompilatora będzie prawdziwy wtedy i tylko wtedy gdy będzie różny
    od 0

    przykłady:
    if(1 == 0) - zwróci 0 czyli fałsz
    if(5) - zwróci 1 czyli prawdę
    if(0) - zwróci 0 czyli fałsz
    if(5 == 5) - zwróci 1 czyli prawdę
    while(1) - zwróci prawdę
    while(0) - zwróci fałsz
    jeśli nie wierzysz, to przetestuj :) 
    
    Zapamiętaj, poćwicz, przypomnij sobie poniższe fakty:
    - Co to takiego i jak tworzyć: klasę, metodę, obiekt, konstruktor?
    - Co to takiego i jak tworzyć: switch 
    - Zapamiętaj, dla jakiego typu danych switch nie działa!
    (jak już zapomniałaś/zapomniałeś to spójrz dół i zanotuj gdzieś w zeszycie czy na telefonie i zerkaj na to)
    - Co to takiego i jak tworzyć: pętle?
    - Jak tworzyć np. sume od x elementów, gdzie x to liczba elementów jakie podał użytkownik?
    - Co zrobić, żeby program działał cały czas? To znaczy, nie wyłączał się po jednym wykonaniu?
*/

namespace kalka_switch
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}























// switch nie może operować na typie danych string!! Na innych może ;) 