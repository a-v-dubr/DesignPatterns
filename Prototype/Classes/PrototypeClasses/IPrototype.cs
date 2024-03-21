namespace Prototype.PrototypeClasses
{
    internal interface IPrototype
    {
        IPrototype DeepClone();
        IPrototype ShallowClone();
    }
}
