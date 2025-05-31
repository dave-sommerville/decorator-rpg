
namespace Decorator_RPG
{
    public class BadDefenseDecorator : CharacterDecorator
    {
        public BadDefenseDecorator(ICharacter character) : base(character) { }
        public override int Defense() => _character.Defense() + 2; // Decrease defense by 10
        public override string GetDescription() => _character.GetDescription() + "tbd";
    }
}
