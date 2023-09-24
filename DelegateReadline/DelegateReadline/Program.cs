using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateReadline
{

    delegate string ReadLineDelegate(); //Setting up the delegate function declaration
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadLineDelegate customRead = Console.ReadLine; //Setting the custom variable to readLine
            Console.WriteLine("Type in a value."); //Getting user input

            string userInput = customRead(); //taking that input 
            Console.WriteLine($"You entered {userInput}!"); //string alongside delegate input

        }
    }
}
