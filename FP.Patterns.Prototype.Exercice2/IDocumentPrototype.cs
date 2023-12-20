namespace FP.Patterns.Prototype.Exercice2
{
    public interface IDocumentPrototype
    {
        public string Month { get; set; }
        public string Description { get; set; }
        IDocumentPrototype Clone();
    }
}
