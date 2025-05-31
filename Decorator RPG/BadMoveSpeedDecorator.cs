namespace Decorator_RPG
{
    public class BadMoveSpeedDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("The way to your right is a strong, but ajar, metal door.", "Velcro Sandals", "You walk through a dusty hallway. There's a buzz from something in the corner. You trip over your loose sock? Luckily in the dust in front you, you find the Velcro Sandals");
        public BadMoveSpeedDecorator(ICharacter character) : base(character)
        {
        }
        public override int MoveSpeed() => _character.MoveSpeed() - 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
