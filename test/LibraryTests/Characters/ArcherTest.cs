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
        escudo = new Shield("Escudo");
        arco = new Bow("Arco");
        baston = new Staff("Baston");
    }
    

    [Test]
    public void TestEquipItem()
    {
        arquero.EquipItem(escudo);
        Assert.That(arquero.Items.Count, Is.EqualTo(3));
        Assert.That(arquero.Items.Contains(escudo));
        
        arquero.EquipItem(arco);
        Assert.That(arquero.Items.Count, Is.EqualTo(4));
        Assert.That(arquero.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        arquero.EquipItem(escudo);
        Assert.That(arquero.DefenseValue,Is.EqualTo(32));
        
        arquero.EquipItem(arco);
        Assert.That(arquero.AttackValue,Is.EqualTo(40));
        
        arquero.EquipItem(baston);
        Assert.That(arquero.DefenseValue,Is.EqualTo(132));
        Assert.That(arquero.AttackValue,Is.EqualTo(140));
    }
    
    [Test]
    public void TestUnEquipItem(){
        arquero.UnEquipItem("Casco predeterminado");
        Assert.That(arquero.Items.Count, Is.EqualTo(1));
        
        arquero.UnEquipItem("Arco predeterminado");
        Assert.That(arquero.Items.Count, Is.EqualTo(1));
        
        arquero.EquipItem(escudo);
        arquero.UnEquipItem(escudo);
        Assert.That(!arquero.Items.Contains(escudo));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        arquero.EquipItem(baston);
        
        arquero.UnEquipItem("Casco predeterminado");
        Assert.That(arquero.DefenseValue,Is.EqualTo(100));
        
        arquero.UnEquipItem("Arco predeterminado");
        Assert.That(arquero.AttackValue,Is.EqualTo(110));
        
        arquero.UnEquipItem("Baston");
        Assert.That(arquero.AttackValue,Is.EqualTo(10));
        Assert.That(arquero.DefenseValue,Is.EqualTo(0));
    }

    [Test]
    public void TestAttack()
    {
        Wizard mago = new Wizard("Mago");
        arquero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(70));
        
        
        mago.EquipItem(escudo);
        arquero.Attack(mago);
        Assert.That(mago.Health, Is.EqualTo(59));
        
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
    
    [Test]
    public void TestNegativeHealth()
    {
        arquero.TakeDamage(1000);
        Assert.That(arquero.Health, Is.EqualTo(0));
        
        arquero.TakeDamage(118);
        Assert.That(arquero.Health, Is.EqualTo(0));
    }
}