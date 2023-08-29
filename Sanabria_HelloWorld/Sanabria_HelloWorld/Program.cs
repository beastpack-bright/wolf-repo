using System;


namespace Sanabria_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elizabeth Sanabria");
            string wolfString = "wolf";
            Console.WriteLine(wolfString + " is a " + wolfString);
            Console.WriteLine("5 + 91 equals:" + (5 + 91));
            if (wolfString == "wolf")
            {
                Console.WriteLine("oh boy a wolf");
            } else
            {
                Console.WriteLine("not a wolf?? impossible");
            }
        }
    }
}
