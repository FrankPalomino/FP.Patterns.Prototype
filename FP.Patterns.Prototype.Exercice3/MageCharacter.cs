namespace FP.Patterns.Prototype.Exercice3
{
    public class MageCharacter : Character
    {
        public MageCharacter(string hairStyle, string clothing, int accessories)
        {
            HairStyle = hairStyle;
            Clothing = clothing;
            Accessories = accessories;
        }
        public override ICloneable Clone() => (MageCharacter)this.MemberwiseClone();
    }
}
