namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItem, IAttackItem, IDefenseItem
{
    public ISpell[] Spells{ get;  set; }

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IAttackSpell spell in this.Spells)
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
            foreach (IDefenseSpell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
}
