using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace BadForm
{
    public partial class Form1 : Form
    {

        private string lastSelectedDinosaurName;


        private readonly Dictionary<string, DinosaurInfo> dinosaurDictionary = new Dictionary<string, DinosaurInfo>
        {
            ["Allosaurus"] = new DinosaurInfo("Allosaurus", "https://i.imgur.com/RNoogfs.png", "Python", false, "The Allosaurus, while a very fearsome- and passionate- beast, does not have the coding prowess they would like to have. Short arms and a passion for breaking computers leads to this theropod having many errors in even the simplest code."),
            ["Rhamphorhynchus"] = new DinosaurInfo("Rhamphorhynchus", "https://i.imgur.com/E0RJ56G.png", "Javascript", true, "Master of the skies, Rhamphorhynchus hunts feral Javascript libraries from the air to take back to their baby Javascript trainees."),
            ["Metriacanthosaurus"] = new DinosaurInfo("Metriacanthosaurus", "https://i.imgur.com/Y1bJCC0.png", "C#", true, "A new up and coming tech master, Metriacanthosaurus is ready to create interesting things with C#. However, they tend to get frustrated, so the computer may end up partially eaten."),
            ["Stegosaurus"] = new DinosaurInfo("Stegosaurus", "https://i.imgur.com/LtcxL33.png", "Javascript", false, "A brain the size of a walnut doesn't stop this 'saur!... except in matters of coding. Stegosaurus cannot code. Stegosaurus is a master of somehow forgetting how to write lines to the console, and then screaming at the computer."),
            ["Spinosaurus"] = new DinosaurInfo("Spinosaurus", "https://i.imgur.com/IguXFvN.png", "Javascript", false, "Spinosaurus loves the art of 'spaghetti code' and adores the lovely red color of a JavaScript error. Whenever one appears, Spinosaurus becomes excited and works to create more and more broken lines of code. When the program is all red, Spinosaurus thinks they're done!"),
            ["Penguin"] = new DinosaurInfo("Penguin", "https://i.imgur.com/KcN09cz.jpg", "C#", true, "A master of C#. There is nothing better than a penguin, having such an immense C# knowledge that just their very presence can create somewhat working programs. Along with a well-trained coder, a penguin is your best ever partner. However, if you happen to be a young adult woman with rabies, your code may end up giving the local socks some trouble."),
            ["Plesiosaurus"] = new DinosaurInfo("Plesiosaurus", "https://i.imgur.com/6aIbUEs.png", "Python", true, "The python of the seas, master of Python. Nothing beats this sea beast underwater, as fish are not exceptional coders. A long neck allows this reptile to see coding errors from super far away, if that would at all be useful!"),
            ["Anomalocaris"] = new DinosaurInfo("Anomalocaris", "https://i.imgur.com/sPkFuYH.png", "C#", true, "A master of C#. This creature is often seen working alongside the PENGUIN to create masterful code that industry professionals will bow to. All hail! All hail the coder!"),
            ["Velociraptor"] = new DinosaurInfo("Velociraptor", "https://i.imgur.com/hnYp2mt.png", "C#", true, "The inventors of C#. Back in CODING BC, a pack of Velociraptors created C# in order to... do whatever dinosaurs do. They spent ages working and developing lines of code, possible errors, and also the computer since computers did not exist back then. A lot of coffee. (invented by the Pterodactyls). was drank."),
            ["Titanoboa"] = new DinosaurInfo("Titanoboa", "https://i.imgur.com/lbPSzuN.png", "Python", true, "Python for pythons!"),
            ["Tyrannosaurus Code"] = new DinosaurInfo("Tyrannosaurus Code", "https://i.imgur.com/w2mXGfZ.png", "HTML", false, "yeah he sucks!"),
            // Add more dinosaur information as needed
        };

        private readonly Random random = new Random();
        private int generateDinoButtonXOffset = 0;



        // Timer for the penguin invasion
        private System.Timers.Timer penguinTimer;

        public Form1()
        {
            InitializeComponent();
            // Populate the ListBox with dinosaur names when the form loads
            PopulateDinosaurList();

            // Initialize the penguin timer
            InitializePenguinTimer();

            // Subscribe timer1_Tick to the Tick event of timer1
            timer1.Tick += timer1_Tick_1;


        }
        private double remainingTime;

        private void PopulateDinosaurList()
        {
            // Clear existing items
            selectList.Items.Clear();

            // Add dinosaur names to the ListBox
            foreach (string dinosaurName in dinosaurDictionary.Keys)
            {
                selectList.Items.Add(dinosaurName);
            }
        }

        private void SetRandomBackColor(Control control)
        {
            Random random = new Random();
            control.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void selectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDinosaurName = selectList.SelectedItem?.ToString();

            // Handle the case when the same item is selected (deselection)
            if (selectedDinosaurName == lastSelectedDinosaurName)
            {
                // Deselect the item
                selectList.SelectedItem = null;
                lastSelectedDinosaurName = null;

                // Clear the displayed dinosaur information
                DisplayDinosaur(null);
                return;
            }

            // Update the last selected dinosaur name
            lastSelectedDinosaurName = selectedDinosaurName;

            if (!string.IsNullOrEmpty(selectedDinosaurName) && dinosaurDictionary.ContainsKey(selectedDinosaurName))
            {
                // Proceed with displaying the dinosaur information
                DinosaurInfo selectedDinosaur = dinosaurDictionary[selectedDinosaurName];
                DisplayDinosaur(selectedDinosaur);
            }
        }

        private void SetRandomProgressBarColor()
        {
            Random random = new Random();
            progressBar1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            progressBar1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            // Change the background color to a random color
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }


        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return null;
        }

        private List<DinosaurInfo> FilterDinosaurs(string selectedDinosaurName, bool goodAtCode, string selectedLanguage)
        {
            List<DinosaurInfo> filteredDinosaurs = new List<DinosaurInfo>();

            foreach (var entry in dinosaurDictionary)
            {
                DinosaurInfo dinosaur = entry.Value;

                // Check if the dinosaur matches the criteria
                if ((string.IsNullOrEmpty(selectedDinosaurName) || dinosaur.Name == selectedDinosaurName) &&
                    (goodAtCode ? dinosaur.GoodAtCode : !dinosaur.GoodAtCode) &&
                    (string.IsNullOrEmpty(selectedLanguage) || dinosaur.CodeLanguage.Equals(selectedLanguage, StringComparison.OrdinalIgnoreCase)))
                {
                    filteredDinosaurs.Add(dinosaur);
                }
            }

            return filteredDinosaurs;
        }


        private DinosaurInfo GetRandomDinosaur(List<DinosaurInfo> dinosaurs)
        {
            if (dinosaurs.Count == 0)
            {
                return new DinosaurInfo("No suitable dinosaurs found", "", "", false, "No description available");
            }

            Random random = new Random();
            int randomIndex = random.Next(dinosaurs.Count);
            return dinosaurs[randomIndex];
        }

       

        private void DisplayDinosaur(DinosaurInfo dinosaur)
        {
            if (dinosaur != null)
            {
                // Display the dinosaur image
                dinosaurImage.ImageLocation = dinosaur.ImagePath;

                // Format the dinosaur description with line breaks and random font
                string formattedDescription = $"Selected Dinosaur: {dinosaur.Name}\nDescription:\n";

                string[] sentences = dinosaur.Description.Split('.');
                foreach (string sentence in sentences)
                {
                    formattedDescription += $"{sentence.Trim()}\n";
                }

                // Set a random font for the description
                Font randomFont = GetRandomFont();
                dinosaurText.Font = randomFont;

                // Display the formatted dinosaur text
                dinosaurText.Text = formattedDescription.Trim();
            }
            else
            {
                // Handle the case when no suitable dinosaurs are found
                dinosaurImage.ImageLocation = null; // Clear the image
                dinosaurText.Text = "No suitable dinosaurs found";
            }
        }
        private Font GetRandomFont()
        {
            // Get all system fonts
            FontFamily[] fontFamilies = FontFamily.Families;

            // Select a random font family
            FontFamily randomFontFamily = fontFamilies[random.Next(fontFamilies.Length)];

            // Generate a random font size
            float randomFontSize = random.Next(8, 16);

            // Create and return the random font
            return new Font(randomFontFamily, randomFontSize);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void specialButton_Click_1(object sender, EventArgs e)
        {
            // Change the background color to a random color
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void generateDino_Click(object sender, EventArgs e)
        {
            // Move the button 1px to the left
            generateDinoButtonXOffset = (generateDinoButtonXOffset - 1) % this.Width;
            generateDino.Location = new Point(generateDinoButtonXOffset, generateDino.Location.Y);

            SetRandomBackColor(generateDino);
            SetRandomBackColor(selectList);
            SetRandomBackColor(codeLanguage);
            SetRandomBackColor(goodCoder);
            SetRandomBackColor(specialButton);
            SetRandomProgressBarColor();

            // Get selected coding language
            string selectedLanguage = GetSelectedRadioButtonText(codeLanguage);

            // Get whether the dinosaur is good at code
            string proficiency = GetSelectedRadioButtonText(goodCoder);

            // Check if coding language and proficiency are selected
            if (string.IsNullOrEmpty(selectedLanguage) || string.IsNullOrEmpty(proficiency))
            {
                MessageBox.Show("Please select a coding language and proficiency before generating a dinosaur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert proficiency to a boolean value
            bool goodAtCode = proficiency == "Yes";

            // Filter dinosaurs based on the selected criteria
            List<DinosaurInfo> viableDinosaurs = FilterDinosaurs(null, goodAtCode, selectedLanguage);

            // Select a random dinosaur
            DinosaurInfo selectedDinosaur = GetRandomDinosaur(viableDinosaurs);

            // Display the dinosaur image and text
            DisplayDinosaur(selectedDinosaur);

            // Move the button 1px to the left
            generateDinoButtonXOffset = (generateDinoButtonXOffset - 1) % this.Width;
            generateDino.Location = new Point(generateDinoButtonXOffset, generateDino.Location.Y);
        }

        private void PenguinTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Show the "Penguins are coming" error message
            ShowPenguinErrorMessage();

            // Set the remaining time for the progress bar
            remainingTime = penguinTimer.Interval / 1000;

            // Enable the timer to start counting down
            penguinTimer.Enabled = true;

            // Start the timer1 to update the progress bar
            timer1.Start();
        }


        private void ShowPenguinErrorMessage()
        {
            // Show the "Penguins are coming" error message with a bright pink background
            Action showMessage = () =>
            {
                MessageBox.Show("Penguins are coming!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Invoke on the UI thread
            Invoke(showMessage);

            // Invoke to show the penguinImage PictureBox on the UI thread
            Invoke((MethodInvoker)delegate
            {
                // Show the penguinImage PictureBox
                penguinImage.Show();
            });

            // Disable the timer1 to prevent multiple messages
            timer1.Enabled = false;

            
        }


        private void UpdateProgressBar()
        {
            // Calculate the progress bar value based on the remaining time
            int progressBarValue = (int)((remainingTime / (penguinTimer.Interval / 1000)) * progressBar1.Maximum);

            // Update the progress bar value
            progressBar1.Value = progressBarValue;
        }


        // Add this event handler for the timer tick



        private void codeLanguage_CheckedChanged(object sender, EventArgs e)
        {
            // Clear other radio buttons when one is checked
            foreach (RadioButton radioButton in codeLanguage.Controls.OfType<RadioButton>())
            {
                if (radioButton != sender)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void InitializePenguinTimer()
        {
            // Initialize the penguin timer with random intervals
            penguinTimer = new System.Timers.Timer(random.Next(30000, 60000)); // Random interval between 30 to 60 seconds
            penguinTimer.Elapsed += PenguinTimerElapsed;
            penguinTimer.AutoReset = true;
            penguinTimer.Enabled = true;

            
        }

        

        private void codeLanguage_Enter(object sender, EventArgs e)
        {

        }
        private void csharpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (csharpRadioButton.Checked)
            {
                // Clear other radio buttons
                javascriptradioButton.Checked = false;
                pythonradioButton.Checked = false;
                htmlradioButton.Checked = false;
            }
        }

        private void javascriptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (javascriptradioButton.Checked)
            {
                // Clear other radio buttons
                csharpRadioButton.Checked = false;
                pythonradioButton.Checked = false;
                htmlradioButton.Checked = false;
            }
        }

        private void pythonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pythonradioButton.Checked)
            {
                // Clear other radio buttons
                csharpRadioButton.Checked = false;
                javascriptradioButton.Checked = false;
                htmlradioButton.Checked = false;
            }
        }

        private void htmlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (htmlradioButton.Checked)
            {
                // Clear other radio buttons
                csharpRadioButton.Checked = false;
                javascriptradioButton.Checked = false;
                pythonradioButton.Checked = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        

        private void penguinImage_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime <= 0)
            {
                // Timer expired, show penguin error message
                ShowPenguinErrorMessage();
                


                // Update the progress bar
                UpdateProgressBar();
            }


        }

        public class DinosaurInfo
        {
            public string Name { get; }
            public string ImagePath { get; }
            public string CodeLanguage { get; }
            public bool GoodAtCode { get; }
            public string Description { get; }

            public DinosaurInfo(string name, string imagePath, string codeLanguage, bool goodAtCode, string description)
            {
                Name = name;
                ImagePath = imagePath;
                CodeLanguage = codeLanguage;
                GoodAtCode = goodAtCode;
                Description = description;
            }
        }


    }
}
