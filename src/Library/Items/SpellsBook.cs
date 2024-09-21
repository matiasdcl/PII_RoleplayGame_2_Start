namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItem, IAttackItem, IDefenseItem
{
    public string Name{get; set;}
    public bool Magic{get ; set;}
    public Spell[] Spells { get; set; }
    
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
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
            foreach (Spell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
        set{}
    }
}
