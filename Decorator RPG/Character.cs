
namespace Decorator_RPG
{
    public class Character : ICharacter
    {
        public string Name { get; set; }
        public int Defense() => 10;
        public int MoveSpeed() => 10;
        public int Strength() => 10;
        public int Intellect() => 10;
        public int Agility() => 10;
        public void GetDescription()
        {

        }
    }
}
