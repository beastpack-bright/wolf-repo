using System;
using System.Linq;

class Program
{
    // the definition of the delegate function data type
    delegate string SortingFunction(string[] a);

    static void Main(string[] args)
    {
        // declare the unsorted and sorted arrays
        string[] aUnsorted;
        string[] aSorted;

        // Declaring a delegate variable 
        SortingFunction findFirstLast;

    // a label to allow us to easily loop back to the start if there are input issues
    start:
        Console.WriteLine("Enter a list of space-separated words");

        // read the string of words
        string sWords = Console.ReadLine();

        // split the string into an array 
        string[] sWordArray = sWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //Removing empty entries.

        // Initialize length, set to 0
        int nUnsortedLength = 0;

        // Iterating through the array of words
        foreach (string sThisWord in sWordArray)
        {
            if (!string.IsNullOrWhiteSpace(sThisWord)) //String is not null or white space. This removes empty entries.
            {
                // Not empty = increase array length
                ++nUnsortedLength;
            }
        }

        // now we know how many unsorted words there are!!!!!!!!!!!!!!!!!!!!!!
        // allocate the size of the unsorted array
        aUnsorted = new string[nUnsortedLength];

        // reset nUnsortedLength back to 0 
        nUnsortedLength = 0;
        foreach (string sThisWord in sWordArray) //Iterating again
        {
            if (!string.IsNullOrWhiteSpace(sThisWord)) //If its not null or white space
            {
                // if the word is not empty or whitespace, store it in the unsorted array
                aUnsorted[nUnsortedLength] = sThisWord;

                // increment the array index
                nUnsortedLength++;
            }
        }

        // size of sorted array
        aSorted = new string[nUnsortedLength];

        // Prompting for ascending or descending order.
        Console.Write("Sort the string by ascending or descending order? (a/d)");
        string sSortOption = Console.ReadLine();

        if (sSortOption.ToLower() == "a")
        {
            findFirstLast = new SortingFunction(Ascending); //To decide whether its ascending or descending order. 
        }
        else
        {
            findFirstLast = new SortingFunction(Descending); //If not ascending, descending. 
        }

        // start the sorted length at 0 
        int nSortedLength = 0;

        // while there are unsorted values to sort
        while (aUnsorted.Length > 0)
        {
            // store the word with the first or last letter as the next sorted value
            aSorted[nSortedLength] = findFirstLast(aUnsorted);

            // remove the current sorted value
            RemoveUnsorted(aSorted[nSortedLength], ref aUnsorted);

            // array length + 
            ++nSortedLength;
        }

        // write the sorted array of words
        foreach (string thisWord in aSorted)
        {
            Console.Write($" {thisWord}");
        }

        Console.WriteLine();

        // prompt if they want to play again
        Console.Write("Do you want to play again? (yes/no): ");
        string sPlayAgain = Console.ReadLine();
        if (sPlayAgain.ToLower() == "yes")
        {
            goto start;
        } else if (sPlayAgain.ToLower() == "y")
        {
            goto start;
        }
    }

    // sorting by ascending
    static string Ascending(string[] array)
    {
        // find the word with the earliest first letter
        string minWord = array.Min();

        // remove the word from the array
        RemoveUnsorted(minWord, ref array);

        // return the word with the earliest first letter
        return minWord;
    }

    // sort by the last letter
    static string Descending(string[] array)
    {
        // find the word with the earliest last letter
        string minWord = array.OrderBy(word => word[word.Length - 1]).First();

        // remove the word from the array
        RemoveUnsorted(minWord, ref array);

        // return the word with the earliest last letter
        return minWord;
    }

    // remove a word from the unsorted array
    static void RemoveUnsorted(string removeValue, ref string[] array)
    {
        // create a new array with one less element
        string[] newArray = new string[array.Length - 1];

        // counter for the new array index
        int dest = 0;

        // iterate through the source array
        foreach (string srcWord in array)
        {
            // if this is the word to be removed, skip it (do not add it to the new array)
            if (srcWord == removeValue)
            {
                continue;
            }

            // insert the source word into the new array
            newArray[dest] = srcWord;

            // increment the new array index to insert the next word
            ++dest;
        }

        // set the ref array equal to the new array, which has the target word removed
        // this changes the variable in the calling function (aUnsorted in this case)
        array = newArray;
    }
}
