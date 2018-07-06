using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{

    class Program
    {
        public void Sprzatanie()
        {
            Console.WriteLine("Witaj, co trzeba zrobic?");
            Console.WriteLine("1. Pozmywac naczynia");
            Console.WriteLine("2. Odkurzyc");
            Console.WriteLine("3. Zrobic pranie");
            string tekst = Console.ReadLine();
            Console.WriteLine("Wybrales numer: " + tekst);
        }

        static void Main(string[] args)
        {
            Program testy = new Program();

            testy.Sprzatanie();
            Console.WriteLine("... mija 30min");
            testy.Sprzatanie();

            Console.ReadLine();
        }
    }
}
