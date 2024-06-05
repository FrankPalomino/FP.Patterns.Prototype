namespace FP.Patterns.Prototype.Exercice4
{
    public class Document : ICloneable
    {
        private readonly string _type;
        private readonly string _text;
        public Document(string type, string text)
        {
            _text = text;
            _type = type;
        }

        public Document(ICloneable clon)
        {
            _type = clon.GetTypes();
            _text = clon.GetText();
        }
        public ICloneable Clone()
        {
            return new Document(this);
        }

        public string GetTypes() {  return _type; }
        public string GetText() { return _text; }

        public void Show()
        {
            Console.WriteLine($"Type of document:{_type}\nText:{_text}");
        }
    }
}
