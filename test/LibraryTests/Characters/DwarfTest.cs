using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Characters;

[TestFixture]
[TestOf(typeof(Dwarf))]
public class DwarfTest
{
    private Dwarf enano;
    private Shield escudo;
    private Bow arco;
    private Staff baston;
    
    [SetUp]
    public void SetUp()
    {
        enano = new Dwarf("Enano");
        escudo = new Shield();
        arco = new Bow();
        baston = new Staff();
    }
    
    [Test]
    public void TestNegativeHealth()
    {
        enano.Health = -50;
        Assert.That(enano.Health, Is.EqualTo(0));
    }
    
    [Test]
    public void TestEquipItem()
    {
        enano.EquipItem(escudo);
        Assert.That(enano.Items.Count, Is.EqualTo(1));
        Assert.That(enano.Items.Contains(escudo));
        
        enano.EquipItem(arco);
        Assert.That(enano.Items.Count, Is.EqualTo(2));
        Assert.That(enano.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        enano.EquipItem(escudo);
        Assert.That(enano.DefenseValue,Is.EqualTo(14));
        
        enano.EquipItem(arco);
        Assert.That(enano.AttackValue,Is.EqualTo(27));
        
        enano.EquipItem(baston);
        Assert.That(enano.DefenseValue,Is.EqualTo(114));
        Assert.That(enano.AttackValue,Is.EqualTo(127));
    }
    
    [Test]
    public void TestUnEquipItem(){
        enano.EquipItem(escudo);
        enano.EquipItem(arco);
        
        enano.UnEquipItem(escudo);
        Assert.That(enano.Items.Count, Is.EqualTo(1));
        
        enano.UnEquipItem(arco);
        Assert.That(enano.Items.Count, Is.EqualTo(1));

        Assert.That(!enano.Items.Contains(escudo));
        Assert.That(!enano.Items.Contains(arco));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        enano.EquipItem(escudo);
        enano.EquipItem(arco);
        enano.EquipItem(baston);
        
        enano.UnEquipItem(escudo);
        Assert.That(enano.DefenseValue,Is.EqualTo(100));
        
        enano.UnEquipItem(arco);
        Assert.That(enano.AttackValue,Is.EqualTo(112));
        
        enano.UnEquipItem(baston);
        Assert.That(enano.AttackValue,Is.EqualTo(12));
        Assert.That(enano.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Wizard mago = new Wizard("Mago");
        enano.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(83));
        
        enano.EquipItem(arco);
        mago.EquipItem(escudo);
        enano.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(70));
        
        enano.EquipItem(baston);
        enano.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(0));
    }
    
    [Test]
    public void TestCure()
    {
        enano.Health = 0;
        enano.Cure();
        Assert.That(enano.Health, Is.EqualTo(100));
    }
}