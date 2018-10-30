using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class HighLow : Player
    {
        private string name = "Rhapsody";

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }


        public int RhapsodyGuesser(int hidden, int min, int max)
        {
            int counter = 0;
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                counter++;
                //Console.WriteLine($"Guessing {mid} guess# {counter}, at {hidden}");
                if (hidden == mid)
                {
                    return counter;
                }
                else if (hidden < mid)
                {
                    counter += RhapsodyGuesser(hidden, min, mid);
                    return counter;
                }
                else
                {
                    counter += RhapsodyGuesser(hidden, mid+1, max);
                    return counter;
                }
            }
        }

    }
}
