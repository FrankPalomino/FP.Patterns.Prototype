
// Create base characters
using FP.Patterns.Prototype.Exercice5;

Character warrior = new Warrior("Aragorn", "Sword and Shield");
Character mage = new Mage("Gandalf", "Staff");
Character archer = new Archer("Legolas", "Bow and Arrows");

// Clone characters to create new instances
Character clonedWarrior = warrior.Clone();
clonedWarrior.Name = "Boromir"; // Modify the clone's name

Character clonedMage = mage.Clone();
clonedMage.Name = "Saruman"; // Modify the clone's name
clonedMage.Equipment = "Dark Staff"; // Modify the clone's equipment

Character clonedArcher = archer.Clone();
clonedArcher.Name = "Tauriel"; // Modify the clone's name

// Display original and cloned characters
Console.WriteLine("Original Characters:");
Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(archer);

Console.WriteLine("\nCloned Characters:");
Console.WriteLine(clonedWarrior);
Console.WriteLine(clonedMage);
Console.WriteLine(clonedArcher);

Console.ReadLine(); // Keep console window open