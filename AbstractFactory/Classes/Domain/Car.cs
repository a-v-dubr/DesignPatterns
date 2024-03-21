namespace AbstractFactory.Classes.Domain
{
    internal abstract class Car
    {
        public abstract string Name { get; }

        public override string ToString() => Name;
    }
}
