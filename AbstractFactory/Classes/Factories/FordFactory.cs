using AbstractFactory.Classes.Domain;

namespace AbstractFactory.Classes.Factories
{
    internal class FordFactory : ICarFactory
    {
        public Coupe CreateCoupe()
        {
            return new FordCoupe();
        }

        public Sedan CreateSedan()
        {
            return new FordSedan();
        }
    }
}
