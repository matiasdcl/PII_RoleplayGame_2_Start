namespace Ucu.Poo.RoleplayGame;

public class Wizard: ICharacter
{
    private string name;
    private int health;
    private int attackValue;
    private int defenseValue;
    private List<IItem> items;
    private bool usesMagic;

    public Wizard(string name)
    {
        Name = name;
        usesMagic = true;
        attackValue = 8;
        defenseValue = 0;
        health = 95;
        items = new List<IItem>(); //Wizard se inicializa con un baston y un libro de hechizos.
        IItem staff = new Staff();
        IItem spellbook = new SpellsBook();
        this.EquipItem(staff);
        this.EquipItem(spellbook);

    }

    public string Name
    {
        get { return this.name;}
        set { name = value; }
    }

    public bool UsesMagic
    {
        get { return this.usesMagic; }
        set { usesMagic = value; }
    }
    
    public int AttackValue
    {
        get
        {
            return this.attackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return this.defenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public int GetHealth()
    {
        return this.Health;
    }

    public List<IItem> Items
    {
        get { return this.items; }
        set { this.items = value; }
    }

    public void EquipItem(IItem item)
    {
        this.items.Add(item);
        if (item is IAttackItem)
        {
            this.attackValue += item.AttackValue();
        }
        if (item is IDefenseItem)
        {
            this.defenseValue += item.DefenseValue();
        }
    }
    
    public void UnEquipItem(IItem item)
    {
        if (this.items.Contains(item))
        {
            this.items.Remove(item);
            if (item is IAttackItem)
            {
                this.attackValue -= item.AttackValue();
            }
            if (item is IDefenseItem)
            {
                this.defenseValue -= item.DefenseValue();
            }
        }
        else
        {
            Console.WriteLine($"{this.name} no tiene ese item.");
        }
                
    }
    
    public void Attack(ICharacter target)
    {
        target.Health -= this.AttackValue - target.DefenseValue;
    }

    public void Cure()
    {
        health = 100;
    }
    
}
