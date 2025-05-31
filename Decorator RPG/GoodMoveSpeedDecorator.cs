namespace Decorator_RPG
{
    public class GoodMoveSpeedDecorator : CharacterDecorator
    {
        public GoodMoveSpeedDecorator(ICharacter character) : base(character)
        {
        }
        public override int MoveSpeed() => _character.MoveSpeed() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
