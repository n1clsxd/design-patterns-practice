namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class Loadout(string armor = "", string sword = "")
    {
        public string Armor { get; set; } = armor;
        public string Sword { get; set; } = sword;
    }
}