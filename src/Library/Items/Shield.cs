namespace Ucu.Poo.RoleplayGame;

public class Shield: IItem, IDefenseItem
{
    private string name;
    private int defenseValue;
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
        set { this.defenseValue = value; }
    }

    public Shield(string name)
    {
        Name = name;
        DefenseValue = 14;
        Magic = false;
    }
}
