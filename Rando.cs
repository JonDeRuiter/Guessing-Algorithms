﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Rando : Player
    {
        string name = "Rando";

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public Rando()
        {
            this.name = "Rando";
        }

        public int RandoGuesser(int hidden)
        {
            int counter = 0;
            int guess;
            bool win = false;
            //This loop will continue guessing randomly until it finds the number generated by the game. It will keep track of how many guess it takes to get there.
            Random r = new Random();
            do
            {
                guess = r.Next(1, 100);
                counter++;
                
                if (guess == hidden)
                {
                    win = false;
                    return counter;
                }
                //Console.WriteLine($"Guess# {counter}: {guess} does not equal {hidden}");

            } while (!(win));
            return counter;
        }

    }
}
