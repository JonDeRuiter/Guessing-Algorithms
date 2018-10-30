using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_Game
{
    class Player
    {
        //variables
        protected int guess;        
        protected string name;

        //properties
        public int Guess
        {
            get { return guess; } set { this.guess = value; }
        }
       
        public string Name
        {
            get { return name; } set { this.name = value; }
        }

        //Constructor
        public Player ()
        {
            
        }

        //methods

    }
}
