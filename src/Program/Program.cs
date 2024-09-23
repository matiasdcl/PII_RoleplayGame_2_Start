using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook("libro");

Wizard gandalf = new Wizard("Gandalf");

Dwarf gimli = new Dwarf("Gimli");


Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

