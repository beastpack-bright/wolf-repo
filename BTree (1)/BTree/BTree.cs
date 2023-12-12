using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

namespace BTree
{
    public partial class BTreeForm : Form
    {
        public BTreeForm()
        {
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            InitializeComponent();

            this.randomButton.Click += new EventHandler(RandomButton__Click);
            this.unbalancedButton.Click += new EventHandler(UnbalancedButton__Click);
            this.primedButton.Click += new EventHandler(PrimedButton__Click);
            this.button1.Click += new EventHandler(Exercise1__Click);
            this.button2.Click += new EventHandler(Exercise2__Click);
            this.button3.Click += new EventHandler(Exercise3__Click);
            this.button4.Click += new EventHandler(Exercise4__Click);
            this.button5.Click += new EventHandler(Exercise5__Click);
            this.button6.Click += new EventHandler(Exercise6__Click);
            this.button7.Click += new EventHandler(Exercise7__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // give the BTree class objects access to Form1
            BTree.bTreeForm = this;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomButton__Click(object sender, EventArgs e)
        {
            // load a tree with random numbers
            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(random.Next(100), root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void UnbalancedButton__Click(object sender, EventArgs e)
        {
            // load a tree in data-ascending order, 
            // which will cause it to be unbalanced and poor-performing
            BTree root = null;
            BTree node;

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(i, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void PrimedButton__Click(object sender, EventArgs e)
        {
            // Prime a tree to hold alphabetical information

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            
            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root);
            node = new BTree("C", root);
            node = new BTree("B", root);
            node = new BTree("A", root);
            node = new BTree("E", root);
            node = new BTree("D", root);

            node = new BTree("J", root);
            node = new BTree("I", root);
            node = new BTree("H", root);
            node = new BTree("G", root);
            node = new BTree("L", root);
            node = new BTree("K", root);

            node = new BTree("P", root);
            node = new BTree("O", root);
            node = new BTree("N", root);
            node = new BTree("T", root);
            node = new BTree("S", root);
            node = new BTree("R", root);
            node = new BTree("Q", root);

            node = new BTree("W", root);
            node = new BTree("V", root);
            node = new BTree("U", root);
            node = new BTree("X", root);
            node = new BTree("Y", root);
            node = new BTree("Z", root);

            this.richTextBox.Text += "\n";            
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise1__Click(object sender, EventArgs e)
        {
            // Exercise #1
            // insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for (int i = 0; i < 30; i++)
            {
                int randomNumber = random.Next(1, 52); // Generates a random number between 1 and 51
                node = new BTree(randomNumber, root);
                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise2__Click(object sender, EventArgs e)
        {
            // Exercise #2
            // prime the tree for numbers between 1 and 51
            // with 7 optimally distributed data points (setting isData = false) 
            // then insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Prime the tree with 7 optimally distributed data points
            int[] primeDataPoints = { 15, 30, 7, 22, 37, 3, 40 };

            foreach (int dataPoint in primeDataPoints)
            {
                node = new BTree(dataPoint, root, isData: false);
                if (root == null)
                {
                    root = node;
                }
            }

            // Insert 30 random numbers into the binary search tree
            for (int i = 0; i < 30; ++i)
            {
                int randomNumber = random.Next(1, 52); // Generates a random number between 1 and 51
                node = new BTree(randomNumber, root);
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise3__Click(object sender, EventArgs e)
        {
            // Exercise #3
            // insert 15 random uppercase strings

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for (int i = 0; i < 15; i++)
            {
                // Generate a random uppercase string (assuming BTree constructor takes a string parameter)
                string randomString = GenerateRandomUppercaseString(random, 5); // Adjust the length as needed
                                                                                // Create a new BTree node and let the constructor handle the insertion
                node = new BTree(randomString, root);

                if (root == null)
                {
                    root = node; // Set the root if it's the first node
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        // Helper function to generate a random uppercase string of a given length
        private string GenerateRandomUppercaseString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Exercise4__Click(object sender, EventArgs e)
        {
            // Exercise #4
            // prime the tree using the code in Exercise3__Click()
            // then insert the 15 random uppercase strings from Exercise3__Click()

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // Prime the tree using the code from Exercise3__Click()
            

            // Insert 15 random uppercase strings from Exercise #3
            

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise5__Click(object sender, EventArgs e)
        {   // Exercise #5
            // use the code in Button3_Click to add the 26 letters to the tree
            // then remove nodes "C", "I" and "A" 
            // using this code to remove each node:
            //     // create new freestanding node for "C"
            //     nodeToDelete = new BTree("C", null);
            //     BTree.DeleteNode(nodeToDelete, root);
            // add the newline and call BTree.TraverseAscending() after each delete
            this.richTextBox.Clear();

            // Initialize root
            BTree root = null;

            // Add the 26 letters to the tree
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char letter in letters)
            {
                BTree newNode = new BTree(letter.ToString(), root);
                if (root == null)
                {
                    root = newNode;
                }
            }

            this.richTextBox.Text += "Original Tree:";
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            // Remove nodes "C", "I", and "A"
            BTree nodeToDelete;

            // Remove "C"
            nodeToDelete = new BTree("C", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\nAfter removing C:";
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            // Remove "I"
            nodeToDelete = new BTree("I", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\nAfter removing I:";
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            // Remove "A"
            nodeToDelete = new BTree("A", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\nAfter removing A:";
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }


        private void Exercise6__Click(object sender, EventArgs e)
        {
            this.richTextBox.Clear();

            BTree root = null;

            // Create at least 15 new Person objects which correspond to members of your family
            // Insert them into the tree starting with yourself
            Person[] familyMembers = new Person[]
            {
        new Person("Elizabeth Sanabria", 19),
        new Person("Mom", 50),
        new Person("Dad", 50),
        new Person("Me Again", 19),
        new Person("Cinderpelt the Cat", 7),
        new Person("Cinderpelt the Cat's Cat Friend", 5),
        new Person("The Baby Cat We Found Outside", 1),
        new Person("Piece of Paper", 2),
        new Person("300 Pictures of Wolves", 10),
        new Person("dog", 16),
        new Person("dog 2", 18),
        new Person("door", 30),
        new Person("cat hair", 7),
        new Person("me a third time", 19),
        new Person("feral cats", 10),
                // Add more family members here
                // Example: new Person("FamilyMemberName", Age),
            };

            foreach (Person member in familyMembers)
            {
                root = Insert(root, member);
            }

            this.richTextBox.Text += "\n";

            if (root != null)
            {
                BTree.TraverseAscending(root);
            }
            else
            {
                this.richTextBox.Text += "Tree is empty.";
            }

            // Placeholder for VisualizeBinaryTree class instantiation
            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private BTree Insert(BTree node, Person data)
        {
            if (node == null)
            {
                return new BTree(data, null);
            }

            if (data.age < ((Person)node.data).age)
            {
                node.ltChild = Insert(node.ltChild, data);
            }
            else
            {
                node.gteChild = Insert(node.gteChild, data);
            }

            return node;
        }




        private void Exercise7__Click(object sender, EventArgs e)
        {
            this.richTextBox.Clear();

            BTree root = null;

            // Given age range for balancing the tree
            int[] optimalAges = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            foreach (int age in optimalAges)
            {
                Person seedPerson = new Person($"Seed{age}", age);
                BTree seedNode = new BTree(seedPerson, null, false);
                root = Insert(root, seedNode);
            }

            this.richTextBox.Text += "\n";

            if (root != null)
            {
                BTree.TraverseAscending(root);
            }
            else
            {
                this.richTextBox.Text += "Tree is empty.";
            }

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private BTree Insert(BTree node, BTree newNode)
        {
            if (node == null)
            {
                return newNode;
            }

            if (newNode < node)
            {
                node.ltChild = Insert(node.ltChild, newNode);
            }
            else
            {
                node.gteChild = Insert(node.gteChild, newNode);
            }

            return node;
        }
    }
}
