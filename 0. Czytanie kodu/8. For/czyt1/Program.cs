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

            int value = 2;

            Console.WriteLine("For1: ");
            for(int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i + ". " + value + 2);
            }
            // uwaga!

            Console.WriteLine("For2: ");
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i + ". " + (value = value + 2));
            }

            // inkrementacja to...
            // dekrementacja to...
            // mamy jeszcze preinkremetacje i postinkrementacje
            // pre - przed, post - po
            // i++ a ++i , roznica mala ale jest
            Console.ReadLine();
        }
    }
}
