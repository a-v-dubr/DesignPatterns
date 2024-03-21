using AbstractFactory.Classes.Domain;

namespace AbstractFactory.Classes.Factories
{
    internal class ToyotaFactory : ICarFactory
    {
        public Coupe CreateCoupe()
        {
            return new ToyotaCoupe();
        }

        public Sedan CreateSedan()
        {
            return new ToyotaSedan();
        }
    }
}
