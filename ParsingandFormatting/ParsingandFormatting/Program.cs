using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingandFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool acceptableNumber = false; //For the internal while loop. 
            int guessnumber = 0;
            Random rnd = new Random();
            int number = rnd.Next(0, 101); //This will randomize a number between 0 and 101. 
            Console.WriteLine(number); //This will print that generated number. No cheating!
            Console.WriteLine("Try and guess the chosen number. You have eight tries.");
            for (int i = 1; i < 9; i++)
            {
                acceptableNumber = false;
                while (acceptableNumber == false) { 
                
                Console.WriteLine("Guess a number between 1 and 100.");
                string guess = Console.ReadLine();
                try
                {
                    guessnumber = int.Parse(guess);
                        if (guessnumber >= 1 && guessnumber <= 100)
                        {
                            acceptableNumber = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number between 1 and 100.");
                            acceptableNumber = false;
                        }
                    } catch (Exception e)
                {
                    Console.WriteLine("Something went wrong. Try again.");
                }
                }
            if (guessnumber > number)
                {
                    Console.WriteLine("That guess is too high.");
                } else if (guessnumber < number)
                {
                    Console.WriteLine("That guess is too low.");
                } else if (guessnumber == number)
                {
                    Console.WriteLine("You got it! The number was " + number);
                    Console.WriteLine("It took you " + i + " tries.");
                    break;
                }
                if (i == 8) {
                    Console.WriteLine("You ran out of tries. The number was " + number); 
                    break; }
                
                {

                }
                
            }
           
        }
    }
}
