using FP.Patterns.Prototype.Exercice1;

RobotPrototype waterPrototype = new WaterRobot();
RobotPrototype firePrototype = new FireRobot();

var waterRobot1 = waterPrototype.Clone();
waterRobot1.Size = 10;

var waterRobot2 = waterPrototype.Clone();
waterRobot2.Size = 20;

var fireRobot1 = firePrototype.Clone();
fireRobot1.Size = 30;
var fireRobot2 = firePrototype.Clone();
fireRobot2.Size = 40;

Console.WriteLine($"Water Robot 1: {waterRobot1.Form} {waterRobot1.Color} {waterRobot1.SpecialSkills} {waterRobot1.Size}");
Console.WriteLine($"Water Robot 2: {waterRobot2.Form} {waterRobot2.Color} {waterRobot2.SpecialSkills} {waterRobot2.Size}");
Console.WriteLine($"Fire Robot 1: {fireRobot1.Form} {fireRobot1.Color} {fireRobot1.SpecialSkills} {fireRobot1.Size}");
Console.WriteLine($"Fire Robot 2: {fireRobot2.Form} {fireRobot2.Color} {fireRobot2.SpecialSkills} {fireRobot2.Size}");


