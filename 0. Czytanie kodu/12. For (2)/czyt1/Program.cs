using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // obiekt testy klasy Program
            Program testy = new Program();

            int podsumowanie = 0;
            int i;

            Console.WriteLine("max mozliwa wartosc: " + Int32.MaxValue);

            for (i = 0; i < 1; )
            {
                Console.WriteLine("<podaj liczbe>");
                podsumowanie = podsumowanie + Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("<> stan: " + podsumowanie);
            }



























            // sposob2:
            for (i = 0; i < 1;)
            {
                Console.WriteLine("<podaj liczbe>");
                Console.WriteLine("max mozliwa wartosc: " + Int32.MaxValue);
                int przechowywacz = Convert.ToInt32(Console.ReadLine());
                podsumowanie = podsumowanie + przechowywacz;
                // alternatywa
                Console.WriteLine("<> stan: " + podsumowanie);
            }

            Console.ReadLine();
        }
    }
}
