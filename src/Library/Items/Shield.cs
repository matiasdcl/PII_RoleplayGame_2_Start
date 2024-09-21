namespace Ucu.Poo.RoleplayGame;

public class Shield: IItem, IDefenseItem
{
    public string Name{get; set;}
    public bool Magic{get ; set;}
    public int DefenseValue
    {
        get
        {
            return 14;
        }
        set{}
    }
}
