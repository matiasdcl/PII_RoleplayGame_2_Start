namespace Ucu.Poo.RoleplayGame;

public class MirrorForce: ISpell, IDefenseSpell
{
    public string Name { get; }
    
    public int DefenseValue
    {
        get
        {
            return 150;
        }
    }
}