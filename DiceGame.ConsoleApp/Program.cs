namespace DiceGame.ConsoleApp;

internal class Program
{
    

    static void Main(string[] args)
    {
        do
        {
            Console.Title = "Dice Game";
            Text.Game.ShowStart();
            Game.Run();
        } 
        while (Text.Input.PromptContinueGame());
    }
}
