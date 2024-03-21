namespace ChainOfResponsibility.Classes.Domain
{
    internal class Product(string name, decimal price, bool hasExtendedWarranty = false)
    {
        public string Name { get; } = name;

        public decimal Price { get; } = price;

        public bool HasExtendedWarranty { get; private set; } = hasExtendedWarranty;

        public void ExtendWarranty()
        {
            HasExtendedWarranty = true;
        }

        public override string ToString()
        {
            return $"{Name} (цена {Price})";
        }
    }
}
