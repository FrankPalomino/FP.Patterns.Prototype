namespace FP.Patterns.Prototype.Exercice2
{
    public class Report : IDocumentPrototype
    {
        public string Month { get; set; } = "Enero";
        public string Description { get; set; } = "Reporte";
        public IDocumentPrototype Clone() => (Report)this.MemberwiseClone();
    }
}
