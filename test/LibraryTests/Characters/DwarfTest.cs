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
        escudo = new Shield("Escudo");
        arco = new Bow("Arco");
        baston = new Staff("Baston");
    }
    
    [Test]
    public void TestEquipItem()
    {
        enano.EquipItem(escudo);
        Assert.That(enano.Items.Count, Is.EqualTo(4));
        Assert.That(enano.Items.Contains(escudo));
        
        enano.EquipItem(arco);
        Assert.That(enano.Items.Count, Is.EqualTo(5));
        Assert.That(enano.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        enano.EquipItem(escudo);
        Assert.That(enano.DefenseValue,Is.EqualTo(46));
        
        enano.EquipItem(arco);
        Assert.That(enano.AttackValue,Is.EqualTo(52));
        
        enano.EquipItem(baston);
        Assert.That(enano.DefenseValue,Is.EqualTo(146));
        Assert.That(enano.AttackValue,Is.EqualTo(152));
    }
    
    [Test]
    public void TestUnEquipItem(){
        
        enano.UnEquipItem("Hacha predeterminada");
        Assert.That(enano.Items.Count, Is.EqualTo(2));
        
        enano.UnEquipItem("Escudo predeterminado");
        Assert.That(enano.Items.Count, Is.EqualTo(1));
        
        enano.EquipItem(escudo);
        enano.UnEquipItem("Escudo");
        Assert.That(!enano.Items.Contains(escudo));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        enano.EquipItem(baston);
        
        enano.UnEquipItem("Escudo predeterminado");
        Assert.That(enano.DefenseValue,Is.EqualTo(118));
        
        enano.UnEquipItem("Hacha predeterminada");
        Assert.That(enano.AttackValue,Is.EqualTo(112));
        
        enano.UnEquipItem("Baston");
        Assert.That(enano.AttackValue,Is.EqualTo(12));
        Assert.That(enano.DefenseValue,Is.EqualTo(18));
    }

    [Test]
    public void TestAttack()
    {
        Wizard mago = new Wizard("Mago");
        enano.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(58));
        
        mago.EquipItem(escudo);
        enano.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(35));
        
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
    
    [Test]
    public void TestNegativeHealth()
    {
        enano.TakeDamage(1000);
        Assert.That(enano.Health, Is.EqualTo(0));
        
        enano.TakeDamage(132);
        Assert.That(enano.Health, Is.EqualTo(0));
    }
}