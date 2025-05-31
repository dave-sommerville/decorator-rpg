namespace Decorator_RPG
{
    public class GoodAgilityDecorator : CharacterDecorator
    {
        public GoodAgilityDecorator(ICharacter character) : base(character)
        {
        }
        public override int Agility() => base.Agility() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
