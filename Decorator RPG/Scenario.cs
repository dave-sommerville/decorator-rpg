
namespace Decorator_RPG
{
    public class Scenario
    {
        public string ResultingEquipmentName { get; set; }
        public string ScenarioDescription { get; set; }
    public Scenario(string name, string desc)
        {
            ResultingEquipmentName = name;
            ScenarioDescription = desc;
        }
    }
}
