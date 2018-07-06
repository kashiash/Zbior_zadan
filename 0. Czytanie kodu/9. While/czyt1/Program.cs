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

            Console.WriteLine("While1: ");
            while(value == 2)               // zamiast value == 2 co moglibysmy napisac?
            {
                Console.WriteLine("XYZ");
                break;                      // co bez breaka bedzie?
            }

            Console.WriteLine();

            Console.WriteLine("While2: ");
            value = 20;                     // ta operacja to... ?
            int znak = 65;
            while (value > 10)
            {
                value -= 1;        
                Console.Write((char)znak);
                znak += 1;
            }

            Console.WriteLine();

            Console.WriteLine("While3: ");
            while (true)                        // to petla.... ?
            {
                Console.WriteLine("abc");
                // break;
            }

            Console.ReadLine();
        }
    }
}
