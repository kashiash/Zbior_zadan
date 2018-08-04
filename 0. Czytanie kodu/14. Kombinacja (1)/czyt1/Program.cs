using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Atroneon
    {
        public static void Changing(int[] askedArray)
        {
            Random value = new Random();
            int i, j;

            for(i = 0, j = 0; i < askedArray.Length && i < askedArray.Length; i++, j++)
            {
                i = value.Next(0, askedArray.Length);
                j = value.Next(0, askedArray.Length);

                int tmp = askedArray[i];
                askedArray[i] = askedArray[j];
                askedArray[j] = askedArray[i];
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Uwaga, używamy tu klasy Random, czyli 
            // generującej losowąw wartość z zadanego
            // przedziału


            int[] myArray = { 1, 2, 3, 4, 5, 10, 11, 12, 4, 4, 3, 2, 15, 99, 102, 66 };

            Console.WriteLine("myArray before: ");

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();

            Atroneon.Changing(myArray);

            Console.WriteLine("myArray after: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
