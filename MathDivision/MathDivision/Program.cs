using System;

namespace MathDivision
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function

        delegate double myRoundDel(double value, int roundTo);

        static double myRound(double value, int roundTo)
        {
            double multiplier = Math.Pow(10, roundTo);
            double roundedValue = Math.Round(value * multiplier) / multiplier;
            return roundedValue;
        }

        static void Main(string[] args)
        {
            myRoundDel MyRoundDel = myRound;
            double roundedValue = MyRoundDel(4.1729, 2);
            Console.WriteLine(roundedValue);
        }
    }
}

