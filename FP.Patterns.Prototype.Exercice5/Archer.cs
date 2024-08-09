namespace FP.Patterns.Prototype.Exercice5
{
    public class Archer : Character
    {
        public Archer(string name, string equipment) 
        {
            Name = name;
            Equipment = equipment;
            Type = "Archer";
        }

        public override Character Clone()
        {
            return (Archer)this.MemberwiseClone();
        }
    }
}
