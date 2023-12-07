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
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            pictureBox1.MouseHover += PictureBox1_MouseHover;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
            foreach (Control control in this.Controls)
            {
                if (control.GetType()==typeof(TextBox))
                {
                    control.MouseHover += TextBox__MouseHover;
                    control.KeyPress += TextBox__KeyPress;
                    control.Validating += TextBox__Validating;
                }
            }
            allradioButton.CheckedChanged += AllRadioButton__CheckedChanged;
            democratRadioButton.CheckedChanged += DemocratRadioButton__CheckedChanged;
            republicanRadioButton.CheckedChanged += RepublicanRadioButton__CheckedChanged;
            demorepRadioButton.CheckedChanged += DemorepRadioButton__CheckedChanged;
            federalistRadioButton.CheckedChanged += FederalistRadioButton__CheckedChanged;
            benjaminHarrison.CheckedChanged += BenjaminHarrison__CheckedChanged;
            williamClinton.CheckedChanged += WilliamClinton__CheckedChanged;
            franklinRoosevelt.CheckedChanged += FranklinRoosevelt__CheckedChanged;
            franklinPierce.CheckedChanged += FranklinPierce__CheckedChanged;
            ronaldReagan.CheckedChanged += RonaldReagan__CheckedChanged;
            dwightEisenhower.CheckedChanged += DwightEisenhower__CheckedChanged;
            jamesBuchanan.CheckedChanged += JamesBuchanan__CheckedChanged;
            georgeBush.CheckedChanged += GeorgeBush__CheckedChanged;
            georgeWashington.CheckedChanged += GeorgeWashington__CheckedChanged;
            barackObama.CheckedChanged += BarackObama__CheckedChanged;
            williamMckinley.CheckedChanged += WilliamMckinley__CheckedChanged;
            johnKennedy.CheckedChanged += JohnKennedy__CheckedChanged;
            martinVanburen.CheckedChanged += MartinVanburen__CheckedChanged;
            theodoreRoosevelt.CheckedChanged += TheodoreRoosevelt__CheckedChanged;
            johnAdams.CheckedChanged += JohnAdams__CheckedChanged;
            thomasJefferson.CheckedChanged += ThomasJefferson__CheckedChanged;


            timer1.Interval = 1000;
            toolStripProgressBar1.Value = 240;
            timer1.Tick += Timer1__Tick;
            harrisonTextBox.Tag = 23;
            clintonTextBox.Tag = 42;
            rooseveltTextBox.Tag = 32;
            buchananTextBox.Tag = 15;
            pierceTextBox.Tag = 14;
            bushTextBox.Tag = 43;
            obamaTextBox.Tag = 44;
            kennedyTextBox.Tag = 35;
            kinleyTextBox.Tag = 25;  
            reaganTextBox.Tag = 40;
            eisenhowerTextBox.Tag = 34;
            vanburenTextBox.Tag = 8;
            adamsTextBox.Tag = 2;
            washingtonTextBox.Tag = 1; 
            roosevelttTextBox.Tag = 26; 
            jeffersonTextBox.Tag = 3;  

        }
        private void Timer1__Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value--;
            if (toolStripProgressBar1.Value == 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        TextBox tb = (TextBox)control;
                        tb.Text = "0";

                    }
                }
                toolStripProgressBar1.Value = 240;
            }
        }
        private void TextBox__Validating(object sender, CancelEventArgs e)
        {
            bool allCorrect = true;
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
            } else
            {
                errorProvider1.SetError(tb, null);
                e.Cancel = false;
                if (Convert.ToInt32(tb.Text) != (Int32)tb.Tag)
                {
                    errorProvider1.SetError(tb, "That is the wrong number.");
                    e.Cancel = true;
                } else
                {
                    foreach(Control control in this.Controls)
                    {
                        if (control.GetType() == typeof(TextBox))
                        {
                            TextBox textBox = (TextBox)control; 
                            if (Convert.ToInt32(textBox.Text) != (Int32)textBox.Tag)
                            {
                                allCorrect = false;
                            } 
                        }
                    } if (allCorrect)
                    {
                        exitButton.Enabled = true;
                        timer1.Stop();
                        webBrowser.Navigate("https://media1.giphy.com/media/MViYNpI0wx69zX7j7w/giphy.gif?cid=ecf05e47vhdd9p64ir3oinyg514nocd2wdevyd2mp3eaizwx&ep=v1_gifs_search&rid=giphy.gif&ct=g");
                    }
                }
            }
        }
        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (toolStripProgressBar1.Value == 240)
            {
                timer1.Start();
            }
            TextBox tb = (TextBox)sender;
            if (Char.IsDigit(e.KeyChar) ||e.KeyChar == '\b')
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
        private void TextBox__MouseHover(object sender, EventArgs e)
        {
            //TextBox tb = sender as TextBox;
            TextBox tb = (TextBox)sender;
            toolTip1.Show("Which # president? ", tb);
        }
        private int originalPictureBoxWidth;
        private int originalPictureBoxHeight;
        private bool isEnlarged = false;
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
        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (!isEnlarged)
            {
                // Store the original size
                originalPictureBoxWidth = pictureBox1.Width;
                originalPictureBoxHeight = pictureBox1.Height;

                // Enlarge the image
                pictureBox1.Width = (int)(originalPictureBoxWidth * 1.2);
                pictureBox1.Height = (int)(originalPictureBoxHeight * 1.2);
                isEnlarged = true;
            }
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (isEnlarged)
            {
                // Restore the original size
                pictureBox1.Width = originalPictureBoxWidth;
                pictureBox1.Height = originalPictureBoxHeight;
                isEnlarged = false;
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

        //CODE JAIL CODE JAIL CODE JAIL//
        private void franklinRoosevelt_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void williamClinton_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void jamesBuchanan_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void franklinPierce_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void georgeBush_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void barackObama_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void johnKennedy_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void williamMckinley_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ronaldReagan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dwightEisenhower_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void martinVanburen_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void georgeWashington_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void johnAdams_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void theodoreRoosevelt_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void thomasJefferson_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        //CODE JAIL CODE JAIL CODE JAIL
        private void FranklinRoosevelt__CheckedChanged(object sender, EventArgs e)
        {
            if (franklinRoosevelt.Checked)
            {
                UpdatePresidentImageAndPage("Franklin D. Roosevelt");
            }
        }

        private void BenjaminHarrison__CheckedChanged(object sender, EventArgs e)
        {
            if (benjaminHarrison.Checked)
            {
                UpdatePresidentImageAndPage("Benjamin Harrison");
            }
        }

        private void WilliamClinton__CheckedChanged(object sender, EventArgs e)
        {
            if (williamClinton.Checked)
            {
                UpdatePresidentImageAndPage("William J. Clinton");
            }
            
        }

        private void JamesBuchanan__CheckedChanged(object sender, EventArgs e)
        {
            if (jamesBuchanan.Checked)
            {
                UpdatePresidentImageAndPage("James Buchanan");
            }
        }

        private void FranklinPierce__CheckedChanged(object sender, EventArgs e)
        {
            if (franklinPierce.Checked)
            {
                UpdatePresidentImageAndPage("Franklin Pierce");
            }
        }

        private void GeorgeBush__CheckedChanged(object sender, EventArgs e)
        {
            if (georgeBush.Checked)
            {
                UpdatePresidentImageAndPage("George W. Bush");
            }
        }

        private void BarackObama__CheckedChanged(object sender, EventArgs e)
        {
            if (barackObama.Checked)
            {
                UpdatePresidentImageAndPage("Barack Obama");
            }
        }

        private void JohnKennedy__CheckedChanged(object sender, EventArgs e)
        {
            if (johnKennedy.Checked)
            {
                UpdatePresidentImageAndPage("John F. Kennedy");
            }
        }

        private void WilliamMckinley__CheckedChanged(object sender, EventArgs e)
        {

            if (williamMckinley.Checked)
            {
                UpdatePresidentImageAndPage("William McKinley");
            }
        }

        private void RonaldReagan__CheckedChanged(object sender, EventArgs e)
        {
            if (ronaldReagan.Checked)
            {
                UpdatePresidentImageAndPage("Ronald Reagan");
            }
        }

        private void DwightEisenhower__CheckedChanged(object sender, EventArgs e)
        {
            if (dwightEisenhower.Checked)
            {
                UpdatePresidentImageAndPage("Dwight D. Eisenhower");
            }
        }

        private void MartinVanburen__CheckedChanged(object sender, EventArgs e)
        {
            if (martinVanburen.Checked)
            {
                UpdatePresidentImageAndPage("Martin Van Buren");
            }
        }

        private void GeorgeWashington__CheckedChanged(object sender, EventArgs e)
        {
            if (georgeWashington.Checked)
            {
                UpdatePresidentImageAndPage("George Washington");
            }
        }

        private void JohnAdams__CheckedChanged(object sender, EventArgs e)
        {
            if (johnAdams.Checked)
            {
                UpdatePresidentImageAndPage("John Adams");
            }
        }

        private void TheodoreRoosevelt__CheckedChanged(object sender, EventArgs e)
        {
            if (theodoreRoosevelt.Checked)
            {
                UpdatePresidentImageAndPage("Theodore Roosevelt");
            }
        }

        private void ThomasJefferson__CheckedChanged(object sender, EventArgs e)
        {
            if (thomasJefferson.Checked)
            {
                UpdatePresidentImageAndPage("Thomas Jefferson");
            }
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
        private void AllRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (allradioButton.Checked)
            {
                FilterPresidentsByParty("All");
            }
        }

        private void democratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (democratRadioButton.Checked)
            {
                FilterPresidentsByParty("Democrat");
            }
        }

        private void republicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (republicanRadioButton.Checked)
            {
                FilterPresidentsByParty("Republican");
            }
        }

        private void demorepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void DemorepRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (demorepRadioButton.Checked)
            {
                FilterPresidentsByParty("Democratic-Republican");
            }
        }
        private void federalistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (federalistRadioButton.Checked)
            {
                FilterPresidentsByParty("Federalist");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Find the selected RadioButton within the GroupBox
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    string party = radioButton.Text;
                    FilterPresidentsByParty(party);
                    break; // No need to check further once we find the selected RadioButton
                }
            }
        }

        private void FilterPresidentsByParty(string party)
        {
            // Iterate through all Controls on the form
            foreach (Control control in Controls)
            {
                if (control is RadioButton presidentRadioButton)
                {
                    string presidentName = presidentRadioButton.Text;

                    // Find the associated party for the current president
                    bool showPresident = (party == "All") || presidentParties[presidentName] == party;
                                        

                    // Set the visibility of the associated RadioButton based on the filter
                    presidentRadioButton.Visible = showPresident;
                }
            }
        }






        private Dictionary<string, string> presidentParties = new Dictionary<string, string>
        {
    { "Benjamin Harrison", "Republican" },
    { "Franklin D Roosevelt", "Democrat" },
    { "William J Clinton", "Democrat" },
    { "James Buchanan", "Democrat" },
    { "Franklin Pierce", "Democrat" },
    { "George W Bush", "Republican" },
    { "Barack Obama", "Democrat" },
    { "John F Kennedy", "Democrat" },
    { "William McKinley", "Republican" },
    { "Ronald Reagan", "Republican" },
    { "Dwight D Eisenhower", "Republican" },
    { "Martin VanBuren", "Democrat" },
    { "George Washington", "Federalist" },
    { "John Adams", "Federalist" },
    { "Theodore Roosevelt", "Republican" },
    { "Thomas Jefferson", "Democratic-Republican" },
};

        private void fireworksButton_Click(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
