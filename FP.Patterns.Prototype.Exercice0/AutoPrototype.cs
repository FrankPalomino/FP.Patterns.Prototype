namespace FP.Patterns.Prototype
{
    public abstract class AutoPrototype
    {
        protected string _color;
        protected string _model;

        public string Color { set => _color = value; }

        public string Model { set => _model = value; }

        public abstract AutoPrototype Clone();

        public abstract string GetInfo();
    }
}
