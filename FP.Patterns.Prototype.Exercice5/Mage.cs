namespace FP.Patterns.Prototype.Exercice5
{
    public class Mage : Character
    {
        public Mage(string name, string equipment)
        {
            Name = name;
            Equipment = equipment;
            Type = "Mage";
        }

        public override Character Clone()
        {
            return (Mage)this.MemberwiseClone();
        }
    }
}
