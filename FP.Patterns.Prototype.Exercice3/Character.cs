namespace FP.Patterns.Prototype.Exercice3
{
    public abstract class Character : ICloneable
    {
        public string? HairStyle { get; set; }
        public string? Clothing {  get; set; }
        public int Accessories { get; set; }

        public abstract ICloneable Clone();

        public override string ToString()
        {
            return $"Character: has {HairStyle} hair style, {Clothing} of clothing and {Accessories} accessories.";
        }
    }
}
