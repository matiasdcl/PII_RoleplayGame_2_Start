namespace Ucu.Poo.RoleplayGame;

public class Buff: ISpell,IAttackSpell, IDefenseSpell
{
    
    public string Name { get; private set; }
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
