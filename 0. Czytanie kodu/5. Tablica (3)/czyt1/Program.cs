using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        int[] Wyswietl(int[] tablica)
        {
            Console.WriteLine("Ktory element wyswietlic?");
            int wartosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element ktory wyswietlasz: " + tablica[wartosc]);
            return tablica;
            // czemu zwracamy tablie? Czy funkcja void bez zwracania ma tu racje bytu?
        }

        int[] Podmien(int[] tablica)
        {
            Console.WriteLine("Ktory element podmienic?");
            int pozycja = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Na jaka liczbe chcesz podmienic liczbe: " + tablica[pozycja]);
            int kopia = tablica[pozycja];
            // bez tej kopii niemoglbym potem napisac jaka liczbe podmieniono dlatego
            // zapisalem ja sobie do zmiennej "kopia"
            int podmiana = Convert.ToInt32(Console.ReadLine());
            tablica[pozycja] = podmiana;
            Console.WriteLine("Podmieniono liczbe " + kopia + " na " + tablica[pozycja]);
            return tablica;
        }

        static void Main(string[] args)
        {
            // obiekt testy klasy Program
            Program testy = new Program();

            // tablica wykorzystujaca petla for
            int[] totolotek = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for(int i = 0; i < 1; )                         // jak "fachowo" nazwiemy taka petle? (podpowiedz: czy ona sie konczy gdy chce czy gdy uzytkownik sobie zazyczy?)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Pokaz element");
                Console.WriteLine("2. Podmien element");
                Console.WriteLine("3. Koniec");
                int decyzja = Convert.ToInt32(Console.ReadLine());
                if (decyzja == 1) totolotek = testy.Wyswietl(totolotek);  // po co przypisujemy do tablicy wynik funkcji?
                else if (decyzja == 2) totolotek = testy.Podmien(totolotek);
                else break;
                // co robil break i kiedy wolno go uzywac?
            }
        }
    }
}
