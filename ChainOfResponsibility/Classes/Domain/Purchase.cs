namespace ChainOfResponsibility.Classes.Domain
{
    internal class Purchase
    {
        public List<Product> Products { get; private set; } = [];

        public decimal Amount { get; private set; }

        public bool HasFreeDelivery { get; private set; }

        public bool HasPartnerBonus { get; private set; }

        public Purchase() { }

        public Purchase(List<Product> products, bool hasFreeDelivery = false, bool hasPartnerBonus = false)
        {
            Products = products;
            SetAmount(products);
            HasFreeDelivery = hasFreeDelivery;
            HasPartnerBonus = hasPartnerBonus;
        }

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
                Amount += product.Price;
            }
        }

        public void SetFreeDelivery()
        {
            HasFreeDelivery = true;
        }

        public void AddPartnerBonus()
        {
            HasPartnerBonus = true;
        }

        private void SetAmount(List<Product> products)
        {
            Amount = products.Sum(p => p.Price);
        }
    }
}
