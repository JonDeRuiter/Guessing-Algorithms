using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Game
    {


        public static int RandomNum()
        {
            int findMe;
            Random genNum = new Random();
            findMe = genNum.Next(1, 101);
            return findMe;
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
        public static void Average(int hidden)
        {
            List<int> rAvg = new List<int>();
            List<int> bAvg = new List<int>();
            List<int> rhAvg = new List<int>();
            HighLow rhapsody = new HighLow();
            Brutus brutus = new Brutus();
            Rando rando = new Rando();
            Random hidden3 = new Random();


            for (int i = 0; i < 100; i++)
            {
                int hidden2 = hidden3.Next(1, 101);
                rhAvg.Add(rhapsody.RhapsodyGuesser(hidden2, 1, 100));
                bAvg.Add(brutus.BrutusGuesser(hidden2));
                rAvg.Add(rando.RandoGuesser(hidden));
            }
            int bigR = 0;
            foreach (int i in rAvg)
            {
                bigR += rAvg[i];
                Console.WriteLine($"Rando took {rAvg[i]} guesses");
            }
            int bigRh = 0;
            foreach (int i in rhAvg)
            {
                bigRh += rhAvg[i];
                Console.WriteLine($"Rhapsody took {rhAvg[i]} guesses");
            }
            int bigB = 0;
            foreach (int i in bAvg)
            {
                bigB += bAvg[i];
                Console.WriteLine($"Brutus took {bAvg[i]} guesses");
            }
            int finalR = bigR/100;
            int finalRh =  bigRh/100;
            int finalB = bigB/100;

            Console.WriteLine($"{rhapsody.Name}'s average was {finalRh}\n{brutus.Name}'s average was {finalB}\n{rando.Name}'s average was {finalR}");
        }
    }
}
