namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class LoadoutMemento(string armor, string sword, string title)
    {
        public string Armor { get; } = armor;
        public string Sword { get; } = sword;
        public string Title { get; } = title;
    }
}