namespace Decorator_RPG
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        private readonly Scenario _scene;
        public CharacterDecorator(ICharacter character)
        {
            _character = character;
        }
        public virtual int Defense() => _character.Defense();
        public virtual int MoveSpeed() => _character.MoveSpeed();
        public virtual int Strength() => _character.Strength();
        public virtual int Intellect() => _character.Intellect();
        public virtual int Agility() => _character.Agility();
        public string GetDescription() => _character.GetDescription() + _scene.ResultingEquipmentName + ", ";
        public void SceneDescription()
        {
            if (_scene != null)
            {
                Console.WriteLine(_scene.ScenarioDescription );
            }
            else
            {
                Console.WriteLine("No scenario available.");
            }
        }

    }
}
