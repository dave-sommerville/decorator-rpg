
using System.Runtime.CompilerServices;

namespace Decorator_RPG
{
    public class GoodDefenseDecorator : CharacterDecorator
    {
        public readonly Scenario scene = new Scenario("The path to your right is stone hallway", "Bedrock Shield", "The chamber trembles as stone hands rise from the ground. You face the Golem Warden, a monstrous being made of stone"
                + "You endure its crushing blows and strike your weapon into its core. After collapsing into rubble, you see your sought after artifact. You have found the Bedrock Shield");

        public GoodDefenseDecorator(ICharacter character) : base(character)
        {
            
        }

        public override int Defense() => _character.Defense() + 15;
        public override string GetDescription() => _character.GetDescription() + "tbd";
    }
}
