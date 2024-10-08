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
        escudo = new Shield("Escudo");
        arco = new Bow("Arco");
        baston = new Staff("Baston");
    }
    

    [Test]
    public void TestEquipItem()
    {
        caballero.EquipItem(escudo);
        Assert.That(caballero.Items.Count, Is.EqualTo(4));
        Assert.That(caballero.Items.Contains(escudo));
        
        caballero.EquipItem(arco);
        Assert.That(caballero.Items.Count, Is.EqualTo(5));
        Assert.That(caballero.Items.Contains(arco));
    }
    
    [Test]
    public void TestEquipItemStats()
    {
        caballero.EquipItem(escudo);
        Assert.That(caballero.DefenseValue,Is.EqualTo(53));
        
        caballero.EquipItem(arco);
        Assert.That(caballero.AttackValue,Is.EqualTo(43));
        
        caballero.EquipItem(baston);
        Assert.That(caballero.DefenseValue,Is.EqualTo(153));
        Assert.That(caballero.AttackValue,Is.EqualTo(143));
    }
    
    [Test]
    public void TestUnEquipItem(){
        caballero.UnEquipItem("Espada predeterminada");
        Assert.That(caballero.Items.Count, Is.EqualTo(2));
        
        caballero.UnEquipItem("Escudo predeterminado");
        Assert.That(caballero.Items.Count, Is.EqualTo(1));

        caballero.UnEquipItem("Armadura predeterminada");
        Assert.That(caballero.Items.Count, Is.EqualTo(0));
        
        caballero.EquipItem(escudo);
        caballero.UnEquipItem("Escudo");
        Assert.That(!caballero.Items.Contains(escudo));
    }

    [Test]
    public void TestUnEquipeItemStats()
    {
        caballero.EquipItem(baston);
        
        caballero.UnEquipItem("Escudo");
        Assert.That(caballero.DefenseValue,Is.EqualTo(139));
        
        caballero.UnEquipItem("Espada predeterminada");
        Assert.That(caballero.AttackValue,Is.EqualTo(108));
        
        caballero.UnEquipItem("Baston");
        Assert.That(caballero.AttackValue,Is.EqualTo(8));
        Assert.That(caballero.DefenseValue,Is.EqualTo(39));
    }

    [Test]
    public void TestAttack()
    {
        Dwarf enano = new Dwarf("Enano");
        caballero.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(100));
        
        enano.EquipItem(escudo);
        caballero.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(100));
        
        caballero.EquipItem(baston);
        caballero.Attack(enano);
        Assert.That(enano.Health, Is.EqualTo(18));
    }
    
    [Test]
    public void TestCure()
    {
        caballero.TakeDamage(1000);
        caballero.Cure();
        Assert.That(caballero.Health, Is.EqualTo(100));
    }
    
    [Test]
    public void TestTakeDamage()
    {
        caballero.TakeDamage(1000);
        Assert.That(caballero.Health, Is.EqualTo(0));
        
        caballero.TakeDamage(134);
        Assert.That(caballero.Health, Is.EqualTo(0));
    }
}