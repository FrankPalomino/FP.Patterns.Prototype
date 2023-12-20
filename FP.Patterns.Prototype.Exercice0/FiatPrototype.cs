namespace FP.Patterns.Prototype
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clone() => (FiatPrototype)this.MemberwiseClone();

        public override string GetInfo() => $"Fiat {_model} color {_color}";

    }
}
