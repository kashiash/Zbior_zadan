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
            string[] totolotek = { "cze", "pok", "lemo", "dyw" };
            int max = totolotek.Length;

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(totolotek[i] + " ");
            }

            Console.WriteLine("\n\n");
            // WriteLine robi nowa linie
            // Write pisze w tej samej
            // \n robi nowa linie 
            // czyli o ile linii skoczymy w dol? 

            for (int i = 0; i < max; i++)
            {
                totolotek[i] = totolotek[i] + "baka";
            }

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(totolotek[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
