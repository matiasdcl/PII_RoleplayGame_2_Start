namespace Ucu.Poo.RoleplayGame;

public class SpellsBook: IItem, IAttackItem, IDefenseItem
{

    private string name;
    private bool magic;
    private int attackValue;
    private int defenseValue;
    public List<IspellLibro> spells { get; }
    public string Name
    {
        get { return this.name; }
        private set { name = value; }
    }

    
    public bool Magic
    {
        get { return this.magic; }
        private set { magic = value; }
    }
    
    public SpellsBook(string name)
    {
        Name = name;
        magic = true;
        spells = new List<IspellLibro>();
        AttackValue = 0;
        DefenseValue = 0;
    }

    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IspellLibro spell in this.spells)
            { 
                value += spell.AttackValue;
            }
            return value;
        }
        private set
        { 
            this.attackValue = value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IspellLibro spell in this.spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
        set
        {
            this.defenseValue = value;
        }
    }

    public void AddSpell(IspellLibro spell)
    {
        spells.Add(spell);
    }
}
