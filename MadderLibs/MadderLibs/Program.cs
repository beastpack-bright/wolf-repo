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

            // Dictionary, store user-entered values
            Dictionary<string, string> userValues = new Dictionary<string, string>();

            StreamReader input;

            // open the template file, count mad libs
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // strings = number of mad libs
            string[] madLibs = new string[numLibs];

            // read = strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // array = current line
                madLibs[cntr] = line;

                // replace the "\\n" tag with newline escape
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt user
            Console.Write("Enter the Mad Lib number you want to play: ");
            nChoice = int.Parse(Console.ReadLine());

            // split mad lib
            string[] words = madLibs[nChoice].Split(' ');

            foreach (string word in words)
            {
                // check for word being placeholder
                if (word[0] == '{')
                {
                    string placeholder = word.Replace("{", "").Replace("}", "").Replace("_", " ");

                    // reuse value if it already exists
                    if (userValues.ContainsKey(placeholder))
                    {
                        finalStory += " " + userValues[placeholder];
                    }
                    else
                    {
                        // user replacement prompt
                        Console.Write("Input a {0}: ", placeholder);
                        // appending user response
                        string userResponse = Console.ReadLine();
                        userValues.Add(placeholder, userResponse);
                        finalStory += " " + userResponse;
                    }
                }
                // adding word to result string
                else
                {
                    finalStory += " " + word;
                }
            }

            // Final story
            Console.WriteLine("\nFinal Story:");
            Console.WriteLine(finalStory.Trim()); //Removing leading space

            //Console window won't close
            Console.ReadLine();
        }
    }
}
