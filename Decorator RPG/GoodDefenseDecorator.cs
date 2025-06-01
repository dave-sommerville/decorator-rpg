
using System.Runtime.CompilerServices;

namespace Decorator_RPG
{
    public class GoodDefenseDecorator : CharacterDecorator
    {
        public GoodDefenseDecorator(ICharacter character) : base(character)
        {
            _character = character;
            EquipmentName = "Bedrock Shield, ";
            Description = "The chamber trembles as stone hands rise from the ground. You face the Golem Warden, protector of the first Aspect. You endure its crushing blows and strike its core. From its remains, you pull the Granite Shield.";
        }
        public override int Defense() => _character.Defense() + 15;
    }
}
