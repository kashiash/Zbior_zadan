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

            string[] tablica_slow = { "za", "do", "cze", "be" };
            string[] tablica_liter = { "ton", "ch", "ba", "toka" };
            string[] tablica = new string[4];
            // co oznacza ta 4 ? 
            int i = 0;
            int y = 3;

            for(int x = 0; x <= tablica_slow.Length; x++)
            {
                for( ; y <= tablica_liter.Length; )
                {
                    if (x <= tablica_slow.Length && y <= tablica_liter.Length && y >= 0)
                                                                        // gdyby nie bylo y >= 0 to..?
                    {
                        string var = tablica_slow[y] + "-" + tablica_liter[x];
                        if(i < 4) tablica[i] = var;
                        i++;
                        y--;
                    }
                    break;
                }
            }

            // Podsumowanie:

            for(int w = 0; w < tablica.Length; w++)
            {
                Console.WriteLine(tablica[w]);
            }

            Console.ReadLine();
        }
    }
}
