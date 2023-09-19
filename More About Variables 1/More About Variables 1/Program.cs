using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_About_Variables_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ascendingNumbers = new int[5];
            for (int i = 0; i < ascendingNumbers.Length; i++)
            {
                ascendingNumbers[i] = i+1;

            }

            Console.WriteLine("Enter a string."); //The user's string value. 
            string stringOne = Console.ReadLine(); //Reading that value. 
            string stringNew = ""; //Setting this to an empty string
            foreach (char c in stringOne) //For each loop to add each character
            {
                stringNew = c + stringNew; //Adding the character to the rest of stringNew 
            }
            Console.WriteLine(stringNew);
          
        }
    }
}

