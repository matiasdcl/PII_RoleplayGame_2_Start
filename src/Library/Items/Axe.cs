namespace Ucu.Poo.RoleplayGame;

public class Axe: IItem, IAttackItem   
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
        private set { this.attackValue = value; }
    }

    public Axe(string name)
    {
        Name = name;
        AttackValue = 25;
        Magic = false;
    }
}
