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
        private List<char> LettersGuessed;
        private List<char> CorrectLetters;
        private List<char> SecretWordList;

        public HangmanLogic()
        {
            Lives = 6;
            SecretWord = "mississippi";
            LettersGuessed = new List<char>();
            CorrectLetters = new List<char>();
            SecretWordList = new List<char>(secretWord);
        }

        public int Lives { get => lives; set => lives = value; }
        public string SecretWord { get => secretWord; set => secretWord = value; }

        public void Greetings()
        {
            Console.WriteLine("Welcome to Hangman! Type in your guesses to figure out the secret word! But be careful you only have 6 lives!\n");
        }

        public void CheckLetter(char letterGuessed)
        {
            bool correctGuess = false;

            if(LettersGuessed.Contains(letterGuessed))
            {
                Console.WriteLine("You've already guessed {0}. Please try another letter.\n", letterGuessed);
                return;
            }
            else
            {
                LettersGuessed.Add(letterGuessed);
            }

            foreach (var letter in SecretWordList)
            {
                if (letterGuessed.ToString().Equals(letter.ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    correctGuess = true;
                    CorrectLetters.Add(Char.ToLower(letterGuessed));
                    break;
                }
            }

            if (correctGuess != true)
            {
                lives--;
                Console.WriteLine("Wrong guess try again!\n");
            }

            if (lives == 0)
            {
                displayLosingMessage();
                Environment.Exit(0);
            }
        }

        public void displayHangman()
        {
            foreach (var letter in SecretWordList)
            {
                if (CorrectLetters.Contains(Char.ToLower(letter)))
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.Write(" | lives left: {0} \n\n", Lives);
        }
        
        public bool wordGuessed()
        {
            var noDupes = SecretWordList.Distinct().ToList();
            if(noDupes.Count > CorrectLetters.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void displayLosingMessage()
        {
            Console.WriteLine("Out of lives, you lose!\n");
            Console.WriteLine("Correct word was {0}!", secretWord);
            Console.ReadLine();
        }

    }
}
