using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //DONT DELETE OR IT EXPLODE!!
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void harrisonTextBox_TextChanged(object sender, EventArgs e)
        {
        }
            //end of dont delete or explode

            private void franklinRoosevelt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void benjaminHarrison_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void williamClinton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void jamesBuchanan_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void franklinPierce_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void georgeBush_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void barackObama_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void johnKennedy_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void williamMckinley_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void ronaldReagan_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}"); ;
        }

        private void dwightEisenhower_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void martinVanburen_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void georgeWashington_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void johnAdams_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void theodoreRoosevelt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void thomasJefferson_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string presidentName = radioButton.Text.Replace(" ", "_");
            webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName}");
        }

        private void harrisonTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void harrisonTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void rooseveltTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void rooseveltTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void clintonTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void clintonTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void buchananTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void buchanantTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void pierceTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void pieceTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void bushTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void bushTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex);

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void obamaTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void obamaTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void kennedyTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void kennedyTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void kinleyTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void kinleyTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void reaganTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void reaganTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void eisenhowerTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void eisenhowerTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void vanburenTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void vanburenTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void washingtonTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void washingtonTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void adamsTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void adamsTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void roosevelttTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void roosevelttTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        private void jeffersonTextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "What # president?";
        }

        private void jeffersonTextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int presidentIndex = Convert.ToInt32(textBox.Tag);
            int correctNumber = GetPresidentNumber(presidentIndex); 

            if (textBox.Text != correctNumber.ToString())
            {
                textBox.Text = "Wrong number";
                textBox.ForeColor = Color.Red;
            }
        }

        //getting number

        private int GetPresidentNumber(int presidentIndex)
        {
            
            Dictionary<int, int> presidentNumbers = new Dictionary<int, int>
            {
                
            };

            return presidentNumbers[presidentIndex];
        }

        private void democratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedParty = radioButton.Text;

           
            FilterPresidentsByParty(selectedParty);
        }

        private void republicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedParty = radioButton.Text;

            
            FilterPresidentsByParty(selectedParty);
        }

        private void demorepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedParty = radioButton.Text;

            
            FilterPresidentsByParty(selectedParty);
        }

        private void federalistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedParty = radioButton.Text;

            
            FilterPresidentsByParty(selectedParty);
        }
        private void FilterPresidentsByParty(string party)
        {
            // Iterate through all RadioButton controls for presidents
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Name.EndsWith("RadioButton") && radioButton.Tag != null)
                {
                    // Get the president's name associated with the RadioButton
                    string presidentName = radioButton.Text;

                    // Check if the president's party matches the selected party
                    bool showPresident = presidentParties.TryGetValue(presidentName, out string presidentParty) &&
                                         presidentParty.Equals(party, StringComparison.OrdinalIgnoreCase);

                    // Set the visibility of the RadioButton based on the filter
                    radioButton.Visible = showPresident;
                }
            }
        }

        private Dictionary<string, string> presidentParties = new Dictionary<string, string>
{
    { "Benjamin Harrison", "Republican" },
    { "Franklin D. Roosevelt", "Democrat" },
    { "William J. Clinton", "Democrat" },
    { "James Buchanan", "Democrat" },
    { "Franklin Pierce", "Democrat" },
    { "George W. Bush", "Republican" },
    { "Barack Obama", "Democrat" },
    { "John F. Kennedy", "Democrat" },
    { "William McKinley", "Republican" },
    { "Ronald Reagan", "Republican" },
    { "Dwight D. Eisenhower", "Republican" },
    { "Martin Van Buren", "Democrat" },
    { "George Washington", "None" },
    { "John Adams", "Federalist" },
    { "Theodore Roosevelt", "Republican" },
    { "Thomas Jefferson", "Democratic-Republican" },
};



    }
}
