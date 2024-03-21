using ChainOfResponsibility.Classes.Domain;

namespace ChainOfResponsibility.Classes.PurchaseHandler
{
    internal class ExtendedWarrantyPurchaseHandler : IPurchaseHandler
    {
        public const decimal MinAmountForExtendedWarranty = 5000;
        private IPurchaseHandler? _nextHandler = default;

        public void ProcessPurchase(Purchase purchase)
        {
            if (purchase.Products.Exists(p => p.Price >= ExtendedWarrantyPurchaseHandler.MinAmountForExtendedWarranty))
            {
                var productsWithExtendedWarranty = purchase.Products.Where(p => p.Price >= ExtendedWarrantyPurchaseHandler.MinAmountForExtendedWarranty);
                foreach (Product p in productsWithExtendedWarranty)
                {
                    p.ExtendWarranty();
                }
            }

            _nextHandler?.ProcessPurchase(purchase);
        }

        public void SetNext(IPurchaseHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
