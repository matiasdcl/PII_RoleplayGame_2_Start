using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(LightningBolt))]
public class LightningBoltTest
{

    [Test]
    public void TestGetName()
    {
        LightningBolt lightningBolt = new LightningBolt();
        Assert.That(lightningBolt.Name,Is.EqualTo("Lightning Bolt"));
    }
    
    [Test]
    public void TestGetAttackValue()
    {
        LightningBolt lightningBolt = new LightningBolt();
        Assert.That(lightningBolt.AttackValue,Is.EqualTo(100)); 
    }
    
    [Test]
    public void TestGetDefenseValue()
    {
        LightningBolt lightningBolt = new LightningBolt();
        Assert.That(lightningBolt.DefenseValue,Is.EqualTo(0));
    }
}