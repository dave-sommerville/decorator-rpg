
namespace Decorator_RPG
{
    public class BadDefenseDecorator : CharacterDecorator
    {
        public BadDefenseDecorator(ICharacter character) : base(character) 
        {
            _character = character;
            EquipmentName = "Slightly Bent Tray\n";
            Description = "A rock rolls toward you at alarming mediocrity.\nYou parry it with your bare hands—mostly successfully.\nBehind it lies a lunch tray, slightly bent but oddly comforting.";
        }
        public override int Defense() => _character.Defense() + 5;
    }
}
