using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MathQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            myOrder.itemName = "bread";
            myOrder.unitCost = 1;
            myOrder.unitCount = 5;

            Console.WriteLine("order total = " + myOrder.Order2());
            Console.WriteLine(myOrder.Order3());

        }
        struct Order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double Order2()
            {
                return unitCount * unitCost;
            }

            public string Order3()
            {
               Console.WriteLine("", unitCount, itemName, "items at $", unitCost, "each, total cost $", Order2());
                string stringFinal = Console.ReadLine();
                return stringFinal;

            }
        }


    }
}
