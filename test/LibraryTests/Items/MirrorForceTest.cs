using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(MirrorForce))]
public class MirrorForceTest
{

    [Test]
    public void TestGetName()
    {
        MirrorForce mirrorForce = new MirrorForce();
        Assert.That(mirrorForce.Name,Is.EqualTo("Mirror Force"));
    }
    
    [Test]
    public void TestGetAttackValue()
    {
        MirrorForce mirrorForce = new MirrorForce();
        Assert.That(mirrorForce.AttackValue,Is.EqualTo(0));
    }
    
    [Test]
    public void TestGetDefenseValue()
    {
        MirrorForce mirrorForce = new MirrorForce();
        Assert.That(mirrorForce.DefenseValue,Is.EqualTo(150));
    }
}