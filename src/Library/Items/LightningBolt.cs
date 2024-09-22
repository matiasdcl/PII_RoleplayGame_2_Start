namespace Ucu.Poo.RoleplayGame;

public class LightningBolt: ISpell,IAttackSpell
{
    public string Name { get; }
    
    public int AttackValue
    {
        get
        {
            return 100;
        }
    }
    
}