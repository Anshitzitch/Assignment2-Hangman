using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        HangmanGame game;
        char[] progress;
        string usedLetters = "";
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }
        void StartGame()
        {
            string[] words = { "apple", "computer", "kingston" };

            int index = rand.Next(0, words.Length);
            game = new HangmanGame(words[index]);

            progress = new char[game.Word.Length];

            for (int i = 0; i < progress.Length; i++)
            {
                progress[i] = '_';
            }

            usedLetters = "";

            labelWord.Text = string.Join(" ", progress);
            labelLives.Text = "Lives: " + game.Lives;
            labelUsed.Text = "Used Letters: ";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string guessText = textBoxGuess.Text.ToLower();

            // Make sure the user only enters one letter
            if (guessText.Length != 1)
            {
                MessageBox.Show("Please enter one letter.");
                return;
            }

            char guess = guessText[0];

            // Stop the same letter from being guessed twice
            if (usedLetters.Contains(guess.ToString()))
            {
                MessageBox.Show("You already guessed that letter.");
                textBoxGuess.Text = "";
                return;
            }

            usedLetters += guess + " ";
            labelUsed.Text = "Used Letters: " + usedLetters;

            bool found = false;

            // Check if the guessed letter is in the word
            for (int i = 0; i < game.Word.Length; i++)
            {
                if (game.Word[i] == guess)
                {
                    progress[i] = guess;
                    found = true;
                }
            }

            if (!found)
            {
                game.Lives--;
            }

            labelWord.Text = string.Join(" ", progress);
            labelLives.Text = "Lives: " + game.Lives;

            // Check if the player won
            if (labelWord.Text.Replace(" ", "") == game.Word)
            {
                MessageBox.Show("You win!");
                StartGame();
            }
            else if (game.Lives == 0)
            {
                MessageBox.Show("You lose! The word was: " + game.Word);
                StartGame();
            }

            textBoxGuess.Text = "";
        }

    }
}
