namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    int AttackValue { get; }
    int DefenseValue { get; }
    List<IItem> Items { get; }
    bool UsesMagic { get; }
    void EquipItem(IItem item);
    void UnEquipItem(IItem item);
    void Attack(ICharacter target);
    void Cure();
}