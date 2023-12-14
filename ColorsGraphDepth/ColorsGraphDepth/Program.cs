using System;
using System.Collections.Generic;

namespace ColorsGraphDepth
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
            { true, false, true, false, false, false, false, false }, // DarkBlue
            { false, false, false, true, false, false, false, false }, // Red
            { true, false, false, false, true, false, false, false }, // Grey
            { false, false, false, true, false, true, false, false }, // Orange
            { false, false, false, false, false, false, true, false }, // Purple
            { false, false, false, false, false, true, false, false }, // Yellow
            { false, false, false, false, false, false, false, false }  // Green
        };

        //list
        static List<int>[] adjacencyList = new List<int>[]
        {
            // LightBlue, DarkBlue, Red, Grey, Orange, Purple, Yellow, Green
            new List<int> { 1, 3 }, // LightBlue
            new List<int> { 0, 8 }, // DarkBlue
            new List<int> { 1, 5 }, // Red
            new List<int> { 0, 1, 4 }, // Grey
            new List<int> { 3, 5 }, // Orange
            new List<int> { 1 }, // Purple
            new List<int> { 6 }, // Yellow
            new List<int> { } // Green
        };

        //keep track of visited 
        static bool[] visited = new bool[adjacencyMatrix.GetLength(0)];

        static void Main(string[] args)
        {
            Console.WriteLine("Depth-First Search starting from Red:");

            // start from red at index 2
            DFS((int)Colors.Red);


            Console.ReadLine(); // pause view output
        }

        static void DFS(int vertex)
        {
            Console.WriteLine((Colors)vertex); // output current color
            visited[vertex] = true;

            for (int neighbor = 0; neighbor < adjacencyMatrix.GetLength(1); neighbor++)
            {
                if (adjacencyMatrix[vertex, neighbor] && !visited[neighbor])
                {
                    DFS(neighbor);
                }
            }
        }
    }
}
