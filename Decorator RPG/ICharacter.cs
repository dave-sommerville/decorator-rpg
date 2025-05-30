
namespace Decorator_RPG
{
    public interface ICharacter
    {
        int Defense();
        int moveSpeed();

        int Strength();
        int Intellect();
        int Agility();
        void GetDescription();
    }
}
