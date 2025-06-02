namespace Decorator_RPG
{
    public class BadStrengthDecorator : CharacterDecorator
    {
        public BadStrengthDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Mittens of Polite Conflict\n";
            Description = "You make out a figure deep in the tunnel.\nAs you approach, you recognize it as a training dummy.\nIt falls over before you touch it.\nYou apologize instinctively.\nOn a nearby hook hang the Mittens of Polite Conflict.";
        }
        public override int Strength() => _character.Strength() + 5;
    }
}
