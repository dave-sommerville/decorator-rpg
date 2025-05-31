namespace Decorator_RPG
{
    public class GoodIntellectDecorator : CharacterDecorator
    {
        private readonly Scenario scene = new Scenario("To your right is a fancy door, heavily ordained", "Silverwoven Robe", "Silence. A hall of mirrors and illusions. You decode symbols, fight your inner demons, and uncover truths. A spirit hands you the Silverwoven Robe.");
        public GoodIntellectDecorator(ICharacter character) : base(character)
        {
        }
        public override int Intellect() => base.Intellect() + 5;
        public override string GetDescription() => _character.GetDescription() + "";
    }
}
