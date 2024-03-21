using ChainOfResponsibility.Classes.Domain;

namespace ChainOfResponsibility.Classes.PurchaseHandler
{
    internal class FreeDeliveryPurchaseHandler : IPurchaseHandler
    {
        public const decimal MinAmountForFreeDelivery = 10000;
        private IPurchaseHandler? _nextHandler = default;

        public void ProcessPurchase(Purchase purchase)
        {
            if (purchase.Amount >= MinAmountForFreeDelivery)
            {
                purchase.SetFreeDelivery();
            }

            _nextHandler?.ProcessPurchase(purchase);
        }

        public void SetNext(IPurchaseHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
