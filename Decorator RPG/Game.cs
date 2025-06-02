using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;

namespace Decorator_RPG
{
    public class Game
    {
        private ICharacter _character;
        public int Level { get; private set; } = 1;
        public Game(ICharacter character)
        {
            _character = character;
        }

        public static int PrintMenu(int options)
        {
            int intDecision;
            bool isValid;
            do
            {
                string decision = Console.ReadLine();
                isValid = int.TryParse(decision, out intDecision) && intDecision >= 0 && intDecision <= options;
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValid);
            return intDecision;
        }
        public void LevelOne()
        {
            Console.WriteLine("You arrive at your first choice.");
            Console.WriteLine("The path to your right is stone hallway");
            Console.WriteLine("The path to your left is a wide dirt tunnel.");
            Console.WriteLine("1) Go right\n2) Go left\n3) View Player Stats\n4) Exit Program");
            int choice = PrintMenu(3);
            switch(choice)
            {
                case 1:
                    GoodDefenseDecorator goodDefenseDecorator = new GoodDefenseDecorator(_character);
                    _character = goodDefenseDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 2:
                    BadDefenseDecorator badDefenseDecorator = new BadDefenseDecorator(_character);
                    _character = badDefenseDecorator;
                    Level++;
                    _character.SceneDescription();
                    Console.WriteLine();
                    break;
                case 3:
                                        Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void LevelTwo()
        {
            Console.WriteLine("As you carry on you come to your next choice.");
            Console.WriteLine("To your left is a closed door holding back an intense heat.");
            Console.WriteLine("The way to your right is a long dark tunnel.");
            Console.WriteLine("1) Go right\n2) Go left\n3) View Player Stats\n4) Exit Program");
            int choice = PrintMenu(4);
            switch (choice)
            {
                case 1:

                    BadMoveSpeedDecorator badMoveSpeedDecorator = new BadMoveSpeedDecorator(_character);
                    _character = badMoveSpeedDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 2:
                    GoodMoveSpeedDecorator goodMoveSpeedDecorator = new GoodMoveSpeedDecorator(_character);
                    _character = goodMoveSpeedDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Player Stats:");
                    Console.WriteLine(_character.GetDescription());
                    Console.WriteLine(_character.Inventory());
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void LevelThree()
        {
            Console.WriteLine("Pushing on, another choice comes your way.");
            Console.WriteLine("The way to your left is a long hallway with a light at the end.");
            Console.WriteLine("To your right is an ornate door.");
            Console.WriteLine("1) Go right\n2) Go left\n3) View Player Stats\n4) Exit Program");
            int choice = PrintMenu(4);
            switch (choice)
            {
                case 1:
                    BadStrengthDecorator badStrengthDecorator = new BadStrengthDecorator(_character);
                    _character = badStrengthDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 2:
                    GoodStrengthDecorator goodStrengthDecorator = new GoodStrengthDecorator(_character);
                    _character = goodStrengthDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Player Stats:");
                    Console.WriteLine(_character.GetDescription());
                    Console.WriteLine(_character.Inventory());
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void LevelFour()
        {
            Console.WriteLine("Wearily, you approach another choice.");
            Console.WriteLine("To your right the wall caved in, revealing an oppressive darkness");
            Console.WriteLine("The way to your right is a strong, but ajar, metal door.");
            Console.WriteLine("1) Go right\n2) Go left\n3) View Player Stats\n4) Exit Program");
            int choice = PrintMenu(4);
            switch(choice)
            {
                case 1:
                    GoodIntellectDecorator goodIntellectDecorator = new GoodIntellectDecorator(_character);
                    _character = goodIntellectDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 2: 
                    BadIntellectDecorator badIntellectDecorator = new BadIntellectDecorator(_character);
                    _character = badIntellectDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Player Stats:");
                    Console.WriteLine(_character.GetDescription());
                    Console.WriteLine(_character.Inventory());
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void LevelFive()
        {
            Console.WriteLine("You travel is nearly over, only one choice left to go.");
            Console.WriteLine("To your left, there is a oaken door with Elvish runes.");
            Console.WriteLine("The path on the left has a tunnel descending");
            Console.WriteLine("1) Go right\n2) Go left\n3) View Player Stats\n4) Exit Program");
            Console.WriteLine();
            Console.WriteLine();
            int choice = PrintMenu(4);
            switch (choice)
            {
                case 1:
                    GoodAgilityDecorator goodAgilityDecorator = new GoodAgilityDecorator(_character);
                    _character = goodAgilityDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 2:
                    BadAgilityDecorator badAgilityDecorator = new BadAgilityDecorator(_character);
                    _character = badAgilityDecorator;
                    _character.SceneDescription();
                    Level++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Player Stats:");
                    Console.WriteLine(_character.GetDescription());
                    Console.WriteLine(_character.Inventory());
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public int[] FinalBossStats()
        {
            int[] statsArray = new int[5];
            for(int i = 0; i < statsArray.Length; i++)
            {
                statsArray[i] = RandIndex();
            }
            return statsArray;
        }
        public int[] FinalPlayerStats()
        {
            int[] statsArray = new int[5];
            statsArray[0] = _character.Strength();
            statsArray[1] = _character.MoveSpeed();
            statsArray[2] = _character.Defense();
            statsArray[3] = _character.Intellect();
            statsArray[4] = _character.Agility();
            return statsArray;
        }
        public bool[] FinalBossFight()
        {
            Console.WriteLine("You have arrived at the end of your journey. Your choice have granted you the final boons.");
            Console.WriteLine(_character.Inventory());
            Console.WriteLine("You are now ready to face the final foe. Prepare yourself for the ultimate battle!");
            Console.WriteLine("The final foe appears, a towering figure shrouded in darkness, its eyes glowing with malice.");
            Console.WriteLine("It roars, shaking the ground beneath you, and you feel the weight of its power. You must now face it in a battle of stats!");
            int[] player = FinalPlayerStats();
            int[] boss = FinalBossStats();
            bool[] results = new bool[5];

            for (int i = 0; i < player.Length; i++)
            {
                if (player[i] > boss[i])
                {
                    results[i] = true; // Player wins this stat
                }
                else if (player[i] < boss[i])
                {
                    results[i] = false; // Boss wins this stat
                }
                else
                {
                    results[i] = false; // Tie, boss wins by default
                }
            }
            return results;
        }
        public void ResultsReading(bool[] results)
        {
            int winCounter = 0;
            string[] statNames = { "Strength", "Move Speed", "Defense", "Intellect", "Agility" };
            Console.WriteLine(_character.GetDescription());
            Console.WriteLine("Final Battle Results:");
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i])
                {
                    Console.WriteLine($"You won the battle of {statNames[i]}!");
                    winCounter++;
                }
                else
                {
                    Console.WriteLine($"You lost the battle {statNames[i]}. The final foe was too powerful.");
                }
            }
            if(winCounter >= 3)
            {
                Console.WriteLine("Congratulations! You have defeated the final foe and completed your journey!");
            }
            else
            {
                Console.WriteLine("You were unable to defeat the final foe. Better luck next time!");
            }
        }
        public int RandIndex()
        {
            Random rand = new Random();
            int randIndex = rand.Next(3,14) + 10; // Set in relation to the boost from decorators, giving a small chance that even a bad item will win against foe
            return randIndex;
        }
    }
}