using System;
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
            UpdateNumberLabels(low.ToString(), high.ToString());

            // generate random number
            Random rand = new Random();
            targetNumber = rand.Next(low, high + 1);

            // init timer
            timer1.Interval = 500;
            timer1.Tick += Timer_Tick;

            // acceptbutton= guessbutton
            this.AcceptButton = guessButton;

            // timer start
            timer1.Start();
        }

        private void UpdateNumberLabels(string low, string high)
        {
            outputLabel.Text = low;
            outputLabel.Text = high;
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

        private void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess;

            // validate if number
            if (!int.TryParse(currentGuessTextBox.Text, out userGuess))
            {
                MessageBox.Show("Invalid guess. Please enter a valid numeric value.");
                return;
            }

            // increment guesses
            nGuesses++;

            // comparing guess with target number
            if (userGuess < targetNumber)
            {
                outputLabel.Text = $"Your guess of {userGuess} was LOW.";
            }
            else if (userGuess > targetNumber)
            {
                outputLabel.Text = $"Your guess of {userGuess} was HIGH.";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Congratulations! You guessed the correct number {targetNumber} in {nGuesses} guesses.");

                // playing again once completed
                DialogResult result = MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // reset game
                    ResetGame();
                }
                else
                {
                    // close form
                    Close();
                }
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
    }
}
