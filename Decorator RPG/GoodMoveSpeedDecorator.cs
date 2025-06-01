namespace Decorator_RPG
{
    public class GoodMoveSpeedDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("Zephyr Boots", "The light leads to the open sky. Facing floating platforms and spinning blades; You leap, dash, and dive—faster with each breath."
                + "At the end, you find the Zephyr Boots and your path once more.");
        public GoodMoveSpeedDecorator(ICharacter character) : base(character)
        {
        }
        public override int MoveSpeed() => _character.MoveSpeed() + 5;
    }
}
