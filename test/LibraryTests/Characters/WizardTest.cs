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
        escudo = new Shield("Escudo");
        arco = new Bow("Arco");
        baston = new Staff("Baston");
    }
    
    

    [Test]
    public void TestEquipItem()
    {
        mago.EquipItem(escudo);
        Assert.That(mago.Items.Count, Is.EqualTo(3));
        Assert.That(mago.Items.Contains(escudo));
        
        mago.EquipItem(arco);
        Assert.That(mago.Items.Count, Is.EqualTo(4));
        Assert.That(mago.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        mago.EquipItem(escudo);
        Assert.That(mago.DefenseValue,Is.EqualTo(114));
        
        mago.EquipItem(arco);
        Assert.That(mago.AttackValue,Is.EqualTo(123));
        
        mago.EquipItem(baston);
        Assert.That(mago.DefenseValue,Is.EqualTo(214));
        Assert.That(mago.AttackValue,Is.EqualTo(223));
    }
    
    [Test]
    public void TestUnEquipItem(){
        mago.UnEquipItem("Baston predeterminado");
        Assert.That(mago.Items.Count, Is.EqualTo(1));
        
        mago.UnEquipItem("Libro predeterminado");
        Assert.That(mago.Items.Count, Is.EqualTo(0));
        
        mago.EquipItem(escudo);
        mago.UnEquipItem("Escudo");
        Assert.That(!mago.Items.Contains(escudo));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        mago.EquipItem(baston);
        
        mago.UnEquipItem("Baston predeterminado");
        Assert.That(mago.DefenseValue,Is.EqualTo(100));
        
        mago.UnEquipItem("Libro predeterminado");
        Assert.That(mago.AttackValue,Is.EqualTo(108));
        
        mago.UnEquipItem("Baston");
        Assert.That(mago.AttackValue,Is.EqualTo(8));
        Assert.That(mago.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Dwarf enano = new Dwarf("Enano");
        mago.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(0));
        
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
        mago.TakeDamage(1000);
        mago.Cure();
        Assert.That(mago.Health, Is.EqualTo(100));
    }
    
    [Test]
    public void TestNegativeHealth()
    {
        mago.TakeDamage(1000);
        Assert.That(mago.Health, Is.EqualTo(0));
        
        mago.TakeDamage(132);
        Assert.That(mago.Health, Is.EqualTo(0));
    }
}