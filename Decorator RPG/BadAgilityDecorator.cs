namespace Decorator_RPG
{
    public class BadAgilityDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("Cloak of Static Cling", "You must sneak past a snoring beast. You succeed… until your cloak sticks to your own leg and creates a loud *zzzzt!* However, you now wear the Cloak of Static Cling and the beast leaves anyway.");
        public BadAgilityDecorator(ICharacter character) : base(character)
        {
        }
        public override int Agility() => base.Agility() - 5;

    }
}
