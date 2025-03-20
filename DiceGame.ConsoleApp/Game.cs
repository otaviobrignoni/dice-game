namespace DiceGame.ConsoleApp;

class Game
{    
    public static void Start()
    {
        const int finishLine = 30;
        int playerPosition = 0;
        int cpuPosition = 0;
        bool ongoingGame = true;

        while (ongoingGame)
        {
            Text.Player.ShowTurn();
            Logic(playerPosition, finishLine, false, out playerPosition);
            Text.Input.ShowAnyKeyInput();
            if (playerPosition >= finishLine)
            {
                ongoingGame = false;
                Text.CPU.ShowFinishLine();
                continue;
            }

            Text.CPU.ShowTurn();
            Logic(cpuPosition, finishLine, true, out cpuPosition);
            if (cpuPosition >= finishLine)
            {
                ongoingGame = false;
                Text.Player.ShowFinishLine();
                continue;
            }
            Text.Input.ShowAnyKeyInput();
        }
    }

    public static void Logic(int currentPosition, int finishLine, bool isCPU, out int updatedPosition)
    {
        updatedPosition = currentPosition;

        if (!isCPU)
        {
            Text.Player.RollDice();
        }
        else
        {
            Text.CPU.RollDice();
        }

        int result = RandomNumber();
        Text.Game.ShowDiceRoll(result);
        updatedPosition += result;

        if (!isCPU)
            Text.Player.ShowPosition(updatedPosition, finishLine);
        else
            Text.CPU.ShowPosition(updatedPosition, finishLine);

        if (updatedPosition == 5 || updatedPosition == 10 || updatedPosition == 15 || updatedPosition == 25)
        {
            int tileAdvance = RandomNumber();
            updatedPosition += tileAdvance;
            Text.Game.ShowGoodSpecialEvent(tileAdvance);
            if (!isCPU)
            {
                Text.Player.ShowAfterEventPosition(updatedPosition, finishLine);
            }
            else
            {
                Text.CPU.ShowAfterEventPosition(updatedPosition, finishLine);
            }
        }
        else if (updatedPosition == 7 || updatedPosition == 13 || updatedPosition == 20)
        {
            int tileRetreat = RandomNumber();
            updatedPosition -= tileRetreat;
            Text.Game.ShowBadSpecialEvent(tileRetreat);
            
            if (!isCPU)
            {
                Text.Player.ShowAfterEventPosition(updatedPosition, finishLine);
            }
            else
            {
                Text.CPU.ShowAfterEventPosition(updatedPosition, finishLine);
            }
        }
    }

    public static int RandomNumber()
    {
        Random numberGenerator = new Random();
        int n = numberGenerator.Next(1, 7);
        return n;
    }
}
