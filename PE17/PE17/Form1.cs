using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
//if i delete this, everything explodes
        }


         

        private void startButton_Click_1(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            bConv = Int32.TryParse(lowendTextBox.Text, out lowNumber);
            bConv &= Int32.TryParse(highendTextBox.Text, out highNumber);

            // Validate input
            if (!bConv || lowNumber >= highNumber)
            {
                // Show a dialog that the numbers are not valid
                MessageBox.Show("Invalid input. Please enter valid numeric values for low and high numbers, and ensure low is less than high.");
            }
            else
            {
                // Create a new GameForm with the specified range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // Show the GameForm
                gameForm.Show(); // Use Show() instead of ShowDialog()

                // Hide the current form if you want to disable it while the game is active
                this.Hide();
            }
        }
    }
    }
    
