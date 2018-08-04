using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        private void Boxer(string[] array)
        {
            int watcher = 0;

            Random play = new Random();

            Console.WriteLine("Effect: ");
            while (watcher < array.Length)
            {
                Console.Write(array[play.Next(0, array.Length)]);
                watcher++;
            }

            Console.WriteLine("\n\n->End of program");
        }

        static void Main(string[] args)
        {
            Program testing = new Program();

            string[] TextContainer = new string[3];

            int j = 1;

            for(int i = 0; i < TextContainer.Length; i++)
            {
                Console.WriteLine("Type string/char " + j + ": ");
                TextContainer[i] = Console.ReadLine();
                j += 1;
            }

            testing.Boxer(TextContainer);
            
            Console.ReadLine();
        }
    }
}
