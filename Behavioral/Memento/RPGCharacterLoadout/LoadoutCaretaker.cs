namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class LoadoutCaretaker
    {
        private List<LoadoutMemento> loadoutMementos;
        public LoadoutCaretaker()
        {
            loadoutMementos = [];
        }
        public Loadout GetLoadoutMemento(string title)
        {
            LoadoutMemento memento = loadoutMementos.FirstOrDefault(l => l.Title == title);
            if (memento == null) return null;
            return new Loadout(memento.Armor, memento.Sword);
        }

        public void AddLoadoutMemento(Loadout loadout, string title)
        {
            LoadoutMemento memento = new(
                loadout.Armor,
                loadout.Sword,
                title);
            loadoutMementos.Add(memento);
        }
    }
}
