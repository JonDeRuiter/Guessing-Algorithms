using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Welcome to the Guesser Game!\nLet's see who the better guesser is!");
                int hidden = Game.RandomNum();
                Console.WriteLine("");
                Console.WriteLine("Rhapsody from Bohemia, is our first contestant");
                HighLow rhapsody = new HighLow();
                int rhGuess = rhapsody.RhapsodyGuesser(hidden, 1, 100);
                Console.WriteLine($"It took {rhapsody.Name}, {rhGuess} guesses to find the random number");
                Console.ReadLine();

                Brutus brutus = new Brutus();
                int bGuess = brutus.BrutusGuesser(hidden);
                Console.WriteLine($"Brutus from Italy, is our second contestant");
                Console.WriteLine($"It took {brutus.Name}, {bGuess} guesses to find the random number");
                Console.ReadLine();

                Console.WriteLine("Rando from Vegas, is our third contestant.");
                Rando rando = new Rando();
                int rGuess = rando.RandoGuesser(hidden);
                Console.WriteLine($"It took {rando.Name}, {rGuess} guesses to find the random number");
                Console.ReadLine();

                Console.WriteLine("If we did this 100 times:");
                Console.WriteLine("Our best case scenarios for guessing are: ");
                Console.WriteLine($"{rhapsody.Name} with 1 guess\n{brutus.Name} with 1 guess\n{rando.Name} with 1 guess");
                Console.WriteLine("");
                Console.WriteLine("Our average scenarios for guessing are:");
                Game.Average(hidden);
                Console.WriteLine("");
                Console.WriteLine("Our worst case scenarios are: ");
                Console.WriteLine($"{rhapsody.Name} with 7 guesses\n{brutus.Name} with 100 guess\n{rando.Name} with infinite guesses");

                Console.ReadLine();
            

            } while (Continue());


        }
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Continue? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                run = Continue();
            }
            return run;
        }
    }
}
