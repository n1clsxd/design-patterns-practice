namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class LoadoutCaretaker
    {
        private List<LoadoutMemento> loadoutMementos;

        public LoadoutCaretaker()
        {
            loadoutMementos = new List<LoadoutMemento>();
        }
        public Loadout GetLoadoutMemento(string title)
        {
            LoadoutMemento memento = loadoutMementos.FirstOrDefault(l => l.title == title);

            return new Loadout()
            {
                Armor = memento.Armor,
                Sword = memento.Sword
            };
        }

        public void AddLoadoutMemento(Loadout loadout, string title)
        {
            LoadoutMemento memento = new LoadoutMemento()
            {
                Armor = loadout.Armor,
                Sword = loadout.Sword,
                title = title
            };
            loadoutMementos.Add(memento);

        }
    }
}
