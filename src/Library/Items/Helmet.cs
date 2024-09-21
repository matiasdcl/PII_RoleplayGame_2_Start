namespace Ucu.Poo.RoleplayGame;

public class Helmet: IItem, IDefenseItem
{
    public string Name{get; set;}
    public bool Magic{get ; set;}
    public int DefenseValue
    {
        get
        {
            return 18;
        }
        set{}
    }
}
