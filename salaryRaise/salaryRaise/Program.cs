using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace salaryRaise
{
    static internal class Program
    {

        static bool GiveRaise(string name, ref double salary) //Checking whether or not the name would warrant in a raise.
        {
            
            if (name == "elizabeth") //Checking name
            {
                salary = salary + 19999.99; //If yes, adds money
                return true; //Returns true
            }
            else
            {
                return false; //Returns false
            }
        }
        static void Main(string[] args) //Main function.
        {
            string sName; //Setting up variables.
            double dSalary = 30000;
            Console.WriteLine("What is your name?"); //Asking for name
            sName = Console.ReadLine();
            bool raiseGranted = GiveRaise(sName, ref dSalary); //Passing values into the function

            if (raiseGranted) //Checking if raise was granted.
            {
                Console.WriteLine("Congrats, you got a raise!");
            }
            else
            {
                Console.WriteLine("No raise for you >:)");
            }

            //Updated salary goes here.
            Console.WriteLine($"Your salary: {dSalary}");
        }


    }
    }
