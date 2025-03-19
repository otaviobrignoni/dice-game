namespace DiceGame.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int finishLine = 30;

        while (true)
        {
            Console.WriteLine("Dice Game");
            int playerPosition = 0;
            int cpuPosition = 0;
            bool ongoingGame = true;

            while (ongoingGame)
            {
                Console.Clear();
                Console.WriteLine("Player's turn...");
                Game.Logic(playerPosition, finishLine, false, out playerPosition);
                Console.WriteLine("Press any key to proceed...");
                Console.ReadKey();

                if (playerPosition >= finishLine)
                {
                    ongoingGame = false;
                    Console.WriteLine("You reached the finish line");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("Computer's turn...");
                Game.Logic(cpuPosition, finishLine, true, out cpuPosition);

                if (cpuPosition >= finishLine)
                {
                    ongoingGame = false;
                    Console.WriteLine("Computer reached the finish line");
                    continue;
                }

                Console.WriteLine("Press any key to proceed...");
                Console.ReadKey();
            }
            char continueChar = ContinueGame();
            if (continueChar != 'Y')
                break;
        }
    }

    

    public static char ContinueGame()
    {
        Console.Write("Do you wish to play another game? (Y/N) -> ");
        string userInput = Console.ReadLine()!;
        while (userInput != "Y" && userInput != "N" && userInput != "y" && userInput != "n" || (userInput == null))
        {
            Console.Write("Invalid option, try again -> ");
            userInput = Console.ReadLine()!;
        }
        return userInput.ToUpper()[0];
    }

    public static int GetUserNumber()
    {
        int number;
        Console.Write("\nType a number -> ");
        while (!int.TryParse(Console.ReadLine(), out number))
            Console.Write("Invalid number, try again -> ");
        return number;
    }

    

}
