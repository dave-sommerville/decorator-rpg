namespace Decorator_RPG
{
    public class BadMoveSpeedDecorator : CharacterDecorator
    {
        public BadMoveSpeedDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Velcro Sandals\n";
            Description = "You walk through a dusty hallway.\nA fan whirs slowly in the corner.\nYou trip over a loose sock.\nAt the end lies a pair of Velcro Sandals, squeaky with every step.";
        }
        public override int MoveSpeed() => _character.MoveSpeed() + 5;
    }
}
