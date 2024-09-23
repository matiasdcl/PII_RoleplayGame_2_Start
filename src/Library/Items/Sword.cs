namespace Ucu.Poo.RoleplayGame;

public class Sword: IItem, IAttackItem
{
    private string name;
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

    public int AttackValue
    {
        get { return this.attackValue; }
        set { this.attackValue = value; }
    }

    public Sword(string name)
    {
        Name = name;
        AttackValue = 20;
        Magic = false;
    }
}
