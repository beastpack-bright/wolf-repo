﻿using System;
using System.Windows.Forms;

namespace PE17
{
    public partial class GameForm : Form
    {
        private int targetNumber;
        private int elapsedTime;
        private int nGuesses;

        public GameForm(int low, int high)
        {
            InitializeComponent();

            // sets low and high values
            UpdateNumberLabels();

            // generate random number
            Random rand = new Random();
            targetNumber = rand.Next(low, high);

            // init timer
            timer1.Interval = 500;
            timer1.Tick += Timer_Tick;

            // acceptbutton= guessbutton
            this.AcceptButton = guessButton;

            // timer start
            timer1.Start();
        }

        private void UpdateNumberLabels()
        {
            // Display the user's guesses
            outputLabel.Text = $"Your guess: {currentGuessTextBox.Text}";
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            // progress bar update
            elapsedTime += 500;
            int progressValue = (int)((double)elapsedTime / 45000 * 100);
            statusProgress.Value = progressValue;

            // check time
            if (elapsedTime >= 45000)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! The game is over.");
                Close();
            }
        }


        private void ResetGame()
        {
            // resetting everything
            nGuesses = 0;
            elapsedTime = 0;
            outputLabel.Text = string.Empty;
            currentGuessTextBox.Text = string.Empty;

            // new number
            Random rand = new Random();
            targetNumber = rand.Next(int.Parse(outputLabel.Text), int.Parse(outputLabel.Text) + 1);

            // timer restart
            timer1.Start();
        }

        private void guessButton_Click_1(object sender, EventArgs e)
        {
            int userGuess;

            // Validate if the input is a number
            if (!int.TryParse(currentGuessTextBox.Text, out userGuess))
            {
                MessageBox.Show("Invalid guess. Please enter a valid numeric value.");
                return;
            }

            // Increment the number of guesses
            nGuesses++;

            // Compare the guess with the targetNumber and update outputLabel accordingly
            if (userGuess < targetNumber)
            {
                outputLabel.Text = $"Your guess of {userGuess} is TOO LOW.";
            }
            else if (userGuess > targetNumber)
            {
                outputLabel.Text = $"Your guess of {userGuess} is TOO HIGH.";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Congratulations! You guessed the correct number {targetNumber} in {nGuesses} guesses.");

                // Ask if the player wants to play again
                DialogResult result = MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // If yes, reset the game
                    ResetGame();
                }
                else
                {
                    // If no, close the form
                    Close();
                }
            }

            // Update the displayed guess
            UpdateNumberLabels();
        }
    }
    }
