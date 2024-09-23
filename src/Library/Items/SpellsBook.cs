namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItem, IAttackItem, IDefenseItem
{
    private string name;
    private bool magic;
    private List<Spell> spells;
    public int attackValue;
    private int defenseValue;


    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }

    public bool Magic
    {
        get { return this.magic;}
        set { magic = value; }
    }

    public List<Spell> Spells
    {
        get { return this.spells; }
        set { this.spells = value; }
    }

    public SpellsBook(string name)
    {
        Name = name;
        Magic = true;
        Spells = new List<Spell>();
        AttackValue = 0;
        DefenseValue = 0;

    }
    
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
        set { this.attackValue = value; }
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
        set { this.defenseValue = value;  }
    }
}
