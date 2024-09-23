using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Buff))]
public class BuffTest
{

    [Test]
    public void TestGetName()
    {
        Buff buff = new Buff();
        Assert.That(buff.Name,Is.EqualTo("Hechizo Buffeador"));
    }
    
    [Test]
    public void TestGetAttackValue()
    {
        Buff buff = new Buff();
        Assert.That(buff.AttackValue,Is.EqualTo(70));
    }
    
    [Test]
    public void TestGetDefenseValue()
    {
        Buff buff = new Buff();
        Assert.That(buff.DefenseValue,Is.EqualTo(70));
    }
}