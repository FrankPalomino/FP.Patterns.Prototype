namespace FP.Patterns.Prototype.Exercice4
{
    public class Report : Document
    {
        public Report(string type, string text) : base(type, text){ }

        public Report(ICloneable cloneable) : base(cloneable) { }
    }
}
