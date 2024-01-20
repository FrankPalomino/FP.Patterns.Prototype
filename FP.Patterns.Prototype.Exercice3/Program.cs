using FP.Patterns.Prototype.Exercice3;

WarriorCharacter warriorPrototype = new WarriorCharacter("Warrior", "Armor", 2);
MageCharacter magePrototype = new MageCharacter("Mage", "Cape", 5);

CharacterRegistry characterRegistry = new CharacterRegistry();
characterRegistry.AddPrototype(warriorPrototype);
characterRegistry.AddPrototype(magePrototype);

var mage = characterRegistry.GetCharacter("mage");
Console.WriteLine(mage.ToString());

var warrior = characterRegistry.GetCharacter("warrior");
Console.WriteLine(warrior.ToString());