namespace Ucu.Poo.RoleplayGame;

public class LightningBolt: ISpell, IspellLibro
{
    public string Name { get; }
    
    public LightningBolt()
    {
        Name = "Lightning Bolt";
    }
    
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
            return 0;
        }
    }
    
    
    
}