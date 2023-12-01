using System;
using System.Collections.Generic;
using System.IO;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            string finalStory = "";

            // Dictionary to store user-entered values
            Dictionary<string, string> userValues = new Dictionary<string, string>();

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt the user for which Mad Lib they want to play (nChoice)
            Console.Write("Enter the Mad Lib number you want to play: ");
            nChoice = int.Parse(Console.ReadLine());

            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice].Split(' ');

            foreach (string word in words)
            {
                // if word is a placeholder
                if (word[0] == '{')
                {
                    string placeholder = word.Replace("{", "").Replace("}", "").Replace("_", "");

                    // if the user has already entered a value for this placeholder, reuse it
                    if (userValues.ContainsKey(placeholder))
                    {
                        finalStory += " " + userValues[placeholder];
                    }
                    else
                    {
                        // prompt the user for the replacement
                        Console.Write("Input a {0}: ", placeholder);
                        // and append the user response to the result string
                        string userResponse = Console.ReadLine();
                        userValues.Add(placeholder, userResponse);
                        finalStory += " " + userResponse;
                    }
                }
                // else append word to the result string
                else
                {
                    finalStory += " " + word;
                }
            }

            // Print the final story with proper spacing
            Console.WriteLine("Final Story:");
            Console.WriteLine(finalStory.Trim()); // Trim to remove leading space
        }
    }
}
