using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_2
{
    public partial class GameForm : Form
    {   
        // Variables
        Random random = new Random();
        int randomIndex;
        string chosenWord;
        int numberOfLetters;
        private TextBox[] letterTextBoxes;
        string userInput;
        int wrongGuess = 0;
        int correctGuess = 0;

        public GameForm()
        {
            InitializeComponent();
            ChooseWord();
            SetUpHangman();
            UpdateHangmanPicture();

        }

        private void ChooseWord()
        {
            // create a random index to choose a word from the wordbank
            randomIndex = random.Next(0, wordbank.word.Length);

            //put the random index in a label to debug
            chosenWord = wordbank.word[randomIndex];
           // gameFormLabel.Text = chosenWord;  

            
            
        }

        private void SetUpHangman() 
        {
            // count the number of letters in the chosen word
            numberOfLetters = chosenWord.Length;

            // debug- put the numberOfLetters in a label to check its working 
            //debugLabel.Text = numberOfLetters.ToString();

            // Initialize the array to hold TextBoxes
            letterTextBoxes = new TextBox[numberOfLetters];

            // for loop to put a dash and textbox for each letter in the chosenWord
            for (int i =0; i < numberOfLetters; i++)
            {
                // Create a read-only TextBox for each letter
                letterTextBoxes[i] = new TextBox
                {
                    Width = 30,
                    Location = new Point(10 + (35 * i), 100), 
                    MaxLength = 1,
                    CharacterCasing = CharacterCasing.Upper,
                    ReadOnly = true 
                };
                // Add the TextBox to the form
                Controls.Add(letterTextBoxes[i]);

                // Set the TextBox text to a dash
                letterTextBoxes[i].Text = "_"; 
            }
        }

        private void UpdateHangmanPicture() 
        {
            if (wrongGuess == 1) 
            {
                hangmanPictureBox.Image = Properties.Resources.hangman2;
            } else if (wrongGuess == 2){
                hangmanPictureBox.Image = Properties.Resources.hangman3;
            }
            else if (wrongGuess == 3)
            {
                hangmanPictureBox.Image = Properties.Resources.hangman4;
            }
            else if (wrongGuess == 4)
            {
                hangmanPictureBox.Image = Properties.Resources.hangman5;
            }
            else if (wrongGuess == 5)
            {
                hangmanPictureBox.Image = Properties.Resources.hangman6;
            }
            else if (wrongGuess == 6)
            {
                hangmanPictureBox.Image = Properties.Resources.hangman7;
            } else if (wrongGuess == 7)
            {
                hangmanPictureBox.Image = Properties.Resources.hangman8;
                gameFormLabel.Text = $"Game over, he ded! The chosen word was {chosenWord}. Double click here to play again!";
                label1.Text = "";
            }
        }

        private void playerWon() 
            { }

        private void gameForm_Load(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // enter letter button
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (letterTextbox.Text == "")
            {
                MessageBox.Show("Enter a letter, dumbass!");
                return;
            }
            // Add the letter the user guessed to the guesses textbox
            //guessesTextbox.Text += " " + letterTextbox.Text;
            label1.Text += " " + letterTextbox.Text.ToLower();


            //CLEAR DEBUG LABEL
            //debugLabel.Text = "";

            // compare user input to letters in the chosen word
            // make variable for user input

            userInput = letterTextbox.Text.ToLower();

            if (chosenWord.Contains(userInput))
            {
                gameFormLabel.Text = "The chosen word contains this character!";
                

                // put the letter in the hangman letter boxes
                // Update the TextBoxes for correct guesses
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    // Check if the character at the current position matches the user's input
                    if (chosenWord[i].ToString().ToLower() == userInput)
                    {
                        letterTextBoxes[i].Text = userInput.ToUpper();
                        correctGuess++;
                    }

                    // if the label is clicked to restart the game, clear the letter textboxes
                    //if (gameFormLabel.Click) { }
                }

            }
            else
            {
                wrongGuess++;
                UpdateHangmanPicture();
                gameFormLabel.Text = "The chosen word DOES NOT contain this character!";
            }

            // clear the user guess so that they can guess again
            // guessesTextbox.Text = "";
            letterTextbox.Text = "";


            // If user guesses all of the letters, they win the game
            if (correctGuess == numberOfLetters) 
            {
                // update label to show user that they won
                gameFormLabel.Text = "You won! You saved his life! Play again?(Click here)";

                // update picture box
                hangmanPictureBox.Image = Properties.Resources.hangmanwin;

                // clear guesses box
                label1.Text = "";

                return;
            }
            UpdateHangmanPicture();
        }

        private void gameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hangmanPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void gameFormLabel_Click(object sender, EventArgs e)
        {
            // Reset hangman picture
            hangmanPictureBox.Image = Properties.Resources.hangman1;

            // Clear guesses box
            label1.Text = "";

            // Update the game form label
            gameFormLabel.Text = "Pick a letter to begin playing!";

            // Clear the letter textbox for user input
            letterTextbox.Text = "";

            // Choose a new word
            ChooseWord();

            // Clear the letter text boxes
            for (int i = 0; i < letterTextBoxes.Length; i++)
            {
                letterTextBoxes[i].Text = "_"; // 
            }

            // Set up hangman again
            SetUpHangman();

            // Update the hangman picture to the initial state
            UpdateHangmanPicture();

            // Reset guesses
            correctGuess = 0;
            wrongGuess = 0;

        }
    }
}
