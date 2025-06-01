namespace Decorator_RPG
{
    public class BadStrengthDecorator : CharacterDecorator
    {
        public BadStrengthDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Mittens of Polite Conflict";
            Description = "You make out a figure deep in the tunnel. As you approach, you recognize it as a training dummy. It falls over before you touch it. You apologize instinctively. On a nearby hook hang the Mittens of Polite Conflict.";
        }
        public override int Strength() => _character.Strength() + 5;
    }
}
