
namespace Decorator_RPG
{
    public class BadDefenseDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("The path to your left is a wide dirt tunnel.", "Slightly Bent Tray", "A rock rolls toward you at alarming mediocrity. You parry it with your bare hands—mostly successfully. Behind it lies a lunch tray, slightly bent but oddly comforting. You equip the Slightly Bent Tray");
        public BadDefenseDecorator(ICharacter character) : base(character) { }
        public override int Defense() => _character.Defense() + 2; // Decrease defense by 10
        public override string GetDescription() => _character.GetDescription() + "tbd";
    }
}
