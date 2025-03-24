namespace DiceGame.ConsoleApp;

class Text
{
    const int gameWidth = 48;
    public class Game
    {
        public static void ShowStart()
        {
            Console.Clear(); 
            Console.WriteLine("\x1b[3J");
            string title = "Dice Game";
            int padding = (gameWidth - title.Length) / 2;
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine(title.PadLeft(padding + title.Length).PadRight(gameWidth));
            Console.WriteLine(new string('─', gameWidth));
            Console.Write("Staring in 3... ");
            Thread.Sleep(1000);
            Console.Write("2... ");
            Thread.Sleep(1000);
            Console.Write("1...");
            Thread.Sleep(1000);
        }
        public static void ShowDiceRoll(int result)
        {
            Console.WriteLine($"The dice rolled {result}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowGoodSpecialEvent(int advance)
        {
            string tile;
            if (advance == 1)
                tile = "tile";
            else
                tile = "tiles";

            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine($"Special Event: Advance {advance} {tile}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowBadSpecialEvent(int retreat)
        {
            string tile;
            if (retreat == 1)
                tile = "tile";
            else
                tile = "tiles";

            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine($"Special Event: Retreat {retreat} {tile}");
            Console.WriteLine(new string('─', gameWidth));
        }
    }
    public class CPU
    {
        public static void ShowTurn()
        {
            Console.Clear(); 
            Console.WriteLine("\x1b[3J");
            string title = "Computer's turn";
            int padding = (gameWidth - title.Length) / 2;
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine(title.PadLeft(padding + title.Length).PadRight(gameWidth));
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowPosition(int position, int finishLine)
        {
            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine($"Computer is in the position {position} of {finishLine}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowAfterEventPosition(int position, int finishLine)
        {
            Console.WriteLine($"Computer landed on the position {position} of {finishLine}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowFinishLine()
        {
            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine("Computer reached the finish line");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void PromptRollDice()
        {
            Console.WriteLine("Computer is rolling the dice");
            Console.WriteLine(new string('─', gameWidth));
            Thread.Sleep(837);
        }
    }
    public class Player
    {
        public static void ShowTurn()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            string title = "Player's turn";
            int padding = (gameWidth - title.Length) / 2;
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine(title.PadLeft(padding + title.Length).PadRight(gameWidth));
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowAfterEventPosition(int position, int finishLine)
        {
            Console.WriteLine($"You landed on the position {position} of {finishLine}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowPosition(int position, int finishLine)
        {
            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine($"You are in the position {position} of {finishLine}");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void ShowFinishLine()
        {
            Console.WriteLine();
            Console.WriteLine(new string('─', gameWidth));
            Console.WriteLine("You reached the finish line");
            Console.WriteLine(new string('─', gameWidth));
        }
        public static void PromptDiceRoll()
        {
            Console.WriteLine("Press any key to roll the dice...");
            Console.WriteLine(new string('─', gameWidth));
            Console.ReadKey();
        }
    }
    public class Input
    {
        public static void ShowAnyKeyInput()
        {
            Console.WriteLine("Press any key to proceed...");
            Console.WriteLine(new string('─', gameWidth));
            Console.ReadKey();
        }
        public static bool PromptContinueGame()
        {
            Console.Write("Do you wish to play another game? (Y/N) -> ");
            string userInput = Console.ReadLine()!;
            while (userInput != "Y" && userInput != "N" && userInput != "y" && userInput != "n" || (userInput == null))
            {
                Console.Write("Invalid option, try again -> ");
                userInput = Console.ReadLine()!;
            }
            return userInput.ToUpper()[0] == 'Y';
        }
    }
}

