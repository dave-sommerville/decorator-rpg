namespace Decorator_RPG
{
    public class BadIntellectDecorator : CharacterDecorator
    {
        public BadIntellectDecorator(ICharacter character) : base(character)
        {
        }
        public override int Intellect() => base.Intellect() - 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
