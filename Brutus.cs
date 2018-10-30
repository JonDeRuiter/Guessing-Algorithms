using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Brutus : Player
    {
        private string name = "Brutus";

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public Brutus()
        {
            this.name = "Brutus";
        }

        public int BrutusGuesser(int hidden)
        {
            int counter = 0;
            bool win = false;

            do
            {
                for (int i = 100; i > 0; i--)
                {
                    counter++;
                    if (i == hidden)
                    {
                        win = true;
                        return counter;
                    }
                    //Console.WriteLine($"At guess# {counter}, guess {i} was not {hidden}");
                }
            } while (!(win));
            return counter;

        }


    }
}
