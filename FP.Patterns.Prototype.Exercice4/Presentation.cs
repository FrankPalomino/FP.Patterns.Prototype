namespace FP.Patterns.Prototype.Exercice4
{
    public class Presentation : Document
    {
        public Presentation(string type, string text) : base(type, text)
        {
        }

        public Presentation(ICloneable cloneable) : base(cloneable) { }
    }
}
