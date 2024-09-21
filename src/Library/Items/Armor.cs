namespace Ucu.Poo.RoleplayGame;

public class Armor: IItem, IDefenseItem
{
    public string Name{get; set;}
    public bool Magic{get ; set;}
    public int DefenseValue
    {
        get
        {
            return 25;
        }
        set{}
    }
}
