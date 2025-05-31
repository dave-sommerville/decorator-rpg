namespace Decorator_RPG
{
    public class BadAgilityDecorator : CharacterDecorator
    {
        public BadAgilityDecorator(ICharacter character) : base(character)
        {
        }
        public override int Agility() => base.Agility() - 5;
        public override string GetDescription() => _character.GetDescription() + "";

    }
}
