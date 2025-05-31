namespace Decorator_RPG
{
    public class GoodStrengthDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("To your left is a closed door holding back an intense heat", "Ember Gauntlets", "You enter a forge-lit arena. Molten steel drips from the ceiling. A burning magma demon looks up at you from its work and attacks immediately" +
                "You wrestle the beast, your hands scorched but unyielding. After slaying the demon, you looks to where it was working and find the Ember Gauntlets.");
        public GoodStrengthDecorator(ICharacter character) : base(character)
        {
        }
        public override int Strength() => _character.Strength() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
    {
    }
}
