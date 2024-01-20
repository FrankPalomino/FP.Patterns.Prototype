namespace FP.Patterns.Prototype.Exercice3
{
    internal class WarriorCharacter : Character
    {
        public WarriorCharacter(string hairStyle, string clothing, int accessories)
        {
            HairStyle = hairStyle;
            Clothing = clothing;
            Accessories = accessories;
        }
        public override ICloneable Clone() => (WarriorCharacter)this.MemberwiseClone();
    }
}
