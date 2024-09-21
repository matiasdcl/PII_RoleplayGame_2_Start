namespace Ucu.Poo.RoleplayGame;

public class Archer: ICharacter
{
    private string name;
    private int health;
    private int attackValue;
    private int defenseValue;
    private List<IItem> items;
    private bool usesMagic;

    public Archer(string name)
    {
        Name = name;
        usesMagic = false;
        attackValue = 10;
        defenseValue = 0;
        health = 100;
        items = new List<IItem>(); //Archer se inicializa con un arco y un casco
        IItem bow = new Bow();
        IItem helmet = new Helmet();
        this.EquipItem(bow);
        this.EquipItem(helmet);
        
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
            this.attackValue += item.GetAttackValue();
        }
        if (item is IDefenseItem)
        {
            this.defenseValue += item.GetDefenseValue();
        }
    }
    
    public void UnEquipItem(IItem item)
    {
        if (this.items.Contains(item))
        {
            this.items.Remove(item);
            if (item is IAttackItem)
            {
                this.attackValue -= item.GetAttackValue();
            }
            if (item is IDefenseItem)
            {
                this.defenseValue -= item.GetDefenseValue();
            }
        }
        else
        {
            Console.WriteLine($"{this.name} no tiene ese item.");
        }
                
    }
    
    public void Attack(ICharacter target)
    {
        target.Health -= this.AttackValue;
    }

    public void Cure()
    {
        health = 100;
    }
}
