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
        IItem bow = new Bow("Arco predeterminado");
        IItem helmet = new Helmet("Casco predeterminado");
        this.EquipItem(bow);
        this.EquipItem(helmet);
        
    }

    public string Name
    {
        get { return this.name;}
        private set { name = value; }
    }

    public bool UsesMagic
    {
        get { return this.usesMagic; }
        private set { usesMagic = value; }
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
        private set
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
        private set { this.items = value; }
    }

    public void EquipItem(IItem item)
    {
        if (item.Magic())
        {
            if (!this.usesMagic)
            {
                Console.WriteLine($"{this.name} no puede usar items mágicos");
            }
            else
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
        }
        else
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
    }
    
    public void UnEquipItem(string ItemName)
    {
        foreach (IItem thisItem in this.items.ToList())
        {
            if (thisItem.Name == ItemName )
            {
                this.items.Remove(thisItem);
                if (thisItem is IAttackItem)
                {
                    this.attackValue -= thisItem.AttackValue();
                }
                if (thisItem is IDefenseItem)
                {
                    this.defenseValue -= thisItem.DefenseValue();
                }
            }
            else
            {
                Console.WriteLine($"{this.name} no tiene ese item.");
            }    
            
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
