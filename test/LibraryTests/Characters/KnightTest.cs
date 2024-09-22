using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Characters;

[TestFixture]
[TestOf(typeof(Knight))]
public class KnightTest
{

    private Knight caballero;
    private Shield escudo;
    private Bow arco;
    private Staff baston;
    
    [SetUp]
    public void SetUp()
    {
        caballero = new Knight("Caballero");
        escudo = new Shield();
        baston = new Staff();
    }
    
    [Test]
    public void TestNegativeHealth()
    {
        caballero.Health = -50;
        Assert.That(caballero.Health, Is.EqualTo(0));
    }

    [Test]
    public void TestEquipItem()
    {
        caballero.EquipItem(escudo);
        Assert.That(caballero.Items.Count, Is.EqualTo(1));
        Assert.That(caballero.Items.Contains(escudo));
        
        caballero.EquipItem(arco);
        Assert.That(caballero.Items.Count, Is.EqualTo(2));
        Assert.That(caballero.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        caballero.EquipItem(escudo);
        Assert.That(caballero.DefenseValue,Is.EqualTo(14));
        
        caballero.EquipItem(arco);
        Assert.That(caballero.AttackValue,Is.EqualTo(23));
        
        caballero.EquipItem(baston);
        Assert.That(caballero.DefenseValue,Is.EqualTo(114));
        Assert.That(caballero.AttackValue,Is.EqualTo(123));
    }
    
    [Test]
    public void TestUnEquipItem(){
        caballero.EquipItem(escudo);
        caballero.EquipItem(arco);
        
        caballero.UnEquipItem(escudo);
        Assert.That(caballero.Items.Count, Is.EqualTo(1));
        
        caballero.UnEquipItem(arco);
        Assert.That(caballero.Items.Count, Is.EqualTo(1));

        Assert.That(!caballero.Items.Contains(escudo));
        Assert.That(!caballero.Items.Contains(arco));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        caballero.EquipItem(escudo);
        caballero.EquipItem(arco);
        caballero.EquipItem(baston);
        
        caballero.UnEquipItem(escudo);
        Assert.That(caballero.DefenseValue,Is.EqualTo(100));
        
        caballero.UnEquipItem(arco);
        Assert.That(caballero.AttackValue,Is.EqualTo(108));
        
        caballero.UnEquipItem(baston);
        Assert.That(caballero.AttackValue,Is.EqualTo(8));
        Assert.That(caballero.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Wizard mago = new Wizard("Mago");
        caballero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(87));
        
        caballero.EquipItem(arco);
        mago.EquipItem(escudo);
        caballero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(78));
        
        caballero.EquipItem(baston);
        caballero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(0));
    }
    
    [Test]
    public void TestCure()
    {
        caballero.Health = 0;
        caballero.Cure();
        Assert.That(caballero.Health, Is.EqualTo(100));
    }
}