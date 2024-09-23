namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; }
    int Health { get; }
    int AttackValue { get; }
    int DefenseValue { get; }
    List<IItem> Items { get; }
    bool UsesMagic { get; }
    void EquipItem(IItem item);
    void UnEquipItem(string itemName);
    void Attack(ICharacter target);
    void TakeDamage(int attack);
    void Cure();
}