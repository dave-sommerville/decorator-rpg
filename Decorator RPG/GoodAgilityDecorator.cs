namespace Decorator_RPG
{
    public class GoodAgilityDecorator : CharacterDecorator
    {
        public GoodAgilityDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Umbral Cloak\n";
            Description = "A dark figure mirrors your every move.\nYou must defeat yourself—your speed, your style, your fear.\nYou feint, twist, and blink past the shadows.\nYou claim the final relic: the Umbral Cloak.";
        }
        public override int Agility() => base.Agility() + 15;
    }
}
