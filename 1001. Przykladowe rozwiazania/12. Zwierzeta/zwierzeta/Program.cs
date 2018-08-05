using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    ============================
           Treść zadania:
    ============================
    1. Stwórz klasę Zwierzeta
    2. Napisz konstruktor domyślny, ustaw go na prywatny.
    3. Napisz konstruktor statyczny bądź parametryczny(publiczny), aby móc jakoś tworzyć obiekty...
    4. W klasie zwierzęta stwórz pola:
    - string nazwa_zwierzaka;
    - int wiek_zwierzaka;
    - int rok_ur;
    - double waga;
    - string kolor;
    - string gatunek;
    zastanów się czy lepiej te pola dać publiczne czy prywatne, a jeśli inne to jakie?
    5. Stwórz trzy dowolnie ustalone przez siebie obiekty.
    6. Stwórz metodę zlicz_wartosc, która będzie przekazywać argumenty: wiek_zwierzaka, nazwa_zwierzaka, kolor
    7. W metodzie masz zastosować wzór dzieki któremu policzysz ile warte jest twoje zwierze (chodzi o cenę...)

    Jeśli kolor będzie złoty to wzór dodatkowo pomnożony zostanie przez 4 czyli: (wiek_zwierzaka * 0.1 + 3.14)*4
    Jeśli kolor będzie inny niż złoty to wzór będzie następujący: wiek_zwierzaka * 0.1 + 3.14

    8. Stworzyć tablicę obiektów. 
    9. Wyświetlić dane tych obiektów i wywołać dla nich metodę zlicz. 
*/
namespace zwierzeta
{
    class Zwierzeta
    {
        // pola(cechy) 
        public string nazwa_zwierzaka;
        public int wiek_zwierzaka;
        public int rok_ur;
        public double waga;
        public string kolor;
        public string gatunek;

        // konstruktor domyślny
        private Zwierzeta() { }

        // konstruktor statyczny
        public static Zwierzeta ObiektMaker()
        {
            return new Zwierzeta();
        }

        // konstruktor parametryczny
        public Zwierzeta(string nazwa_zwierzaka, int wiek_zwierzaka, int rok_ur, double waga, string kolor, string gatunek)
        {
            this.nazwa_zwierzaka = nazwa_zwierzaka;
            this.wiek_zwierzaka = wiek_zwierzaka;
            this.rok_ur = rok_ur;
            this.waga = waga;
            this.kolor = kolor;
            this.gatunek = gatunek;
        }

        public double Zlicz_Wartosc(int wiek_zwierzaka, string nazwa_zwierzaka, string kolor)
        {
            if(kolor == "zloty")
            {
                return (wiek_zwierzaka * 0.1 + 3.14) * 4;
            }
            else
            {
                return wiek_zwierzaka * 0.1 + 3.14;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // obiekty utworzone przy pomocy konstruktora parametrycznego
            Zwierzeta dzik = new Zwierzeta("dzik", 15, 1990, 5.0f, "czerwony", "dzikowate");
            Zwierzeta kangur = new Zwierzeta("kangaroo", 5, 2018, 2.4f, "zoltys", "kangurowate");
            Zwierzeta zyrafa = new Zwierzeta("zyraf", 12, 1662, 6.3f, "zloty", "żyrafowate");

            Zwierzeta[] tablicaObiektow = { dzik, kangur, zyrafa };

            // do wyświetlenia danych i zastosowania metody zlicz posłużymy się 
            // pętlą for
            
            for(int i = 0; i < tablicaObiektow.Length; i++)
            {
                Console.Write("Imie: " + tablicaObiektow[i].nazwa_zwierzaka + "| Wiek: " + tablicaObiektow[i].wiek_zwierzaka + "| Rok urodzenia: " + tablicaObiektow[i].rok_ur + "| Waga: " + tablicaObiektow[i].waga + "| Kolor: " + tablicaObiektow[i].kolor + "| Gatunek: " +tablicaObiektow[i].gatunek);
                Console.Write("\nWartosc zwierzecia: " + tablicaObiektow[i].Zlicz_Wartosc(tablicaObiektow[i].wiek_zwierzaka, tablicaObiektow[i].nazwa_zwierzaka, tablicaObiektow[i].kolor) + "\n");
            }

            Console.ReadLine();
        }
    }
}
