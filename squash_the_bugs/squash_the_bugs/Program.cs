using System;

namespace squash_the_bugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0 = Syntax error. This is an error because it doesn't have the proper line ending of ;
            int i = 0;
            // declare string to hold all numbers
            string allNumbers = null;
            // loop through the numbers 1 through 10
            for (i = 1; i < 11; i++) //i < 10 has been changed to i < 11 so that 10 is included in the values.
            {

                // output explanation of calculation
                //  Console.Write(i + "/" + i - 1 + " = "); This is trying to add strings and integers together, which isn't possible. Fixed by separating the maths part from the rest using ()
                Console.WriteLine(i + "/" + (i - 1) + "=");

                // output the calculation based on the numbers
                if (i == 1)
                {
                    Console.WriteLine("Impossible"); //This will fix the divide by zero error created by dividing 1 by 0 in the normal calculation, by checking if i is 1 and declaring its impossible. RUNTIME ERROR.
                }
                else
                {
                    Console.WriteLine(i / (i - 1)); //The normal line.
                }


                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1; Logic error. This is already being done for the loop, meaning that it causes it to skip numbers. Commenting this out fixes the program.
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); This line is not properly using + and , to properly tell the console to write both the string and the variable value.
            //Furthermore since of where the brackets are placed, allNumbers is not a part of the current context, so the allNumbers line has been moved.
            Console.WriteLine("These numbers have been processed:" + allNumbers);
        }
    }
}
