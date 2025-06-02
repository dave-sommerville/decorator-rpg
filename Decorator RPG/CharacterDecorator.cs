namespace Decorator_RPG
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        public string EquipmentName = "";
        public string Description = "You enter a scenario where you must face your own limitations. You must overcome challenges to gain new abilities and equipment.";


        public CharacterDecorator(ICharacter character)
        {
            _character = character;
        }
        public virtual int Defense() => _character.Defense();
        public virtual int MoveSpeed() => _character.MoveSpeed();
        public virtual int Strength() => _character.Strength();
        public virtual int Intellect() => _character.Intellect();
        public virtual int Agility() => _character.Agility();
        public int Level() => _character.Level() + 1;
        public string GetDescription()
        {
            string desc =
            $"Level: {Level()}" +
            $"\nStrength: {Strength()}" +
            $"\nMove Speed: {MoveSpeed()}" +
            $"\nDefense: {Defense()}" +
            $"\nIntellect: {Intellect()}" +
            $"\nAgility: {Agility()}";
            return desc;
            
        }
        public void SceneDescription()
        {
            if (Description != null)
            {
                Console.WriteLine(Description);
            }
            else
            {
                Console.WriteLine("No scenario available.");
            }
        }
    }
}
