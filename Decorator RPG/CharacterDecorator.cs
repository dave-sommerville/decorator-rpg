namespace Decorator_RPG
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        public CharacterDecorator(ICharacter character)
        {
            _character = character;
        }
        public virtual int Defense() => _character.Defense();
        public virtual int MoveSpeed() => _character.MoveSpeed();
        public virtual int Strength() => _character.Strength();
        public virtual int Intellect() => _character.Intellect();
        public virtual int Agility() => _character.Agility();
        public virtual string GetDescription() => _character.GetDescription();
    }
}
