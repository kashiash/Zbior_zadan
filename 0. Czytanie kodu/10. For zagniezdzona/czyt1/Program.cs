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

            int[] tablica_liczbowa = { 1, 2, 3, 4 };
            string[] tablica_slowa = { "kokosy", "banany", "jablka", "pomarancza" };
            int y = 0;

            Console.WriteLine("Skladniki: ");
            for(int x = 3; x <= tablica_liczbowa.Length; x--)
            {
                for(; y <= tablica_slowa.Length; )
                {
                    if (x >= 0 && y >= 0)
                    {
                        Console.Write(tablica_liczbowa[x] + " " + tablica_slowa[y] + "\n");
                        y++;
                        break;
                    }
                }
                continue;
                Console.WriteLine("2 + 2 = ?");
                // czy to sie wyswietli chociaz jeden raz?
            }

            Console.ReadLine();
        }
    }
}
