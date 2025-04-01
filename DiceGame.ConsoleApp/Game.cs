using System.Reflection.Metadata;

namespace DiceGame.ConsoleApp;

class Game
{
    const int finishLine = 30;
    static readonly int[] goodEventTiles = { 5, 10, 15, 25 };
    static readonly int[] badEventTiles = { 7, 13, 20 };
    public static void Run()
    {
        Player user = new Player("User", false);
        Player cpu = new Player("Dave", true);
        Player[] players = [user, cpu];
        bool ongoingGame = true;

        while (ongoingGame)
        {
            foreach (Player player in players)
            {
                player.ShowTurn();
                Turn(player);
                if (player.Position >= finishLine)
                {
                    ongoingGame = false;
                    player.ShowFinishLine();
                    break;
                }
                Text.Input.ShowAnyKeyInput();
            }
        }
    }

    public static void Turn(Player player)
    {
        player.PromptDiceRoll();
        int result = RandomNumber();
        Text.Game.ShowDiceRoll(result);
        player.Position += result;

        player.ShowPosition(finishLine);

        if (goodEventTiles.Contains(player.Position))
        {
            int tileAdvance = RandomNumber();
            player.Position += tileAdvance;
            Text.Game.ShowGoodSpecialEvent(tileAdvance);
            player.ShowAfterEventPosition(finishLine);

        }
        else if (badEventTiles.Contains(player.Position))
        {
            int tileRetreat = RandomNumber();
            player.Position -= tileRetreat;
            Text.Game.ShowBadSpecialEvent(tileRetreat);
            player.ShowAfterEventPosition(finishLine);

        }
    }

    public static int RandomNumber()
    {
        Random numberGenerator = new Random();
        return numberGenerator.Next(1, 7);
    }
}
