namespace Decorator_RPG
{
    public class GoodIntellectDecorator : CharacterDecorator
    {
        public GoodIntellectDecorator(ICharacter character) : base(character)
        {
        }
        public override int Intellect() => base.Intellect() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
