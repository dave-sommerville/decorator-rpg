using System.Security.Cryptography.X509Certificates;

namespace Decorator_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public void GameLaunch()
        {
            ICharacter character = CreatePlayer();
            Game game = new Game(character);
            Console.WriteLine("You have begun. This is a game of choices. Will you find the right relics to defeat your final foe?");
        }
        public ICharacter CreatePlayer()
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
