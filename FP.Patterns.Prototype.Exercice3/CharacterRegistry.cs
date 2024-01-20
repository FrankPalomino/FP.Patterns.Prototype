namespace FP.Patterns.Prototype.Exercice3
{
    public class CharacterRegistry
    {
        public List<Character> CharacterList = new List<Character>();

        public void AddPrototype(Character character)
        {
            CharacterList.Add(character);
        }

        public ICloneable GetCharacter(string type)
        {
            ICloneable prototype = default;
            switch (type)
            {
                case "mage":
                    prototype = CharacterList.Find(x => x is MageCharacter);
                    break;
                case "warrior":
                    prototype = CharacterList.Find(x => x is WarriorCharacter);
                    break;
            }

            if (prototype is not null)
            {
                return prototype.Clone();
            }

            return prototype;
        }
    }
}
