﻿
namespace Decorator_RPG
{
    public class Character : ICharacter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Defense() => 10;
        public int MoveSpeed() => 10;
        public int Strength() => 10;
        public int Intellect() => 10;
        public int Agility() => 10;
        public string NameDisplay() => Name;
        public string DescriptionDisplay() => Description;
        public string Inventory() => "Inventory:\n";
        public string GetDescription()
        {
            return $"{NameDisplay()}\n{DescriptionDisplay()} with {Defense()} defense, {MoveSpeed()} move speed, {Strength()} strength, {Intellect()} intellect, and {Agility()} agility.";
        }
        public void SceneDescription()
        { 
        }
        public Character(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
