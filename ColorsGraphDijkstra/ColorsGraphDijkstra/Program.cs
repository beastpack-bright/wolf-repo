using System;
using System.Collections.Generic;
using System.Linq;

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
        static bool[,] adjacencyMatrix = new bool[,]
        {
            // LightBlue, DarkBlue, Red, Grey, Orange, Purple, Yellow, Green
            { false, true, false, true, false, false, false, false }, // LightBlue
            { true, false, true, false, false, false, false, false }, // DarkBlue
            { false, false, false, true, false, false, false, false }, // Red
            { true, false, true, false, true, false, false, false }, // Grey
            { false, false, false, true, false, true, false, false }, // Orange
            { false, false, false, false, true, false, false, false }, // Purple
            { false, false, false, false, false, false, false, true }, // Yellow
            { false, false, false, false, false, false, true, false }  // Green
        };

        static List<int>[] adjacencyList = new List<int>[]
        {
            // LightBlue, DarkBlue, Red, Grey, Orange, Purple, Yellow, Green
            new List<int> { 1, 3 }, // LightBlue
            new List<int> { 0, 2, 8 },    // DarkBlue
            new List<int> { 1, 5 },    // Red
            new List<int> { 0, 2, 4 }, // Grey
            new List<int> { 3, 5 },    // Orange
            new List<int> { 4, 6 },    // Purple
            new List<int> { 7 },    // Yellow
            new List<int> { 6 }     // Green
        };

        static void Main(string[] args)
        {
            // start at red, index 2
            int startNode = (int)Colors.Red;

            // Run algorithm
            List<int> shortestPath = GetShortestPathDijkstra(startNode);

            
            Console.WriteLine("Shortest Path:");

            foreach (int nodeIndex in shortestPath)
            {
                Console.WriteLine($"{(Colors)nodeIndex}");
            }
        }
        //getting shortest path
        static List<int> GetShortestPathDijkstra(int startNode)
        {
            //distances, nodes and visited
            int[] distances = new int[adjacencyMatrix.GetLength(0)]; 
            int[] previousNodes = new int[adjacencyMatrix.GetLength(0)];
            bool[] visited = new bool[adjacencyMatrix.GetLength(0)];

            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
                previousNodes[i] = -1;
                visited[i] = false;
            }

            distances[startNode] = 0;

            List<int> priorityQueue = new List<int> { startNode };

            while (priorityQueue.Any())
            {
                priorityQueue = priorityQueue.OrderBy(node => distances[node]).ToList();

                int currentNode = priorityQueue.First();
                priorityQueue.Remove(currentNode);

                if (visited[currentNode])
                {
                    continue;
                }

                visited[currentNode] = true;
                //printing nodes visited in the path and their distance from the current node
                Console.WriteLine($"Visiting node: {(Colors)currentNode}, Distance: {distances[currentNode]}");
                //getting lengths
                for (int neighbor = 0; neighbor < adjacencyMatrix.GetLength(1); neighbor++)
                {
                    if (adjacencyMatrix[currentNode, neighbor])
                    {
                        int newDistance = distances[currentNode] + 1; 

                        if (newDistance < distances[neighbor])
                        {
                            distances[neighbor] = newDistance;
                            previousNodes[neighbor] = currentNode;
                            priorityQueue.Add(neighbor);
                        }
                    }
                }
            }
            //list of shortest path
            List<int> shortestPath = new List<int>();
            int currentNodeIndex = startNode;

            while (currentNodeIndex != -1)
            {
                shortestPath.Add(currentNodeIndex);
                currentNodeIndex = previousNodes[currentNodeIndex];
            }
            //revresing it 
            shortestPath.Reverse();
            return shortestPath;
        }
    }
}
