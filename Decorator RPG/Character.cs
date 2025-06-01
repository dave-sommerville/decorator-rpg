
namespace Decorator_RPG
{
    public class Character : ICharacter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Scenario? Scenario { get; set; }
        public int Defense() => 10;
        public int MoveSpeed() => 10;
        public int Strength() => 10;
        public int Intellect() => 10;
        public int Agility() => 10;
        public string GetDescription()
        {
            return $"{Name} has {Defense()} defense, {MoveSpeed()} move speed, {Strength()} strength, {Intellect()} intellect, and {Agility()} agility.\nInventory:\n";
        }
        public void SceneDescription()
        {
            if (Scenario != null)
            {
                Console.WriteLine(Scenario.ScenarioDescription);
            }
            else
            {
                Console.WriteLine("No scenario available.");
            }
        }
        public Character(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
