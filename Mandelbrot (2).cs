using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            double imagCoordEnd = 0; //Declaring variables that will be used inside of the loop. 
            string imagCoordRead2 = "yes";
            double imagInterval = 0.0;
            double imagCoordStart = 0.0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Give us a starting number for the imaginary number.") //Asking the user for input
                    string imagCoordRead = Console.ReadLine();
                    double imagCoordStart = double.Parse(imagCoordRead);
                    break;//Ending the loop. 
                }
                catch (Exception string)
            {
                    console.WriteLine("This value is not a number. Try again. ")
            }

                }

                bool acceptableValue = false; //This will start the while loop to check if the value is allowed. 
                while acceptableValue == false; //While loop. Will run until the ending number is lower than the starting number. 
                {
                    while (true)
                    {
                        try //Try and catch: for no errors if a string is entered.
                        {
                            Console.WriteLine("Give us an ending number for the imaginary number.") //Asking the user for input for the ending value. 
                             imagCoordRead2 = Console.ReadLine(); //Reading that value
                            imagCoordEnd = double.Parse(imagCoordRead2); //Parsing that value into a double
                            break;//Ending the loop. 
                        }
                        catch (Exception string)
            {
                            console.WriteLine("This value is not a number.")
            }
                        }

                        if (imagCoordEnd >= imagCoordStart)
                        {
                            Console.WriteLine("Please enter a value lower than the starting value.")
                                    continue;
                        }
                        else
                        {
                            imagInterval = ((imagCoordStart - imagCoordEnd) / 48) //Calculating the interval needed 
                    acceptableValue == true //Ending the loop
                }
                    }

                    //Starting on the realCoord section. Same as above, yet with different variables + interval calculation 

                    double realCoordEnd = 0; //Declaring variables that will be used inside of the loop and try/catch. 
                    string realCoordRead2 = "yes";
                    double realInterval = 0.0;
                    double realCoordStart = 0.0;
                    while (true)
                    {
                        try //So there's no errors because of failed parses.
                        {
                            Console.WriteLine("Give us a starting number for the imaginary number.") //Asking the user for input
                        string realCoordRead = Console.ReadLine();
                            double realCoordStart = double.Parse(realCoordRead);
                            break;//Ending the loop. 
                        }
                        catch (Exception string) //Catching string errors.
            {
                            console.WriteLine("This value is not a number.")
            }
                        }


                        bool acceptableValue2 = false;
                        while acceptableValue2 == false; //Another while loop. 
                        {
                            while (true)
                            {
                                try //Still no errors with parsing if a string is added.
                                {
                                    Console.WriteLine("Give us an ending number for the imaginary number.") //Asking the user for input for the ending value. 
                                    realCoordRead2 = Console.ReadLine(); //Reading that value
                                    realCoordEnd = double.Parse(realCoordRead2); //Parsing the value if the exception isn't hit
                                    break; //Ending the loop. 
                                }
                                catch (Exception string)
            {
                                    console.WriteLine("This value is not a number.")
            }
                                }
                            }
                            {


                                if (realCoordEnd >= realCoordStart)
                                {
                                    Console.WriteLine("Please enter a value lower than the starting value.")
                                            continue;
                                }
                                else
                                {
                                    realInterval = ((realCoordStart - realCoordEnd) / 80) //Calculating the interval needed 
                    acceptableValue2 == true //Ending the loop
                }
                            }


                            //Getting to the calculations for the set

                            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= imagInterval) //Setting variables 
                            {
                                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += realInterval) //Setting in variables
                                {
                                    iterations = 0;
                                    realTemp = realCoord;
                                    imagTemp = imagCoord;
                                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                                    while ((arg < 4) && (iterations < 40))
                                    {
                                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                                           - realCoord;
                                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                                        realTemp = realTemp2;
                                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                                        iterations += 1;
                                    }
                                    switch (iterations % 4)
                                    {
                                        case 0:
                                            Console.Write(".");
                                            break;
                                        case 1:
                                            Console.Write("o");
                                            break;
                                        case 2:
                                            Console.Write("O");
                                            break;
                                        case 3:
                                            Console.Write("@");
                                            break;
                                    }
                                }
                                Console.Write("\n");
                            }

                        }
                    }
                }
