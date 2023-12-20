namespace FP.Patterns.Prototype.Exercice2
{
    public class Presentation : IDocumentPrototype
    {
        public string Month { get; set; } = "Enero";
        public string Description { get; set; } = "Presentación";

        public IDocumentPrototype Clone() => (Presentation)this.MemberwiseClone();
    }
}
