namespace FP.Patterns.Prototype.Exercice5
{
    public class Warrior : Character
    {
        public Warrior(string name, string equipment)
        {
            Name = name;
            Type = "Warrior";
            Equipment = equipment;
        }

        public override Character Clone()
        {
            return (Warrior)this.MemberwiseClone();
        }
    }
}
