using System.Diagnostics;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(SpellsBook))]
public class SpellsBookTest
{

    [Test]
    public void TestGetName()
    {
        SpellsBook spells = new SpellsBook("Libro inicial");
        Assert.That(spells.Name,Is.EqualTo("Libro inicial"));
    }
    
    [Test]
    public void TestGetAttackValue()
    {
        SpellsBook spells = new SpellsBook("Libro inicial");
        Assert.That(spells.AttackValue, Is.EqualTo(0));
        LightningBolt lightningBolt = new LightningBolt();
        spells.AddSpell(lightningBolt);
        Assert.That(spells.AttackValue, Is.EqualTo(100));
    }
    
    [Test]
    public void TestGetDefenseValue()
    {
        SpellsBook spells = new SpellsBook("Libro inicial");
        Assert.That(spells.DefenseValue,Is.EqualTo(0));
        MirrorForce mirrorForce = new MirrorForce();
        spells.AddSpell(mirrorForce);
        Assert.That(spells.DefenseValue, Is.EqualTo(150));
    }
    
    [Test]
    public void TestAddSpell()
    {
        SpellsBook spells = new SpellsBook("Libro inicial");
        Buff buff = new Buff();
        spells.AddSpell(buff);
        Assert.That(spells.spells.Contains(buff));
    }

    [Test] public void TestGetMagic()
    {
        SpellsBook spells = new SpellsBook("Libro inicial");
        Assert.That(spells.Magic,Is.EqualTo(true));
    }
}