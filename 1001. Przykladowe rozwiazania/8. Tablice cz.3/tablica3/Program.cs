using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =============================
            Treść zadania:
    =============================
    Stwórz klasę operacje_na_tablicach. Stwórz metodę, która wypisze tablicę oraz metodę, która wpisze do 
    tablicy 35 elementowej ciągi napisów. Jeśli obecna wartość indeksu będzie liczbą parzystą, metoda wpisze 
    do tablicy: "Mój indeks jest parzysty". Natomiast jeśli obecna wartość indeksu będzie liczbą nieparzystą: 
    "Mój indeks jest nieparzysty". 

    przykład wydruku na ekran:
    nazwa_tablicy[obecny_indeks] = Mój indeks jest parzysty
*/
namespace tablica3
{
    class OperacjeNaTablicach
    {
        public static void Wpisz(string[] tablicaNapisow)
        {
            for(int i = 0; i < tablicaNapisow.Length; i++)
            {
                // jeżeli nie ma reszty z dzielenia indeks/2 
                // to wiemy że indeks jest parzysty
                if(i % 2 == 0)
                {
                    tablicaNapisow[i] = "Moj indeks jest parzysty";
                }
                else
                {
                    tablicaNapisow[i] = "Moj indeks jest nieparzysty";
                }
            }
        }

        public static void Wypisz(string[] tablicaNapisow)
        {
            for (int i = 0; i < tablicaNapisow.Length; i++)
            {
                Console.WriteLine("tablicaNapisow[" + i + "] = " + tablicaNapisow[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy tablicę
            string[] mojaTablica = new string[35];

            // wywolujemy metode Wpisz
            OperacjeNaTablicach.Wpisz(mojaTablica);

            // wywolujemy metode Wypisz
            OperacjeNaTablicach.Wypisz(mojaTablica);

            Console.ReadLine();
        }
    }
}
