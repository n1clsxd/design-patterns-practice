namespace DesignPatternsPractice.Behavioral.Memento.RPGCharacterLoadout
{
    internal class RPGCharacterLoadoutDemo : Demo
    {
        public override void Run()
        {

            Character character = new Character(new LoadoutCaretaker());

            //first loadout 
            character.EquipArmor("dripping armor");
            character.EquipSword("aura sword");
            character.ShowLoadout();
            character.SaveLoadout("hard fit");

            //downgrade
            character.EquipSword("noob sword");
            character.EquipArmor("tasteless armor");
            character.ShowLoadout();

            //restore memento
            character.LoadLoadout("hard fit");
            character.ShowLoadout();

        }
    }
}
