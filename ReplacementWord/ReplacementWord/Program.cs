using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacementWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string, preferably containing the word 'no'");
            string enteredString = Console.ReadLine();
            var newString = enteredString.Replace("no", "yes");
            Console.WriteLine(newString);
        }
    }
}
