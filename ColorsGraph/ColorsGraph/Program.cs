using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsGraph
{
    enum Colors
    {
        LightBlue,
        DarkBlue,
        Red,
        Grey,
        Orange,
        Purple,
        Yellow,
        Green
    }

    static class Program
    {
        //matrix 
        static bool[,] adjacencyMatrix = new bool[,]
        {
            // LightBlue, DarkBlue, Red, Grey, Orange, Purple, Yellow, Green
            { false, true, false, true, false, false, false, false }, // LightBlue
            { true, false, false, false, false, false, false, false }, // DarkBlue
            { false, false, false, true, false, false, false, false }, // Red
            { true, false, false, false, true, false, false, false }, // Grey
            { false, false, false, true, false, true, false, false }, // Orange
            { false, false, false, false, false, false, true, false }, // Purple
            { false, false, false, false, false, true, false, false }, // Yellow
            { false, false, false, false, false, false, true, false }  // Green
        };

        //list
        static List<int>[] adjacencyList = new List<int>[]
        {
            // LightBlue, DarkBlue, Red, Grey, Orange, Purple, Yellow, Green
            new List<int> { 1, 3 }, // LightBlue
            new List<int> { 0 },    // DarkBlue
            new List<int> { 3 },    // Red
            new List<int> { 0, 2, 4 }, // Grey
            new List<int> { 3, 5 },    // Orange
            new List<int> { 5 },    // Purple
            new List<int> { 4, 6 },    // Yellow
            new List<int> { 6 }     // Green
        };

        static void Main(string[] args)
        {
            //empty for now 
        }
    }
}