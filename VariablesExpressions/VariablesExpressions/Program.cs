using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:"); //Getting input from the player. 
            string number1 = Console.ReadLine(); //Setting that input to a string value.
            int int1 = Convert.ToInt32(number1); //Converting that string value into a new integer variable so they can be multiplied together.

            Console.WriteLine("Enter another number:"); //Same process as above, repeated for each new variable required.
            string number2 = Console.ReadLine();
            int int2 = Convert.ToInt32(number2);

            Console.WriteLine("Enter number three:");
            string number3 = Console.ReadLine();
            int int3 = Convert.ToInt32(number3);

            Console.WriteLine("Enter last number:");
            string number4 = Console.ReadLine();
            int int4 = Convert.ToInt32(number4);

            Console.WriteLine(int1 * int2 * int3 * int4); //Multiplies the four values gained from the player and multiplies them together. Outputs the value.


            //DELETE THESE. DELETE THESE. ONLY TESTS. NOT FOR MAIN PROJECT. REMEMBER. to make sure: 
            //los woowoo
            Console.WriteLine("test code here");

            Console.WriteLine("Please enter a number with a decimal precision of 2.");
            string input = Console.ReadLine();
            double inputNumber = double.Parse(input);
            inputNumber = inputNumber + 55.0;
            Console.WriteLine(inputNumber);

        }
    }
}
