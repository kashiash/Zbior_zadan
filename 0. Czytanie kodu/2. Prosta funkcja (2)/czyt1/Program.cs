using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        public string Logowanie()
        {
            Console.WriteLine("Podaj haslo:     \n(haslo to 1234)");

            return Console.ReadLine();
        }

        public void SprawdzHaslo()
        {
            string podane = Logowanie();

            if (podane == "1234")
            {
                Console.WriteLine("Haslo prawidlowe!");
            }
            else
            {
                Console.WriteLine("Haslo nieprawidlowe!");
            }
        }

        static void Main(string[] args)
        {
            // obiekt testy klasy Program
            Program testy = new Program();

            string imie = "Pracownik 1453";
            imie = "Pracownik 979";

            Console.WriteLine("Witaj: " + imie);
            testy.SprawdzHaslo();

            Console.ReadLine();
        }
    }
}
