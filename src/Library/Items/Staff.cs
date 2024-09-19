namespace Ucu.Poo.RoleplayGame;

public class Staff: IItem, IDefensa, IAtaque
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
