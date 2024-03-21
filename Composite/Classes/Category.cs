using System.Collections;

namespace Composite.Classes
{
    internal class Category(string name) : ISearch, IEnumerable<ISearch>
    {
        public string Name { get; } = name;

        public List<ISearch> Contents = [];

        public void AddItems(params ISearch[] items)
        {
            foreach (var i in items)
            {
                if (!Contents.Exists(c => c.Name == i.Name))
                {
                    Contents.Add(i);
                }
            }
        }

        public void RemoveItems(params ISearch[] items)
        {
            foreach (var i in items.Where(i => Contents.Contains(i)))
            {
                Contents.Remove(i);
            }
        }

        public bool Search(string input, List<ISearch> result)
        {
            bool matchFound = false;

            if (Name.Contains(input, StringComparison.CurrentCultureIgnoreCase) && !result.Contains(this))
            {
                result.Add(this);
                matchFound = true;
            }

            foreach (var c in Contents.Where(c => c.Search(input, result)))
            {
                matchFound = true;
            }

            return matchFound;
        }

        public override string ToString()
        {
            return Name;
        }

        public IEnumerator<ISearch> GetEnumerator()
        {
            return Contents.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var c in Contents)
            {
                yield return c;
            }
        }
    }
}
