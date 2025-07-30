namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class LoadoutCaretaker
    {
        private List<LoadoutMemento> LoadoutMementos { get; set; }
        public LoadoutCaretaker() => LoadoutMementos = [];
        public LoadoutMemento GetLoadoutMemento(string title) => LoadoutMementos.FirstOrDefault(l => l.Title == title);
        public void AddLoadoutMemento(LoadoutMemento memento) => LoadoutMementos.Add(memento);
    }
}
