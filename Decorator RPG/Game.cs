using System.Collections.Generic;
using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;

namespace Decorator_RPG
{
    public class Game
    {
        private ICharacter _character;

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
            Console.WriteLine("1) Go right\n2) Go Left\n3) View Player Stats");
            int choice = PrintMenu(2);
            if(choice == 1)
            {
                GoodDefenseDecorator goodDefenseDecorator = new GoodDefenseDecorator(_character);
                _character = goodDefenseDecorator;
            } else
            {
                BadDefenseDecorator badDefenseDecorator = new BadDefenseDecorator(_character);
                _character = badDefenseDecorator;
            }
        }
        public void LevelTwo()
        {
            Console.WriteLine("As you carry on you come to your next choice.");
            Console.WriteLine("To your left is a closed door holding back an intense heat.");
            Console.WriteLine("The way to your right is a long dark tunnel.");
            Console.WriteLine("1) Go right\n2) Go Left");
            int choice = PrintMenu(2);
            if (choice == 1)
            {
                GoodMoveSpeedDecorator goodMoveSpeedDecorator = new GoodMoveSpeedDecorator(_character);
                _character = goodMoveSpeedDecorator;
            }
            else
            {
                BadMoveSpeedDecorator badMoveSpeedDecorator = new BadMoveSpeedDecorator(_character);
                _character = badMoveSpeedDecorator;
            }
        }
        public void LevelThree()
        {
            Console.WriteLine("You arrive at your first choice.");
            Console.WriteLine("The way to your left is a long hallway with a light at the end.");
            Console.WriteLine("To your right is an ornate door.");
            Console.WriteLine("1) Go right\n2) Go Left");
            int choice = PrintMenu(2);
            if (choice == 1)
            {
                GoodStrengthDecorator goodStrengthDecorator = new GoodStrengthDecorator(_character);
                _character = goodStrengthDecorator;
            }
            else
            {
                BadStrengthDecorator badStrengthDecorator = new BadStrengthDecorator(_character);
                _character = badStrengthDecorator;
            }
        }
        public void LevelFour()
        {
            Console.WriteLine("You arrive at your first choice.");
            Console.WriteLine("To your right the wall caved in, revealing an oppressive darkness");
            Console.WriteLine("The way to your right is a strong, but ajar, metal door.");
            Console.WriteLine("1) Go right\n2) Go Left");
            int choice = PrintMenu(2);
            if (choice == 1)
            {
                GoodIntellectDecorator goodIntellectDecorator = new GoodIntellectDecorator(_character);
                _character = goodIntellectDecorator;
            }
            else
            {
                BadStrengthDecorator badIntellectDecorator = new BadStrengthDecorator(_character);
                _character = badIntellectDecorator;
            }
        }
        public void LevelFive()
        {
            Console.WriteLine("You arrive at your first choice.");
            Console.WriteLine("To your left, there is a oaken door with Elvish runes.");
            Console.WriteLine("The path on the left has a tunnel descending");
            Console.WriteLine("1) Go right\n2) Go Left");
            int choice = PrintMenu(2);
            if (choice == 1)
            {
                GoodAgilityDecorator goodAgilityDecorator = new GoodAgilityDecorator(_character);
                _character = goodAgilityDecorator;
            }
            else
            {
                BadAgilityDecorator badAgilityDecorator = new BadAgilityDecorator(_character);
                _character = badAgilityDecorator;
            }
        }
    }
}