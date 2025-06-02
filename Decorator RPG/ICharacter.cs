
namespace Decorator_RPG
{
    public interface ICharacter
    {
        int Defense();
        int MoveSpeed();

        int Strength();
        int Intellect();
        int Agility();
        string GetDescription();
        void SceneDescription();
        string DescriptionDisplay();
        string NameDisplay();
    }
}
