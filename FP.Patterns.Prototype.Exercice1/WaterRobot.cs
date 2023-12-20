namespace FP.Patterns.Prototype.Exercice1
{
    internal class WaterRobot : RobotPrototype
    {
        public WaterRobot()
        {
            Form = "Water";
            Color = "Blue";
            SpecialSkills = "Waterbomb";
        }

        public override RobotPrototype Clone() => (WaterRobot)this.MemberwiseClone();
    }
}
