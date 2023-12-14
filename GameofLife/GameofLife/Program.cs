using System;
using System.IO;
using System.Threading;
//Notes: Got game of life to work, but couldn't get organism editor to work in time. 
class GameOfLife
{//creating a grid that will be used for the squares
    static int width = 20;
    static int height = 10;
    static bool[,] grid = new bool[width, height];

    static void Main()
    {
        Console.WriteLine("Conway's Game of Life");
        InitializeGrid();
        //while there is a grid 
        while (true)
        {
            DisplayGrid();
            Console.WriteLine("'Q' to quit.");

            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Q)
                    break;
            }

            Evolve();
            Thread.Sleep(500); // Add a delay of 500 milliseconds between generations
            //this is so you can see it moving but its not too fast or too slow 
        }
    }

    //grid SUMMON! make GRID!! 
    static void InitializeGrid()
    {
        //organism editor sadly not working, but this would initialize it if yes
        Console.WriteLine("Do you want to use the Organism Editor? (Y/N)");
        if (Console.ReadKey().Key == ConsoleKey.Y)
            UseOrganismEditor();
        else
            RandomizeGrid();
    }

    static void UseOrganismEditor()
    {
        //I tried! Here are all of the controls.
        Console.WriteLine("\nOrganism Editor - Instructions:");
        Console.WriteLine("Use arrow keys to navigate.");
        Console.WriteLine("Press 'A' to toggle cell state (Alive/Dead).");
        Console.WriteLine(" Press 'S' to save the current state to a file.");
        Console.WriteLine(" Press 'L' to load a state from a file.");
        Console.WriteLine(" Press 'Enter' to start the simulation.");
        //tracks cursor
        int cursorX = 0, cursorY = 0;

        while (true)
        {
            //displaying grid at cursor, so you can input symbols
            DisplayGrid(cursorX, cursorY);
            var key = Console.ReadKey().Key;
            //key commands 
            if (key == ConsoleKey.Enter)
                break;
            else if (key == ConsoleKey.A)
                ToggleCellState(cursorX, cursorY);
            else if (key == ConsoleKey.S)
                SaveToFile();
            else if (key == ConsoleKey.L)
                LoadFromFile();
            else if (key == ConsoleKey.LeftArrow && cursorX > 0)
                cursorX--;
            else if (key == ConsoleKey.RightArrow && cursorX < width - 1)
                cursorX++;
            else if (key == ConsoleKey.UpArrow && cursorY > 0)
                cursorY--;
            else if (key == ConsoleKey.DownArrow && cursorY < height - 1)
                cursorY++;
        }
    }
    //creates a new grid 
    static void RandomizeGrid()
    {
        Random random = new Random();
        for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
                grid[i, j] = random.Next(2) == 0; // 50% chance of being alive
    }
    //toggles cell between alive and dead
    static void ToggleCellState(int x, int y)
    {
        grid[x, y] = !grid[x, y];
    }
    //would be used for saving organism editor config
    static void SaveToFile()
    {
        Console.Write("\nEnter the file name: ");
        string fileName = Console.ReadLine();
        //it did not work. tried using streamwriter for it
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    writer.Write(grid[i, j] ? "1" : "0");
                }
                writer.WriteLine();
            }
        }
        
        Console.WriteLine($"Grid state saved to {fileName}");
    }
    //This part also didn't end up working out. 
    static void LoadFromFile()
    {
        Console.Write("\nEnter the file name to load: ");
        string fileName = Console.ReadLine();
        //Looking for file 
        if (File.Exists(fileName))
        {//Reading the file and inputting the grid 
            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < width && i < lines.Length; i++)
            {
                for (int j = 0; j < height && j < lines[i].Length; j++)
                {
                    grid[i, j] = lines[i][j] == '1';
                }
            }

            Console.WriteLine($"Grid state loaded from {fileName}");
        }
        else
        {//Error 
            Console.WriteLine($"File {fileName} not found.");
        }
    }
    //Displays the Game of Life grid 
    static void DisplayGrid(int cursorX = -1, int cursorY = -1)
    {//Clears console to start
        Console.Clear();
        //grid grid grid
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == cursorX && j == cursorY)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(grid[i, j] ? "■" : " "); //square
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(grid[i, j] ? "■" : " ");
                }
            }
            Console.WriteLine();
        }
    }

    //Game of Life rules implemented here
    static void Evolve()
    {
        bool[,] newGrid = new bool[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                int neighbors = CountAliveNeighbors(i, j);

                // Apply Game of Life rules
                if (grid[i, j])
                {
                    // Any live cell with fewer than two live neighbors dies 
                    // Any live cell with two or three live neighbors lives on to the next generation
                    // Any live cell with more than three live neighbors dies 
                    newGrid[i, j] = neighbors == 2 || neighbors == 3;
                }
                else
                {
                    // Any dead cell with exactly three live neighbors becomes a live cell
                    newGrid[i, j] = neighbors == 3;
                }
            }
        }

        grid = newGrid;
    }
    //for checking number of living neighbors 
    static int CountAliveNeighbors(int x, int y)
    {
        int count = 0;

        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && i < width && j >= 0 && j < height && !(i == x && j == y))
                {
                    if (grid[i, j])
                    {
                        count++;
                    }
                }
            }
        }
        //returns value
        return count;
    }
}
