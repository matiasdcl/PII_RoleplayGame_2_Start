namespace Ucu.Poo.RoleplayGame;

public class MirrorForce: ISpell, IspellLibro
{
    public string Name { get; }
    
    public MirrorForce()
    {
        Name = "Mirror Force";
    }
    
    public int AttackValue
    {
        get
        {
            return 0;
        }
    }
    
    public int DefenseValue
    {
        get
        {
            return 150;
        }
    }
}