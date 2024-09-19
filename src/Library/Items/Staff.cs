namespace Ucu.Poo.RoleplayGame;

public class Staff: IItem, IDefenseItem, IAtackItem
{
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
    }
}
