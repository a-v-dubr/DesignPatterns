using ChainOfResponsibility.Classes.Domain;

namespace ChainOfResponsibility.Classes.PurchaseHandler
{
    internal class PartnerBonusHandler : IPurchaseHandler
    {
        public const decimal MinAmountForPartnerBonus = 1000;
        private IPurchaseHandler? _nextHandler = default;

        public void ProcessPurchase(Purchase purchase)
        {
            if (purchase.Amount >= MinAmountForPartnerBonus)
            {
                purchase.AddPartnerBonus();
            }

            _nextHandler?.ProcessPurchase(purchase);
        }

        public void SetNext(IPurchaseHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
