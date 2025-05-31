namespace Decorator_RPG
{
    public class BadStrengthDecorator : CharacterDecorator
    {
        public BadStrengthDecorator(ICharacter character) : base(character)
        {
        }
        public override int Strength() => _character.Strength() - 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
