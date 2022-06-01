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
            bool wordGuessed = true;
            string letterGuessed;
            string secretWord;
            HangmanLogic hangmanLogic = new HangmanLogic();

            secretWord = hangmanLogic.SecretWord;
            hangmanLogic.Greetings();
            Console.WriteLine(String.Join("", secretWord.Select(v => "_")) + " lives left: {0} \n", hangmanLogic.Lives);

            while (wordGuessed)
            {
                Console.WriteLine("What is your guess: ");
                letterGuessed = Console.ReadLine();
                
            }

        }

    }
}
