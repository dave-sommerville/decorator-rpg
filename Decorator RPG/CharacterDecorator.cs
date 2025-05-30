namespace Decorator_RPG
{
    abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        public CharacterDecorator(Character character)
        {
            _character = character;
        }
        public virtual string DescribeCharacter() => _character.GetDescription();
    }
}
