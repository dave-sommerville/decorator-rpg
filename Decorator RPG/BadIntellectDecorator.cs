namespace Decorator_RPG
{
    public class BadIntellectDecorator : CharacterDecorator
    {        
        public BadIntellectDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Mystically Damp Towel\n";
            Description = "A riddle appears. It asks: “What has four legs at dawn and...?” and then forgets. You solve it somehow. Or maybe not? Your prize: a **Mystically Damp Towel**. It smells... ancient.";
        }
        public override int Intellect() => base.Intellect() + 5;
    }
}
