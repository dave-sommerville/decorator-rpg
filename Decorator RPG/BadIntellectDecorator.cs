namespace Decorator_RPG
{
    public class BadIntellectDecorator : CharacterDecorator
    {        
        public BadIntellectDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Mystically Damp Towel\n";
            Description = "A riddle appears.\nIt asks: “What has four legs at dawn and...?” and then forgets.\nYou solve it somehow. Or maybe not?\nYour prize: a Mystically Damp Towel.\nIt smells... ancient.";
        }
        public override int Intellect() => base.Intellect() + 5;
    }
}
