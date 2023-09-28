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
        struct Employee //Struct instead of parameters. 
        {
            public string sName;
            public double dSalary;
        }

        static bool GiveRaise(ref Employee employee) //Struct passed instead of parameters.
        {

            if (employee.sName == "elizabeth") //Checking name
            {
                employee.dSalary += 19999.99; //If yes, adds money
                return true; //Returns true
            }
            else
            {
                return false; //Returns false
            }
        }
        static void Main(string[] args) //Main function.
        {
            
        Employee employee = new Employee();
            employee.dSalary = 30000;
            Console.WriteLine("What is your name?"); //Asking for name
            employee.sName = Console.ReadLine();
            bool raiseGranted = GiveRaise(ref employee); //Passing values into the function

            if (raiseGranted) //Checking if raise was granted.
            {
                Console.WriteLine("Congrats, you got a raise!");
            }
            else
            {
                Console.WriteLine("No raise for you >:)");
            }

            //Updated salary goes here.
            Console.WriteLine($"Your salary: {employee.dSalary}");
        }


    }
}
