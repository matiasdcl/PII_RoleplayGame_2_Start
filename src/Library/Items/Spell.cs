namespace Ucu.Poo.RoleplayGame;

public class Spell: IItem, IAtaque, IDefensa
{
    public int AttackValue
    {
        get
        {
            return 70;
        }
    }

    public int DefenseValue
    {
        get
        {
            return 70;
        }
    }
}
