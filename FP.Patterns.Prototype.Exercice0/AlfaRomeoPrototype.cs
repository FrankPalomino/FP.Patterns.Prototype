namespace FP.Patterns.Prototype
{
    public class AlfaRomeoPrototype : AutoPrototype
    {
        public override AutoPrototype Clone() => (AlfaRomeoPrototype)this.MemberwiseClone();

        public override string GetInfo() => $"AlfaRomeo {_model} color {_color}";
    }
}
