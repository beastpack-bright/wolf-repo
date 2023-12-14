using System;
using System.IO;

class Program
{
    delegate double getArrayValueDelegate(double[] dArray);

    static double GetLowestArrayValue(double[] dArray)
    {
        // get the lowest value from dArray

        double dLowestValue = dArray[0];

        foreach (double value in dArray)
        {
            if (value < dLowestValue)
            {
                dLowestValue = value;
            }
        }

        return dLowestValue;
    }

    static double GetHighestArrayValue(double[] dArray)
    {
        // get the highest value from dArray
 

        double dHighestValue = dArray[0];

        foreach (double value in dArray)
        {
            if (value > dHighestValue)
            {
                dHighestValue = value;
            }
        }

        return dHighestValue;
    }

    static void RemoveArrayValue(double dValue, ref double[] dArray)
    {
        // remove dValue from dArray

        int index = Array.IndexOf(dArray, dValue);

        if (index != -1)
        {
            double[] newArray = new double[dArray.Length - 1];
            Array.Copy(dArray, 0, newArray, 0, index);
            Array.Copy(dArray, index + 1, newArray, index, dArray.Length - index - 1);
            dArray = newArray;
        }
    }

    static void RecursiveSort(ref double[] unsorted, ref double[] sorted, getArrayValueDelegate getArrayValue)
    {
        if (unsorted.Length > 0)
        {
            double thisValue = getArrayValue(unsorted);

            RemoveArrayValue(thisValue, ref unsorted);

            sorted[sorted.Length - unsorted.Length - 1] = thisValue;

            RecursiveSort(ref unsorted, ref sorted, getArrayValue);
        }
    }

    static void Main()
    { 

        // declare the delegate function variable
        getArrayValueDelegate getArrayValue;

        double[] aUnsorted;
        double[] aSorted;

        // counters for how many elements in each array
        int nUnsortedLength = 0;
        int nSortedLength = 0;

        string sSortDirection = null;

    start:

        // initialize our variables
        sSortDirection = null;
        nUnsortedLength = 0;

        Console.Write("Input any number of numbers separated by spaces -> ");
        string sList = Console.ReadLine();

        string[] sNumbers = sList.Split(' ');

        //  our unsorted array  based on length
        aUnsorted = new double[sNumbers.Length];

        foreach (string sNumber in sNumbers)
        {
            // if this word is an empty string 
            if (sNumber.Length == 0)
            {
                continue;
            }

            try
            {
                // convert to double
                aUnsorted[nUnsortedLength] = Convert.ToDouble(sNumber);
            }
            catch (Exception e)
            {
                // catch the exception
                Console.WriteLine();
                Console.WriteLine(e.Message);

                // get rid of invalid digits
                Console.WriteLine("Invalid digit at position " + (nUnsortedLength + 1));
                Console.WriteLine();

                // loop back new string of numbers
                goto start;
            }

            ++nUnsortedLength;
        }

        // ensure that nUnsortedLength == aUnsorted.Length
        if (nUnsortedLength != aUnsorted.Length)
        {
            double[] correctSizedArray = new double[nUnsortedLength];

            // copy the first elements into the correct array
            Array.Copy(aUnsorted, correctSizedArray, nUnsortedLength);
            aUnsorted = correctSizedArray;
        }

        // hold sorted values with correct size
        aSorted = new double[aUnsorted.Length];

        do
        {
            Console.Write("Sort in Ascending or Descending Order: ");
            sSortDirection = Console.ReadLine();
            sSortDirection = sSortDirection.ToLower();
        } while (!sSortDirection.Contains("asc") && !sSortDirection.Contains("des"));

        // 0 in resukt array
        nSortedLength = 0;

        if (sSortDirection.Contains("asc"))
        {
            //if sorting ascended
            getArrayValue = new getArrayValueDelegate(GetLowestArrayValue);
        }
        else
        {
            // ifsorted descended
            getArrayValue = new getArrayValueDelegate(GetHighestArrayValue);
        }

        // Call the sorting
        RecursiveSort(ref aUnsorted, ref aSorted, getArrayValue);

        // write out the sorted array
        for (int i = 0; i < nUnsortedLength; ++i)
        {
            Console.Write(aSorted[i] + " ");
        }

        Console.WriteLine();
    }
}
