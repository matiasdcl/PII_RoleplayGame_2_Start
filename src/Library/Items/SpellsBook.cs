namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItem, IAttackItem, IDefenseItem
{
    public IspellLibro[] Spells{ get;  set; }

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IspellLibro spell in this.Spells)
            { 
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IspellLibro spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
}
