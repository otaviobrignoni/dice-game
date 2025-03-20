namespace DiceGame.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Text.Game.ShowStart();
            Game.Start();
        } 
        while (Text.Input.ContinueGame());
    }
}
