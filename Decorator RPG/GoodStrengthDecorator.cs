namespace Decorator_RPG
{
    public class GoodStrengthDecorator : CharacterDecorator
    {
        public GoodStrengthDecorator(ICharacter character) : base(character)
        {
        }
        public override int Strength() => _character.Strength() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
    {
    }
}
