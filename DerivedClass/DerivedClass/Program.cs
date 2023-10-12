using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass
{

    public class MyClass //Setting up private string
    {
        private string myString;

        public MyClass(string stringOne) 
        {
            myString = stringOne;
        }

        public virtual string GetString() //returning myString for use later
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass { //Class derived from MyClass

        public MyDerivedClass(string stringOne) : base(stringOne) //using stringOne as base
        {
        //Empty
        }
    public override string GetString() //overriding getstring
        {
            string baseString = base.GetString();
            return baseString + " other wolves from derived"; //what will be added from derived class
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass DerivedObject = new MyDerivedClass("wolves from base and"); //what will be added from base class
            string result = DerivedObject.GetString();
            Console.WriteLine(result); //shows result in console
        }
    }
}
