namespace FP.Patterns.Prototype.Exercice4
{
    public class Contract : Document
    {
        public Contract(string type, string text) : base(type, text)
        {
        }

        public Contract(ICloneable cloneable) : base(cloneable) { }
    }
}
