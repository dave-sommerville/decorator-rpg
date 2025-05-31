
namespace Decorator_RPG
{
    public class Scenario
    {
        public string ChoiceDescription { get; set; }
        public string ResultingEquipmentName { get; set; }
        public string ScenarioDescription { get; set; }
    public Scenario(string opening, string name, string desc)
        {
            ChoiceDescription = opening;
            ResultingEquipmentName = name;
            ScenarioDescription = desc;
        }
    }
}
