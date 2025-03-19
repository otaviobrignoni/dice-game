namespace DiceGame.ConsoleApp;

class Game
{
    public static void Logic(int currentPosition, int finishLine, bool isCPU, out int updatedPosition)
    {
        updatedPosition = currentPosition;

        if (!isCPU)
        {
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Computer is rolling the dice");
            Thread.Sleep(900);
        }

        int result = RandomNumber();

        Console.WriteLine($"The dice rolled {result}");

        updatedPosition += result;

        if (!isCPU)
            Console.WriteLine($"You are in the position {updatedPosition} of {finishLine}");
        else
            Console.WriteLine($"Computer is in the position {updatedPosition} of {finishLine}");

        if (updatedPosition == 5 || updatedPosition == 10 || updatedPosition == 15 || updatedPosition == 25)
        {
            int tileAdvance = RandomNumber();
            updatedPosition += tileAdvance;
            string plural;

            if (tileAdvance == 1)
                plural = "tile";
            else
                plural = "tiles";

            Console.WriteLine("Special Event: Advance " + tileAdvance + " {0}", plural);
            if (!isCPU)
                Console.WriteLine($"You landed on the position {updatedPosition} of {finishLine}");
            else
                Console.WriteLine($"Computer landed on the position {updatedPosition} of {finishLine}");
        }
        else if (updatedPosition == 7 || updatedPosition == 13 || updatedPosition == 20)
        {
            int tileRetreat = RandomNumber();

            updatedPosition -= tileRetreat;
            string plural;

            if (tileRetreat == 1)
                plural = "tile";
            else
                plural = "tiles";

            Console.WriteLine("Special Event: Retreat " + tileRetreat + " {0}", plural);
            if (!isCPU)
                Console.WriteLine($"You landed on the position {updatedPosition} of {finishLine}");
            else
                Console.WriteLine($"Computer landed on the position {updatedPosition} of {finishLine}");
        }
    }
    
    public static int RandomNumber()
    {
        Random numberGenerator = new Random();
        int n = numberGenerator.Next(1, 7);
        return n;
    }
}
