namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class Character
    {
        private Loadout loadout;
        private LoadoutCaretaker loadoutCaretaker;
        public Character(LoadoutCaretaker caretaker)
        {
            loadoutCaretaker = caretaker;
            loadout = new();
        }

        public void SaveLoadout(string title)
        {
            Console.WriteLine($"Saving Loadout: \"{title}\"\n");
            loadoutCaretaker.AddLoadoutMemento(loadout, title);
        }

        public void LoadLoadout(string loadoutMementoTitle)
        {
            Console.WriteLine($"Loading Loadout: \"{loadoutMementoTitle}\"\n");

            loadout = loadoutCaretaker.GetLoadoutMemento(loadoutMementoTitle);
            if (loadout == null)
            {
                Console.WriteLine("Failed to restore loadout!");
                Environment.Exit(1);
            }
        }
        public void EquipArmor(string armor)
        {
            Console.WriteLine($"Equipping armor: \"{armor}\"\n");
            loadout.Armor = armor;
        }
        public void EquipSword(string sword)
        {
            Console.WriteLine($"Equipping sword: \"{sword}\"\n");

            loadout.Sword = sword;
        }
        public void ShowLoadout()
        {
            Console.WriteLine($"Showing Loadout:\n\n    Armor: \"{loadout.Armor}\"\n    Sword: \"{loadout.Sword}\"\n");
        }
    }
}
