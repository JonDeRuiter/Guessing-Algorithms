using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Game
    {


        public static Random RandomNum()
        {
            
            Random genNum = new Random();
            return genNum;
        }
        public static bool Feedback(int x, int findMe)
        {
            int j = x - findMe;
            if (j >= 25 || j <= -25)
            {
                Console.WriteLine("...why do you make me play with you? That wasn't even close.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (j >= 10)
            {
                Console.WriteLine("That was way too high.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (j <= -10)
            {
                Console.WriteLine("That was way too low.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (x > findMe)
            {
                Console.WriteLine("Too high.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else if (x < findMe)
            {
                Console.WriteLine("Too low.");
                Console.WriteLine("Guess again...");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Average(List<int> guesses)
        {
            int counting = 0;
            foreach (int i in guesses)
            {
                counting += i;
            }
            return (counting/100);
        }
        public static void AverageGuess(Random genNum)
        {
            List<int> rAvg = new List<int>();
            List<int> bAvg = new List<int>();
            List<int> rhAvg = new List<int>();
            HighLow rhapsody = new HighLow();
            Brutus brutus = new Brutus();
            Rando rando = new Rando();
            


            for (int i = 0; i < 100; i++)
            {
                int hidden = genNum.Next(1, 101);
                rhAvg.Add(rhapsody.RhapsodyGuesser(hidden, 1, 100));
                bAvg.Add(brutus.BrutusGuesser(hidden));
                rAvg.Add(rando.RandoGuesser(hidden));
            }
            int finalR = Average(rAvg);
            //Console.WriteLine($"Rando avg {finalR}");
            int finalRh = Average(rhAvg);
            int finalB = Average(bAvg);
                        
            Console.WriteLine($"{rhapsody.Name}'s average was {finalRh}\n{brutus.Name}'s average was {finalB}\n{rando.Name}'s average was {finalR}");
        }
    }
}
