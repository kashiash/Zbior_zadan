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

            // tablica 
            int[] totolotek = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max = totolotek.Length;

            for (int i = 0; i < max; i++)
            {
                Console.Write(totolotek[i] + " ");
            }

            // + " " po to zeby nie bylo sklejone... 
            // totolotek[0] totolotek[1] totolotek[2] totolotek[3]....

            // gdyby nie bylo + " " 
            // totolotek[0]totolotek[1]totolotek[2]totolotek[3]....

            for (int i = 0; i < max; i++)
            {
                totolotek[i] += 3;
            }

            // += to tzw. szybkie przypisanie
            // totolotek[i] += 3 bedzie wygladalo tak: totolotek[i] = totolotek[i] + 3;


            for (int i = 0; i < max; i++)
            {
                Console.Write(totolotek[i] + " ");
            }
            // wypisujemy na ekran stan tablicy

            for (int i = 0; i < max; i++)
            {
                totolotek[i] = 0;
            }
            // stan tablicy: ? 

            for (int i = 0; i < max; i++)
            {
                Console.Write(totolotek[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
