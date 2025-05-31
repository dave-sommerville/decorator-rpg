
namespace Decorator_RPG
{
    public class GoodDefenseDecorator : CharacterDecorator
    {
        public GoodDefenseDecorator(ICharacter character) : base(character)
        {
        }
        public override int Defense() => _character.Defense() + 15;
        public override string GetDescription() => _character.GetDescription() + "tbd";
    }
}
