namespace Composite.Classes
{
    internal class Product(string name, Category category) : ISearch
    {
        public string Name { get; } = name;

        public Category Category { get; } = category;

        public bool Search(string input, List<ISearch> result)
        {
            if (Name.Contains(input, StringComparison.CurrentCultureIgnoreCase) && !result.Contains(this))
            {
                result.Add(this);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}