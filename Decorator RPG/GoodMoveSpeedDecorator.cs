﻿namespace Decorator_RPG
{
    public class GoodMoveSpeedDecorator : CharacterDecorator
    {
        public GoodMoveSpeedDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Zephyr Boots\n";
            Description = "A gust of wind flings open the next chamber.\nFloating platforms, spinning blades, a puzzle of air.\nYou leap, dash, and dive—faster with each breath.\nAt the end, you find the Zephyr Boots.";
        }
        public override int MoveSpeed() => _character.MoveSpeed() + 15;
    }
}
