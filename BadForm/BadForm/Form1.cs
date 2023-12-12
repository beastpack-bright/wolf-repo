using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
 
namespace BadForm
{
    public partial class Form1 : Form
    {
        //keeping track of last selected dinosaur's name
        private string lastSelectedDinosaurName;

        //dictionary used for dinosaur names 
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
            csharpRadioButton.CheckedChanged += CsharpRadioButton__CheckedChanged;
            javascriptradioButton.CheckedChanged += JavascriptRadioButton__CheckedChanged;
            htmlradioButton.CheckedChanged += HtmlRadioButton__CheckedChanged; 
            pythonradioButton.CheckedChanged += PythonRadioButton__CheckedChanged;
            toolStripProgressBar1.Value = 240;
            listButton.Click += ListButton__Click;
            yesRadioButton.CheckedChanged += codeLanguage_CheckedChanged;
            noRadioButton.CheckedChanged += codeLanguage_CheckedChanged;
            generateDino.Click += GenerateDino__Click;
            // Initialize the penguin timer
            InitializePenguinTimer();

           
            timer1.Tick += Timer1__Tick;


        }

        private void ListButton__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CsharpRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private double remainingTime;

        private void PopulateDinosaurList()
        {
            // Clear existing items
            selectList.Items.Clear();

            // Add dinosaur names 
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

                
                string formattedDescription = $"Selected Dinosaur: {dinosaur.Name}\nDescription:\n";

                string[] sentences = dinosaur.Description.Split('.');
                foreach (string sentence in sentences)
                {
                    formattedDescription += $"{sentence.Trim()}\n";
                }

                
                Font randomFont = GetRandomFont();
                dinosaurText.Font = randomFont;

                
                dinosaurText.Text = formattedDescription.Trim();
            }
            else
            {
                //no suitable dinos
                dinosaurImage.ImageLocation = null; 
                dinosaurText.Text = "No suitable dinosaurs found";
            }
        }
        private Font GetRandomFont()
        {
            
            FontFamily[] fontFamilies = FontFamily.Families;

            // Select a random font family
            FontFamily randomFontFamily = fontFamilies[random.Next(fontFamilies.Length)];

            
            float randomFontSize = random.Next(8, 16);

            
            return new Font(randomFontFamily, randomFontSize);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void specialButton_Click_1(object sender, EventArgs e)
        {
            // Change the background color 
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void GenerateDino__Click(object sender, EventArgs e)
        {
            
            generateDinoButtonXOffset = (generateDinoButtonXOffset - 1) % this.Width;
            generateDino.Location = new Point(generateDinoButtonXOffset, generateDino.Location.Y);

            SetRandomBackColor(generateDino);
            SetRandomBackColor(selectList);
            SetRandomBackColor(codeLanguage);
            SetRandomBackColor(goodCoder);
            SetRandomBackColor(specialButton);
            

            //  selected coding language
            string selectedLanguage = GetSelectedRadioButtonText(codeLanguage);

            // whether the dinosaur is good at code
            string proficiency = GetSelectedRadioButtonText(goodCoder);

            // check if coding language and proficiency are selected
            if (string.IsNullOrEmpty(selectedLanguage) || string.IsNullOrEmpty(proficiency))
            {
                MessageBox.Show("Please select a coding language and proficiency before generating a dinosaur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //prof = bool
            bool goodAtCode = proficiency == "Yes";

            
            List<DinosaurInfo> viableDinosaurs = FilterDinosaurs(null, goodAtCode, selectedLanguage);

            
            DinosaurInfo selectedDinosaur = GetRandomDinosaur(viableDinosaurs);

            
            DisplayDinosaur(selectedDinosaur);

            // Move the button
            generateDinoButtonXOffset = (generateDinoButtonXOffset - 1) % this.Width;
            generateDino.Location = new Point(generateDinoButtonXOffset, generateDino.Location.Y);
        }

        private void PenguinTimerElapsed(object sender, ElapsedEventArgs e)
        {
            //  separate thread
            Task.Run(() =>
            {
                

                
                ShowPenguinErrorMessageAndOpenForm2();
            });
        }

        private void ShowPenguinErrorMessageAndOpenForm2()
        {
            // Show the "Penguins are coming" error message
            MessageBox.Show("Penguins are coming!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Hide Form1
            Hide();

            // Open Form2
            Form2 form2 = new Form2();
            form2.ShowDialog();

            // Close the application 
            Close();
        }





        


        



        private void codeLanguage_CheckedChanged(object sender, EventArgs e)
        {
            // Clear other radio buttons 
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
            // Initialize the penguin timer 
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

        private void JavascriptRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (javascriptradioButton.Checked)
            {
                // Clear other radio buttons
                csharpRadioButton.Checked = false;
                pythonradioButton.Checked = false;
                htmlradioButton.Checked = false;
            }
        }

        private void PythonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (pythonradioButton.Checked)
            {
                // Clear other radio buttons
                csharpRadioButton.Checked = false;
                javascriptradioButton.Checked = false;
                htmlradioButton.Checked = false;
            }
        }

        private void HtmlRadioButton__CheckedChanged(object sender, EventArgs e)
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
   
        private void Timer1__Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value--;
            if (toolStripProgressBar1.Value == 0)
            {
                ShowPenguinErrorMessageAndOpenForm2();
                
            }toolStripProgressBar1.Value = 240;
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

        private void listButton_Click(object sender, EventArgs e)
        {
            //form3 instance
            Form3 form3 = new Form3();

            

            // Show Form3
            form3.Show();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
