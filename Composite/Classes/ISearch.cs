namespace Composite.Classes
{
    internal interface ISearch
    {
        string Name { get; }
        bool Search(string input, List<ISearch> result);
    }
}
