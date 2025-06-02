namespace Decorator_RPG
{
    public class BadAgilityDecorator : CharacterDecorator
    {
        public BadAgilityDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Cloak of Static Cling\n";
            Description = "You must sneak past a snoring beast. You succeed… until your cloak sticks to your own leg and creates a loud *zzzzt!* However, you now wear the Cloak of Static Cling and the beast leaves anyway.";
        }
        public override int Agility() => base.Agility() + 5;

    }
}
