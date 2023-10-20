using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MyMethod.Program;

namespace MyMethod
{
    internal class Program
    {

        
        

        public interface IInterface
        {
            void myMethod();
        }

        public class Class1: IInterface
        {
            public void myMethod()
            {
                Console.WriteLine("Class1 implementing interface");
            }
        } 
        public class Class2: IInterface
        {
            public void myMethod()
            {
                Console.WriteLine("Class2 implementing interface.");
            }
        }
        static void Main(string[] args)
        {
            // Create instances of both classes
            IInterface obj1 = new Class1();
            IInterface obj2 = new Class2();

            // Call the MyMethod on each object
            obj1.myMethod(); 
            obj2.myMethod();
        }
        public static void CallMethod(IInterface myObject)
        {
            myObject.myMethod();
        }
    }
}
