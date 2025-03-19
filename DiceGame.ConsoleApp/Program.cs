namespace DiceGame.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int finishLine = 30;

        while (true)
        {
            int playerPosition = 0;
            bool ongoingGame = true;

            while (ongoingGame)
            {
                Console.Clear();
                Console.WriteLine("Dice Game");
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();

                int result = RandomNumber();

                Console.WriteLine($"The dice rolled {result}");

                playerPosition += result;

                Console.WriteLine($"You are in the position {playerPosition} of {finishLine}");

                if (playerPosition == 5 || playerPosition == 10 || playerPosition == 15 || playerPosition == 25)
                {
                    int tileAdvance = RandomNumber();
                    playerPosition += tileAdvance;
                    string plural;
                    
                    if (tileAdvance == 1)
                        plural = "tile";
                    else
                        plural = "tiles";

                    Console.WriteLine("Special Event: Advance " + tileAdvance + " {0}", plural);
                    Console.WriteLine($"You landed on the position {playerPosition} of {finishLine}");
                }
                else if (playerPosition == 7 || playerPosition == 13 || playerPosition == 20)
                {
                    int tileRetreat = RandomNumber();
                    playerPosition -= tileRetreat;
                    string plural;

                    if (tileRetreat == 1)
                        plural = "tile";
                    else
                        plural = "tiles";

                    Console.WriteLine("Special Event: Retreat " + tileRetreat + " {0}", plural);
                    Console.WriteLine($"You landed on the position {playerPosition} of {finishLine}");
                }


                if (playerPosition >= finishLine)
                {
                    ongoingGame = false;
                    Console.WriteLine("You reached the finish line");
                } 

                Console.WriteLine("Press any key to proceed...");
                Console.ReadKey();

            }
            char continueChar = ContinuePrompt();
            if (continueChar != 'Y')
                break;
        }
    }

    public static int RandomNumber()
    {
        Random numberGenerator = new Random();
        int n = numberGenerator.Next(1, 7);
        return n;
    }

    public static char ContinuePrompt()
    {
        Console.Write("Do you wish to continue? (Y/N) -> ");
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
