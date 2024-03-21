using Composite.Classes;

namespace Composite.Data
{
    public static class CatalogueContents
    {
        internal static Category GetCatalogue()
        {
            var result = new Category("Каталог");

            var firstLevelCategory1 = new Category("Светильники");
            var firstLevelCategory2 = new Category("Лампы");

            var secondLevelCategory1 = new Category("Светильники панельные");
            var secondLevelCategory2 = new Category("Светильники трековые");
            var secondLevelCategory3 = new Category("Лампы светодиодные");

            var product1 = new Product("Светильник LED 36Вт 4000К 595x595x19мм IP40 ЭРА", secondLevelCategory1);
            var product2 = new Product("Светильник трековый 16W 1680lm 4000K Gauss", secondLevelCategory2);
            var product3 = new Product("Лампа LED Свеча Е14 8Вт 3000К Osram", secondLevelCategory3);
            var product4 = new Product("Лампа LED Шар Е27 8Вт 4100К Gauss", secondLevelCategory3);

            secondLevelCategory1.AddItems(product1);
            secondLevelCategory2.AddItems(product2);
            secondLevelCategory3.AddItems(product3, product4);

            firstLevelCategory1.AddItems(secondLevelCategory1, secondLevelCategory2);
            firstLevelCategory2.AddItems(secondLevelCategory3);

            result.AddItems(firstLevelCategory1, firstLevelCategory2);

            return result;
        }
    }
}
