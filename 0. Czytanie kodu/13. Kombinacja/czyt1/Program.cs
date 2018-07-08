using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czyt1
{
    class Functions
    {
        public string word1;
        public string word2;
        public string word3;
        public int maxRounds;

        public void GetText()
        {
            Console.Write("Word1: ");
            word1 = Console.ReadLine();
            Console.Write("\nWord2: ");
            // po co dalismy \n przed Word2?
            word2 = Console.ReadLine();
            Console.Write("\nWord3: ");
            word3 = Console.ReadLine();

            Console.Write("\nHow many times do you want to roll the word? ");
            maxRounds = Convert.ToInt32(Console.ReadLine());
        }

        public void TextMixer()
        {
            List<string> listOfwords = new List<string>();
            listOfwords.Add(word1);
            listOfwords.Add(word2);
            listOfwords.Add(word3);

            Random random = new Random();
            // klasa Random
            // do obiektu "random" mozemy teraz dorzucic metode losujaca losowo wart0sc 
            // z zadanego przedzialu. W tym przypadku daliśmy poniżej random.Next(0,2)
            // co będzie losowało wartość z przedziału <0,2>
            
            for (int i = 0; i < maxRounds; i++)
            {
                int randomNumber = random.Next(0, 2);
                Console.Write(listOfwords[randomNumber]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object from Functions class
            Functions test = new Functions();
            test.GetText();
            test.TextMixer();          
            Console.ReadLine();
        }
    }
}
