using System;


namespace FlowControl_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endLoop = false; //The loop ending variable 

            while (endLoop == false) //Setting up a loop 
            {
                Console.WriteLine("Give me a number."); //Getting number from the player
                string read1 = Console.ReadLine(); //Reading the value from the player
                int var1 = int.Parse(read1); //Setting that value to an integer
                Console.WriteLine("Give me a number."); //The same as above, repeated a second time
                string read2 = Console.ReadLine();
                int var2 = int.Parse(read2);

                if (var2 > 10 == true) //Starting if statements. Checking if var2 is greater than 10. 
                {
                    if (var1 > 10) //Checking if var1 is greater than 10 too
                    {
                        Console.WriteLine("Please pick at least one number under 10."); //If both are greater than 10, then it asks for new numbers.
                        continue; //And back to the top of the loop with you!
                    }
                }
                else if (var2 > 10 == false) //This happens if at least one number is below 10. 
                {
                    if (var1 >= 10 == true) //Checking var1 
                    {
                        if (var2 >= 10 == false)  //Checking var2 
                        {
                            Console.WriteLine(var1 + " and " + var2); //Displaying the numbers 
                            Console.WriteLine("True"); //One number is above 10, display true
                        }
                        else if (var2 > 10 == true) //Checking var2, part two
                        {
                            Console.WriteLine(var1 + " and " + var2); //Displaying the numbers
                            Console.WriteLine("true"); //One number is above 10, display true
                        }


                    }
                    else if (var1 >= 10 == false) //Checking var1, part two
                    {
                        if (var2 >= 10 == true) //var2 is above 10
                        {
                            Console.WriteLine(var1 + " and " + var2); //Displaying numbers 
                            Console.WriteLine("True"); //One number is above 10, true
                        }
                        else if (var2 > 10 == false)
                        {
                            Console.WriteLine(var1 + " and " + var2);//Displaying numbers 
                            Console.WriteLine("false"); //No numbers are above 10, false
                        }
                    }


                }

                endLoop = true;

            }
        }

    }
}

