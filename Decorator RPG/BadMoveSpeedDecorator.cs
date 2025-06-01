namespace Decorator_RPG
{
    public class BadMoveSpeedDecorator : CharacterDecorator
    {
        public BadMoveSpeedDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Velcro Sandals";
            Description = "You walk through a dusty hallway. A fan whirs slowly in the corner. You trip over a loose sock. At the end lies a pair of **Velcro Sandals**, squeaky with every step.";
        }
        public override int MoveSpeed() => _character.MoveSpeed() + 5;
    }
}
