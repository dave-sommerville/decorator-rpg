namespace Decorator_RPG
{
    public class BadStrengthDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("The way to your right is a long dark tunnel", "Mittens of Polite Conflict", "You make out a figure deep in the tunnel. As you approach, you recognize it as a training dummy. It falls over before you touch it. You apologize instinctively. On a nearby hook hang the Mittens of Polite Conflict.");
        public BadStrengthDecorator(ICharacter character) : base(character)
        {
        }
        public override int Strength() => _character.Strength() - 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
