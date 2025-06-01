namespace Decorator_RPG
{
    public class BadIntellectDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("Mystically Damp Towel", "A riddle appears. It asks: “What has four legs at dawn and...?” and then forgets. You solve it... maybe? Your prize: a Mystically Damp Towel. It smells... ancient.");
        public BadIntellectDecorator(ICharacter character) : base(character)
        {
        }
        public override int Intellect() => base.Intellect() - 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
