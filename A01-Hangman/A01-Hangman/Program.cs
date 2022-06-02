using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Hangman
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool wordNotGuessed = true;
            char letterGuessed;
            string secretWord;
            HangmanLogic hangmanLogic = new HangmanLogic();

            secretWord = hangmanLogic.SecretWord;
            hangmanLogic.Greetings();

            while (wordNotGuessed)
            {
                hangmanLogic.displayHangman();
                Console.WriteLine("What is your guess: ");
                letterGuessed = Console.ReadLine()[0];
                Char.ToLower(letterGuessed);
                Console.WriteLine();
                hangmanLogic.CheckLetter(letterGuessed);

                if (hangmanLogic.wordGuessed())
                {
                    hangmanLogic.displayHangman();
                    wordNotGuessed = false;
                }
                
            }

            Console.WriteLine("You win!\n");
            Console.ReadLine();
        }

    }
}
