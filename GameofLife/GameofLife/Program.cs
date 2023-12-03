using System;
using System.IO;
using System.Threading;

class GameOfLife
{
    static int width = 20;
    static int height = 10;
    static bool[,] grid = new bool[width, height];

    static void Main()
    {
        Console.WriteLine("Welcome to Conway's Game of Life!");
        InitializeGrid();

        while (true)
        {
            DisplayGrid();
            Console.WriteLine("Press 'Q' to quit.");

            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Q)
                    break;
            }

            Evolve();
            Thread.Sleep(500); // Add a delay of 500 milliseconds between generations
        }
    }

    static void InitializeGrid()
    {
        Console.WriteLine("Do you want to use the Organism Editor? (Y/N)");
        if (Console.ReadKey().Key == ConsoleKey.Y)
            UseOrganismEditor();
        else
            RandomizeGrid();
    }

    static void UseOrganismEditor()
    {
        Console.WriteLine("\nOrganism Editor - Instructions:");
        Console.WriteLine("1. Use arrow keys to navigate.");
        Console.WriteLine("2. Press 'A' to toggle cell state (Alive/Dead).");
        Console.WriteLine("3. Press 'S' to save the current state to a file.");
        Console.WriteLine("4. Press 'L' to load a state from a file.");
        Console.WriteLine("5. Press 'Enter' to start the simulation.");

        int cursorX = 0, cursorY = 0;

        while (true)
        {
            DisplayGrid(cursorX, cursorY);
            var key = Console.ReadKey().Key;

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

    static void RandomizeGrid()
    {
        Random random = new Random();
        for (int i = 0; i < width; i++)
            for (int j = 0; j < height; j++)
                grid[i, j] = random.Next(2) == 0; // 50% chance of being alive
    }

    static void ToggleCellState(int x, int y)
    {
        grid[x, y] = !grid[x, y];
    }

    static void SaveToFile()
    {
        Console.Write("\nEnter the file name to save: ");
        string fileName = Console.ReadLine();

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

    static void LoadFromFile()
    {
        Console.Write("\nEnter the file name to load: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
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
        {
            Console.WriteLine($"File {fileName} not found.");
        }
    }

    static void DisplayGrid(int cursorX = -1, int cursorY = -1)
    {
        Console.Clear();

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == cursorX && j == cursorY)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(grid[i, j] ? "■" : " ");
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
                    // Any live cell with fewer than two live neighbors dies (underpopulation)
                    // Any live cell with two or three live neighbors lives on to the next generation
                    // Any live cell with more than three live neighbors dies (overpopulation)
                    newGrid[i, j] = neighbors == 2 || neighbors == 3;
                }
                else
                {
                    // Any dead cell with exactly three live neighbors becomes a live cell (reproduction)
                    newGrid[i, j] = neighbors == 3;
                }
            }
        }

        grid = newGrid;
    }

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

        return count;
    }
}
