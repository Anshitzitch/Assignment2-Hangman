using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class HangmanGame
    {
        private string word;

        public string Word
        {
            get { return word; }
            set
            {
                word = value.ToLower();
            }
        }

        public int Lives { get; set; }

        public HangmanGame()
        {
            Word = "apple";
            Lives = 6;
        }

        public HangmanGame(string w)
        {
            Word = w;
            Lives = 6;
        }
    }
}
