namespace FP.Patterns.Prototype.Exercice5
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Equipment { get; set; }

        public abstract Character Clone();

        public override string ToString()
        {
            return $"Character Type: {Type}, Name: {Name}, Equipment: {Equipment}";
        }
    }
}
