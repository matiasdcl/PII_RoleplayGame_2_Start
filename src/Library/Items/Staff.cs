namespace Ucu.Poo.RoleplayGame;

public class Staff: IItem, IDefenseItem, IAttackItem
{
    public string Name{get; set;}
    public bool Magic{get ; set;}
    public int AttackValue 
    {
        get
        {
            return 100;
        } 
    }

    public int DefenseValue
    {
        get
        {
            return 100;
        }
        set{}
    }
}
