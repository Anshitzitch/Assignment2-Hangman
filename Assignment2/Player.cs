using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        public int Score { get; set; }

        public Player()
        {
            Name = "Player";
            Score = 0;
        }

        public Player(string n)
        {
            Name = n;
            Score = 0;
        }
    }
}
