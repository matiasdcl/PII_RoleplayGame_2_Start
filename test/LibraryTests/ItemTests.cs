using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
namespace TestLibrary;

public class ItemTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Bow()
    {
        string BowName = "magic bow";
        Bow MagicBow = new Bow(BowName);
        Assert.That(BowName,Is.EqualTo(MagicBow.Name));
        Assert.That(15,Is.EqualTo(MagicBow.AttackValue));
    }

    [Test]
    public void Sword()
    {
        string SwordName = "iron sword";
        Sword IronSword = new Sword(SwordName);
        Assert.That(SwordName,Is.EqualTo(IronSword.Name));
        Assert.That(20,Is.EqualTo(IronSword.AttackValue));
    }

    [Test]
    public void Axe()
    {
        string AxeName = "stone axe";
        Axe StoneAxe = new Axe(AxeName);
        Assert.That(AxeName,Is.EqualTo(StoneAxe.Name));
        Assert.That(25,Is.EqualTo(StoneAxe.AttackValue));
    }

    [Test]
    public void Armor()
    {
        string ArmorName = "stone axe";
        Armor GoldenArmor = new Armor(ArmorName);
        Assert.That(ArmorName,Is.EqualTo(GoldenArmor.Name));
        Assert.That(25,Is.EqualTo(GoldenArmor.DefenseValue));
    }

    [Test]
    public void Helmet()
    {
        string HelmetName = "red helmet";
        Helmet RedHelmet = new Helmet(HelmetName);
        Assert.That(HelmetName,Is.EqualTo(RedHelmet.Name));
        Assert.That(18,Is.EqualTo(RedHelmet.DefenseValue));
    }

    [Test]
    public void Shield()
    {
        string ShieldName = "heavy shield";
        Shield BigShield = new Shield(ShieldName);
        Assert.That(ShieldName,Is.EqualTo(BigShield.Name));
        Assert.That(14,Is.EqualTo(BigShield.DefenseValue));
    }

    [Test]
    public void Staff()
    {
        string StaffName = "magic powerful staff";
        Staff OPstaff = new Staff(StaffName);
        Assert.That(StaffName,Is.EqualTo(OPstaff.Name));
        Assert.That(100,Is.EqualTo(OPstaff.AttackValue));
        Assert.That(100,Is.EqualTo(OPstaff.DefenseValue));
    }

}
