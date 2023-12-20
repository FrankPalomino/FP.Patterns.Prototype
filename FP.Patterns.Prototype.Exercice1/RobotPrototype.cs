namespace FP.Patterns.Prototype.Exercice1
{
    internal abstract class RobotPrototype
    {
        public string Form { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public string SpecialSkills { get; set; }
        public abstract RobotPrototype Clone();
    }
}
