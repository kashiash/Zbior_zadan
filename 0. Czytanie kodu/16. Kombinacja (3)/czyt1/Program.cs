using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Program
    {
        // Lettering strategies

        static void LetteringAlpha()
        {
            // Lettering Alpha strategy
            Console.WriteLine("Write letter: ");
            char lett = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("New pass: " + lett + (char)(lett + 1) + (char)(lett + 2));
        }

        static void LetteringBeta()
        {
            // Lettering Beta strategy
            Console.WriteLine("Your new password: ");
            Console.WriteLine("B-T-A");
        }

        static void LetteringTeta()
        {
            // Lettering Teta strategy
            Random value = new Random();
            Console.WriteLine("Your new pass: " + value.Next('A','Z') + value.Next(1,15) + value.Next(222, 290));
        }

        static void Main(string[] args)
        {
            // variables
            int i, j, k;
            k = 2;

            i = j = k;

            Console.WriteLine("Previous password: " + i + j + k);

            Console.WriteLine("Pick a number(1, 2 or 3)");
            int pick = Convert.ToInt32(Console.ReadLine());

            if (pick == 1 || i == 2)                LetteringAlpha();
            else if (pick == 2 || j == 2)           LetteringBeta();
            else if (pick == 3 || k == 2)           LetteringTeta();
            else Console.Write("Bad pick!");

            // która metoda się uruchomi???






            Console.ReadLine();
        }
    }
}
