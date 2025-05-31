namespace Decorator_RPG
{
    public class GoodAgilityDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("To your right the wall caved in, revealing an oppressive darkness", "Umbral Cloak", "A dark figure mirrors your every move. You must defeat yourself—your speed, your style, your fear. You feint, twist, and blink past the shadows. You claim the final relic: the Umbral Cloak.");
        public GoodAgilityDecorator(ICharacter character) : base(character)
        {
        }
        public override int Agility() => base.Agility() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
