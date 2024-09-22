using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Characters;

[TestFixture]
[TestOf(typeof(Archer))]
public class ArcherTest
{
    private Archer arquero;
    private Shield escudo;
    private Bow arco;
    private Staff baston;
    
    [SetUp]
    public void SetUp()
    {
        arquero = new Archer("Arquero");
        escudo = new Shield();
        arco = new Bow();
        baston = new Staff();
    }
    
    [Test]
    public void TestNegativeHealth()
    {
        arquero.Health = -50;
        Assert.That(arquero.Health, Is.EqualTo(0));
    }

    [Test]
    public void TestEquipItem()
    {
        arquero.EquipItem(escudo);
        Assert.That(arquero.Items.Count, Is.EqualTo(1));
        Assert.That(arquero.Items.Contains(escudo));
        
        arquero.EquipItem(arco);
        Assert.That(arquero.Items.Count, Is.EqualTo(2));
        Assert.That(arquero.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        arquero.EquipItem(escudo);
        Assert.That(arquero.DefenseValue,Is.EqualTo(14));
        
        arquero.EquipItem(arco);
        Assert.That(arquero.AttackValue,Is.EqualTo(25));
        
        arquero.EquipItem(baston);
        Assert.That(arquero.DefenseValue,Is.EqualTo(114));
        Assert.That(arquero.AttackValue,Is.EqualTo(125));
    }
    
    [Test]
    public void TestUnEquipItem(){
        arquero.EquipItem(escudo);
        arquero.EquipItem(arco);
        
        arquero.UnEquipItem(escudo);
        Assert.That(arquero.Items.Count, Is.EqualTo(1));
        
        arquero.UnEquipItem(arco);
        Assert.That(arquero.Items.Count, Is.EqualTo(1));

        Assert.That(!arquero.Items.Contains(escudo));
        Assert.That(!arquero.Items.Contains(arco));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        arquero.EquipItem(escudo);
        arquero.EquipItem(arco);
        arquero.EquipItem(baston);
        
        arquero.UnEquipItem(escudo);
        Assert.That(arquero.DefenseValue,Is.EqualTo(100));
        
        arquero.UnEquipItem(arco);
        Assert.That(arquero.AttackValue,Is.EqualTo(110));
        
        arquero.UnEquipItem(baston);
        Assert.That(arquero.AttackValue,Is.EqualTo(10));
        Assert.That(arquero.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Wizard mago = new Wizard("Mago");
        arquero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(85));
        
        arquero.EquipItem(arco);
        mago.EquipItem(escudo);
        arquero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(74));
        
        arquero.EquipItem(baston);
        arquero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(0));
    }
    
    [Test]
    public void TestCure()
    {
        arquero.Health = 0;
        arquero.Cure();
        Assert.That(arquero.Health, Is.EqualTo(100));
    }
}