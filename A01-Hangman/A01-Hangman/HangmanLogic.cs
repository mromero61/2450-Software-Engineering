using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Hangman
{
    internal class HangmanLogic
    {
        private int lives;
        private string secretWord;

        public HangmanLogic()
        {
            Lives = 6;
            SecretWord = "Utah";
        }

        public int Lives { get => lives; set => lives = value; }
        public string SecretWord { get => secretWord; set => secretWord = value; }

        public void Greetings()
        {
            Console.WriteLine("Welcome to Hangman! Type in your guesses to figure out the secret word! But be careful you only have 6 lives!\n");
        }

        

    }
}
