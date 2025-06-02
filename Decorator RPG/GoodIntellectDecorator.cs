namespace Decorator_RPG
{
    public class GoodIntellectDecorator : CharacterDecorator
    {
        public GoodIntellectDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Silverwoven Robe\n";
            Description = "You enter a scenario where you must face your own limitations. You must overcome challenges to gain new abilities and equipment.\n" +
                          "You find yourself in a hall of mirrors, each reflecting a different version of yourself. You must solve the riddles of the mirrors to gain the Silverwoven Robe.";
        }
        public override int Intellect() => base.Intellect() + 5;
    }
}
