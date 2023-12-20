namespace FP.Patterns.Prototype.Exercice1
{
    internal class FireRobot : RobotPrototype
    {
        public FireRobot()
        {
            Form = "Fire";
            Color = "Red";
            SpecialSkills = "Firebomb";
        }

        public override RobotPrototype Clone() => (FireRobot)this.MemberwiseClone();
    }
}
