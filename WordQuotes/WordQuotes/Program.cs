using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordQuotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string."); //The string
            string userString = Console.ReadLine();
            string[] splitString = userString.Split(' '); //Splitting the string by spaces
            string resultString = string.Empty; //Creating an empty result string
            foreach (string word in splitString) //For each loop to add the spaces
            {
                resultString += "\"" + word + "\" "; //adding the ""
            }
            Console.WriteLine(resultString); //printing result

                

        }
    }
}
