using ChainOfResponsibility.Classes.Domain;

namespace ChainOfResponsibility.Classes.Data
{
    internal static class Products
    {
        public static List<Product> GetProducts()
        {
            return [new("Монитор", 30000),
                new("Клавиатура", 5000),
                new("Наушники", 3000),
                new("Настольная лампа", 1000),
                new("Пауэрбанк", 1500)];
        }
    }
}
