namespace Ucu.Poo.RoleplayGame;

public class Staff: IItem, IDefenseItem, IAttackItem
{
    private string name;
    private int defenseValue;
    private int attackValue;
    private bool magic;
    
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

    public int DefenseValue
    {
        get { return this.defenseValue; }
        private set { this.defenseValue = value; }
    }
    
    public int AttackValue
    {
        get { return this.attackValue; }
        private set { this.attackValue = value; }
    }

    public Staff(string name)
    {
        Name = name;
        DefenseValue = 100;
        AttackValue = 100;
        Magic = false;
    }
}
