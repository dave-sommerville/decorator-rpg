namespace Decorator_RPG
{
    public class GoodStrengthDecorator : CharacterDecorator
    {
        public GoodStrengthDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Ember Gauntlets\n";
            Description = "You enter a forge-lit arena. Molten steel drips from the ceiling.\nA burning magma demon looks up at you from its work and attacks immediately.\n" +
                "You wrestle the beast, your hands scorched but unyielding.\nAfter slaying the demon, you looks to where it was working and find the Ember Gauntlets.";
        }
        public override int Strength() => _character.Strength() + 15;
    }
}
