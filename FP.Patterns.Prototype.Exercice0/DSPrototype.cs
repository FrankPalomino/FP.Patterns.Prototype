namespace FP.Patterns.Prototype
{
    public class DSPrototype : AutoPrototype
    {
        public override AutoPrototype Clone() => (DSPrototype)this.MemberwiseClone();

        public override string GetInfo() => $"DS {_model} color {_color}";
    }
}
