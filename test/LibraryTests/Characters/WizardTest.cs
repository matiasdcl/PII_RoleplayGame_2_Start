using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Characters;

[TestFixture]
[TestOf(typeof(Wizard))]
public class WizardTest
{
    private Wizard mago;
    private Shield escudo;
    private Bow arco;
    private Staff baston;
    
    [SetUp]
    public void SetUp()
    {
        mago = new Wizard("Mago");
        escudo = new Shield();
        arco = new Bow();
        baston = new Staff();
    }
    
    [Test]
    public void TestNegativeHealth()
    {
        mago.Health = -50;
        Assert.That(mago.Health, Is.EqualTo(0));
    }

    [Test]
    public void TestEquipItem()
    {
        mago.EquipItem(escudo);
        Assert.That(mago.Items.Count, Is.EqualTo(1));
        Assert.That(mago.Items.Contains(escudo));
        
        mago.EquipItem(arco);
        Assert.That(mago.Items.Count, Is.EqualTo(2));
        Assert.That(mago.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        mago.EquipItem(escudo);
        Assert.That(mago.DefenseValue,Is.EqualTo(14));
        
        mago.EquipItem(arco);
        Assert.That(mago.AttackValue,Is.EqualTo(23));
        
        mago.EquipItem(baston);
        Assert.That(mago.DefenseValue,Is.EqualTo(114));
        Assert.That(mago.AttackValue,Is.EqualTo(123));
    }
    
    [Test]
    public void TestUnEquipItem(){
        mago.EquipItem(escudo);
        mago.EquipItem(arco);
        
        mago.UnEquipItem(escudo);
        Assert.That(mago.Items.Count, Is.EqualTo(1));
        
        mago.UnEquipItem(arco);
        Assert.That(mago.Items.Count, Is.EqualTo(1));

        Assert.That(!mago.Items.Contains(escudo));
        Assert.That(!mago.Items.Contains(arco));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        mago.EquipItem(escudo);
        mago.EquipItem(arco);
        mago.EquipItem(baston);
        
        mago.UnEquipItem(escudo);
        Assert.That(mago.DefenseValue,Is.EqualTo(100));
        
        mago.UnEquipItem(arco);
        Assert.That(mago.AttackValue,Is.EqualTo(108));
        
        mago.UnEquipItem(baston);
        Assert.That(mago.AttackValue,Is.EqualTo(8));
        Assert.That(mago.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Dwarf enano = new Dwarf("Enano");
        mago.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(92));
        
        mago.EquipItem(arco);
        enano.EquipItem(escudo);
        mago.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(83));
        
        mago.EquipItem(baston);
        mago.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(0));
    }
    
    [Test]
    public void TestCure()
    {
        mago.Health = 0;
        mago.Cure();
        Assert.That(mago.Health, Is.EqualTo(100));
    }
}