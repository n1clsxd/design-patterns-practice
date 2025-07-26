namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class LoadoutCaretaker
    {
        private List<LoadoutMemento> loadoutMementos;
        public LoadoutCaretaker() => loadoutMementos = [];
        public LoadoutMemento GetLoadoutMemento(string title) => loadoutMementos.FirstOrDefault(l => l.Title == title);
        public void AddLoadoutMemento(LoadoutMemento memento) => loadoutMementos.Add(memento);
    }
}
