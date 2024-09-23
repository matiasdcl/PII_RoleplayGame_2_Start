namespace Ucu.Poo.RoleplayGame;

public class Armor: IItem, IDefenseItem
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
        private set { this.defenseValue = value; }
    }

    public Armor(string name)
    {
        Name = name;
        DefenseValue = 25;
        Magic = false;
    }
}
