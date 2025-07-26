namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class Character
    {
        private Loadout loadout;
        public Character() => loadout = new();
        public LoadoutMemento SaveLoadout(string title)
        {
            Console.WriteLine($"Saving Loadout: \"{title}\"\n");
            return new(
                loadout.Armor,
                loadout.Sword,
                title);
        }
        public void LoadLoadout(LoadoutMemento memento)
        {
            if (memento == null)
            {
                Console.WriteLine("Failed to restore loadout!");
                Environment.Exit(1);
            }
            Console.WriteLine($"Loaded Loadout: \"{memento.Title}\"\n");
            loadout = new Loadout(memento.Armor, memento.Sword);
            
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
