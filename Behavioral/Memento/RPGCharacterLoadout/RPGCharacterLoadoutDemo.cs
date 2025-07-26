namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class RPGCharacterLoadoutDemo : Demo
    {
        public override void Run()
        {
            Character character = new();
            LoadoutCaretaker caretaker = new();

            //first loadout 
            character.EquipArmor("dripping armor");
            character.EquipSword("aura sword");
            character.ShowLoadout();
            caretaker.AddLoadoutMemento(character.SaveLoadout("hard fit"));

            //downgrade
            character.EquipSword("noob sword");
            character.EquipArmor("tasteless armor");
            character.ShowLoadout();

            //restore memento
            character.LoadLoadout(caretaker.GetLoadoutMemento("hard fit"));
            character.ShowLoadout();
        }
    }
}
