using System.Security.Cryptography.X509Certificates;

namespace Decorator_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLaunch(CreatePlayer());
        }
        public static void GameLaunch(ICharacter character)
        {
            Game game = new Game(character);
            Console.WriteLine("You have begun. This is a game of choices. Will you find the right relics to defeat your final foe?");
            Console.WriteLine("The path lies ahead... good luck.");
            game.LevelOne();
            Console.WriteLine("You return to the path and carry on.");
            game.LevelTwo();
            Console.WriteLine("Continuing your journey, you trek onward.");
            game.LevelThree();
            Console.WriteLine("Returning to the path, it winds further.");
            game.LevelFour();
            Console.WriteLine("Once more bringing your feet to the path.");
            game.LevelFive();
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
    }
}
