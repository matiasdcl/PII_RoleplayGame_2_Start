namespace Ucu.Poo.RoleplayGame;

public class Buff: ISpell,IspellLibro
{
    
    public string Name { get; }
    
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
    
    public Buff()
    {
        Name = "Hechizo Buffeador";
    }
}
