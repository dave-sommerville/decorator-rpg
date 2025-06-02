using Decorator_RPG;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            GameLaunch(CreatePlayer());
        } while (PromptNewGame());
    }

    public static void GameLaunch(ICharacter character)
    {
        Game game = new Game(character);
        Console.WriteLine("You have begun. This is a game of choices. Will you find the right relics to defeat your final foe?");
        Console.WriteLine("The path lies ahead... good luck.");
        int currentLevel = 1;
        while (currentLevel <= 5)
        {
            switch (currentLevel)
            {
                case 1: game.LevelOne(); break;
                case 2: game.LevelTwo(); break;
                case 3: game.LevelThree(); break;
                case 4: game.LevelFour(); break;
                case 5: game.LevelFive(); break;
            }
            currentLevel = game.Level;
            if (currentLevel <= 5)
                Console.WriteLine("You return to the path and carry on.");
        }
        game.ResultsReading(game.FinalBossFight());
    }

    public static ICharacter CreatePlayer()
    {
        Console.WriteLine("Welcome to the game! Please enter your character's name:");
        string playerName = Console.ReadLine().Trim();
        Console.WriteLine("Please enter a description for your character:");
        string desc = Console.ReadLine().Trim();
        ICharacter character = new Character(playerName, desc);
        return character;
    }

    public static bool PromptNewGame()
    {
        Console.WriteLine("New game? (Y/N)");
        while (true)
        {
            string input = Console.ReadLine().Trim().ToUpper();
            if (input == "Y") return true;
            if (input == "N") return false;
            Console.WriteLine("Please enter 'Y' or 'N'");
        }
    }
}