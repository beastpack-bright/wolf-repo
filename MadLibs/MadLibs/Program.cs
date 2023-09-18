using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = false;
            int answerCorrect = 1; //To mess with the player for being BAD.
            while (playGame == false)
            {
                Console.WriteLine("Do you want to play Mad Libs?");
                string answer = Console.ReadLine();
                if (answer == "yes" ||  answer == "Yes" || answer == "y" || answer == "ye") {
                    Console.WriteLine(" Great!");
                        playGame = true; }
                else if (answer == "no" || answer == "No" || answer == "n" || answer == "n o")
                {
                    Console.WriteLine("No? Okay... ");
                    Environment.Exit(0);
                } else
                {
                    if (answerCorrect >= 3)
                    {
                        Console.WriteLine("Please answer yes or no. The wild wolves are already preparing to come to your house.");
                            Console.WriteLine("They eat computers by the way. Your Tetris high score, GONE!");
                    } else
                    {
                        answerCorrect++;
                                            Console.WriteLine("Please answer yes or no.");
                    }
                    
                }
            }
            //Setting up starting variables
            int numLibs = 0;
            int cntr = 0; 
            int nChoice = 0;
            string finalStory = "";
            string resultString = "";
            
            //Setting up the StreamReader for the external text file
            StreamReader input;


            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string textLine = null;
            while ((textLine = input.ReadLine()) != null)
            {
                ++numLibs;
            }
            input.Close();

            string[] madLibs = new string[numLibs];
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            textLine = null;
            while ((textLine = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = textLine;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }
            input.Close();
            //Prompting user for which they want to play. 
            bool acceptableValue = false;
            while (acceptableValue == false)
            {
                Console.WriteLine("Which Mad Libs would you like to play? 1-" + numLibs);
                string select = Console.ReadLine();
                try
                {
                    nChoice = int.Parse(select);
                    if (nChoice > numLibs)
                    {
                        Console.WriteLine("Not a permitted value.");
                        continue;
                    } else
                    {
                      acceptableValue = true;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please enter a proper number.");
                    continue;
                }
                
            }


            string[] words = madLibs[nChoice-1].Split(' ');

            foreach (string word in words)
            {

                if (word[0] == '{')
                {
                    string replacementWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                    //Prompts user for a replacement word
                    Console.Write("Input a {0}: ", replacementWord);
                    //Adds the response into the string
                    finalStory += Console.ReadLine() + " ";

                }
                // else append word to the result string
                else
                {
                    finalStory += word + " ";
                }
                resultString = finalStory;
                
            }
            Console.WriteLine(finalStory);
        }
    }
}

