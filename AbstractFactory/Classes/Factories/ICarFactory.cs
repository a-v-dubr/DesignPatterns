using AbstractFactory.Classes.Domain;

namespace AbstractFactory.Classes.Factories
{
    internal interface ICarFactory
    {
        Sedan CreateSedan();
        Coupe CreateCoupe();
    }
}
