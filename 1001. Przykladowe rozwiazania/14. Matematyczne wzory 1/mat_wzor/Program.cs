using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =====================================
                Treść zadania:
    =====================================
    W klasie biblioteka_matematyki napisz metode obwod_kola, metode pole_kola i metode obwod_pole_kola, ktore
    policza dla uzytkownika obwod lub pole dla podanego promienia. Pamietaj, że Twój program ma się najpierw
    zapytać użytkownika co chce policzyć. Może wybrać sam obwód, samo pole lub i pole i obwód.
    Następnie ma wywołać odpowiednią metodę.

    =====================================
         przykład działania programu:
    =====================================
    Kompilator: Witaj w programie który liczy obwód i promień koła. Najpierw zdecyduj co chcesz policzyć?
    1. Obwód koła
    2. Pole koła.
    3. Obwód i pole koła.
    użytkownik podejmuje decyzję wybierając jedną z opcji, a następnie wywołuje się dana funkcja...
    
    Utrwalisz sobie podczas opracowywania tego zadania:
    - Co to jest klasa, metoda?
    - Jak wywolać metodę jeśli coś? (instrukcja warunkowa?)
    - Co to jest instrukcja warunkowa, jak jest zbudowana, jak działa?
    - Przypomnij sobie co wiesz o pętlach for, do..while, while. (która z pętli wykona się minimum 1 raz?)
*/

namespace mat_wzor
{
    class BibliotekaMatekatyki
    {
        public static void ObwodPoleKola()
        {
            Console.WriteLine("Promien kola?");
            int promien = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Obwod = " + 2*3.14*promien);
            Console.WriteLine("Pole = " + 3.14 * promien * promien);
        }

        public static void PoleKola()
        {
            Console.WriteLine("Promien kola?");
            int promien = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pole = " + 3.14 * promien * promien);
        }

        public static void ObwodKola()
        {
            Console.WriteLine("Promien kola?");
            int promien = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Obwod = " + 2 * 3.14 * promien);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteka matematyczna I");
            Console.WriteLine("1. Oblicz obwód i pole kola");
            Console.WriteLine("2. Oblicz pole koła");
            Console.WriteLine("3. Oblicz obwód koła");

            int decyzja = Convert.ToInt32(Console.ReadLine());

            if (decyzja == 1) BibliotekaMatekatyki.ObwodPoleKola();
            else if (decyzja == 2) BibliotekaMatekatyki.PoleKola();
            else if (decyzja == 3) BibliotekaMatekatyki.ObwodKola();
            else Console.WriteLine("Blad!");

            Console.ReadLine();
        }
    }
}
