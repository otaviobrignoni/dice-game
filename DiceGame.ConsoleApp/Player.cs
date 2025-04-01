namespace DiceGame.ConsoleApp;

class Player
{
    public string Name;
    public int Position;
    public bool IsCPU { get; private set; }
    string playerType;

    public Player(string name, bool isCPU)
    {
        Name = name;
        IsCPU = isCPU;
        Position = 0;
        playerType = IsCPU ? $"BOT {Name}" : Name;
    }

    public void ShowTurn()
    {
        Console.Clear();
        Console.Write("\x1b[3J");
        string title = IsCPU ? $"BOT {Name}'s turn" : $"{Name}'s turn";
        int padding = (Text.gameWidth - title.Length) / 2;
        Console.WriteLine(new string('─', Text.gameWidth));
        Console.WriteLine(title.PadLeft(padding + title.Length).PadRight(Text.gameWidth));
        Console.WriteLine(new string('─', Text.gameWidth));
    }
    public void ShowAfterEventPosition(int finishLine)
    {
        Console.WriteLine($"{playerType} landed on the position {Position} of {finishLine}");
        Console.WriteLine(new string('─', Text.gameWidth));
    }
    public void ShowPosition(int finishLine)
    {
        Console.WriteLine();
        Console.WriteLine(new string('─', Text.gameWidth));
        Console.WriteLine($"{playerType} is on the position {Position} of {finishLine}");
        Console.WriteLine(new string('─', Text.gameWidth));
    }
    public void ShowFinishLine()
    {
        Console.WriteLine();
        Console.WriteLine(new string('─', Text.gameWidth));
        Console.WriteLine($"{playerType} reached the finish line");
        Console.WriteLine(new string('─', Text.gameWidth));
    }
    public void PromptDiceRoll()
    {
        if (IsCPU)
        {
            Console.WriteLine($"BOT {Name} is rolling the dice...");
            Console.WriteLine(new string('─', Text.gameWidth));
            Thread.Sleep(800);
        }
        else
        {
            Console.WriteLine("Press any key to roll the dice...");
            Console.WriteLine(new string('─', Text.gameWidth));
            Console.ReadKey();
        }
    }

}
