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

        private void UpdatePresidentImageAndPage(string presidentName)
        {
            // Dictionary containing image URLs for each president
            Dictionary<string, string> presidentImages = new Dictionary<string, string>
            {
                // Add the image URLs for each president
                {"Barack Obama", "https://i.imgur.com/lS38jQc.png"},
                {"Benjamin Harrison", "https://i.imgur.com/dsoQEWn.jpg"},
                {"Dwight D. Eisenhower", "https://i.imgur.com/9UVC58p.jpg"},
                {"Franklin D. Roosevelt", "https://i.imgur.com/nUaThjm.jpg"},
                {"Franklin Pierce", "https://i.imgur.com/385eVXc.jpg"},
                {"George Washington", "https://i.imgur.com/5DHgzxg.jpg"},
                {"George W. Bush", "https://i.imgur.com/aV6YJLl.jpg"},
                {"James Buchanan", "https://i.imgur.com/ZxamlbX.jpg"},
                {"John Adams", "https://i.imgur.com/r6c3DPp.jpg"},
                {"John F. Kennedy", "https://i.imgur.com/r22s4FQ.jpg"},
                {"Martin Van Buren", "https://i.imgur.com/qILXiSH.jpg"},
                {"Ronald Reagan", "https://i.imgur.com/5LEI45p.jpg"},
                {"Theodore Roosevelt", "https://i.imgur.com/9OyET91.jpg"},
                {"Thomas Jefferson", "https://i.imgur.com/dXGACtp.jpg"},
                {"William J. Clinton", "https://i.imgur.com/PLMgSqj.jpg"},
                {"William McKinley", "https://i.imgur.com/PWhDXga.jpg"}
            };

            // Check if the president name exists in the dictionary
            if (presidentImages.TryGetValue(presidentName, out string imageUrl))
            {
                // Load the image from the URL
                pictureBox1.ImageLocation = imageUrl;

                // Set the SizeMode property to make the image stretch
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Open the Wikipedia page in the web browser
                webBrowser.Navigate($"https://en.wikipedia.org/wiki/{presidentName.Replace(" ", "_")}");
            }
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
            UpdatePresidentImageAndPage("Franklin D. Roosevelt");
        }

        private void benjaminHarrison_CheckedChanged(object sender, EventArgs e)
        {
            if (benjaminHarrison.Checked)
            {
                UpdatePresidentImageAndPage("Benjamin Harrison");
            }
        }

        private void williamClinton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("William J. Clinton");
        }

        private void jamesBuchanan_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("James Buchanan");
        }

        private void franklinPierce_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Franklin Pierce");
        }

        private void georgeBush_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("George W. Bush");
        }

        private void barackObama_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Barack Obama");
        }

        private void johnKennedy_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("John F. Kennedy");
        }

        private void williamMckinley_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("William McKinley");
        }

        private void ronaldReagan_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Ronald Reagan");
        }

        private void dwightEisenhower_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Dwight D. Eisenhower");
        }

        private void martinVanburen_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Martin Van Buren");
        }

        private void georgeWashington_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("George Washington");
        }

        private void johnAdams_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("John Adams");
        }

        private void theodoreRoosevelt_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Theodore Roosevelt");
        }

        private void thomasJefferson_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresidentImageAndPage("Thomas Jefferson");
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
        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allradioButton.Checked)
            {
                FilterPresidentsByParty("All");
            }
        }

        private void democratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (democratRadioButton.Checked)
            {
                FilterPresidentsByParty("Democrat");
            }
        }


        private void republicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (republicanRadioButton.Checked)
            {
                FilterPresidentsByParty("Republican");
            }
        }


        private void demorepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (demorepRadioButton.Checked)
            {
                FilterPresidentsByParty("Democratic-Republican");
            }
        }


        private void federalistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (federalistRadioButton.Checked)
            {
                FilterPresidentsByParty("Federalist");
            }
        }

        private void FilterPresidentsByParty(string party)
        {
            // Iterate through all controls on the form
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Name.EndsWith("RadioButton") && radioButton.Tag != null)
                {

                    string presidentName = radioButton.Text;

                    bool showPresident = presidentParties.TryGetValue(presidentName, out string presidentParty) &&
                                         (party.Equals("All", StringComparison.OrdinalIgnoreCase) || presidentParty.Equals(party, StringComparison.OrdinalIgnoreCase));

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

        private void fireworksButton_Click(object sender, EventArgs e)
        {
            // Change the web browser to the fireworks image URL
            webBrowser.Navigate("https://media1.giphy.com/media/MViYNpI0wx69zX7j7w/giphy.gif?cid=ecf05e47vhdd9p64ir3oinyg514nocd2wdevyd2mp3eaizwx&ep=v1_gifs_search&rid=giphy.gif&ct=g");
        }


    }
}
