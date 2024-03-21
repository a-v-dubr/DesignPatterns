using ChainOfResponsibility.Classes.Data;
using ChainOfResponsibility.Classes.Domain;
using ChainOfResponsibility.Classes.PurchaseHandler;

namespace ChainOfResponsibility
{
    public partial class Form1 : Form
    {
        private Purchase? _purchase;

        public Form1()
        {
            InitializeComponent();
            DisplayPurchaseTerms();
        }

        private void OnButtonAcceptProductsChoiceClick(object sender, EventArgs e)
        {
            var chosenProducts = GetChosenProducts();
            if (chosenProducts.Count == 0)
            {
                DisplayNoProductSelectedToolTip();
            }
            else
            {
                _purchase = new(chosenProducts);
                DisplayPurchaseDataPreview();
            }
        }

        private void OnButtonAcceptPurchaseClick(object sender, EventArgs e)
        {
            HandlePurchaseAdditions();
            DisplayPurchaseResult();
        }

        private void HandlePurchaseAdditions()
        {
            var bonusHandler = new PartnerBonusHandler();
            var warrantyHandler = new ExtendedWarrantyPurchaseHandler();
            var freeDeliveryHandler = new FreeDeliveryPurchaseHandler();

            bonusHandler.SetNext(warrantyHandler);
            warrantyHandler.SetNext(freeDeliveryHandler);

            bonusHandler.ProcessPurchase(_purchase!);
        }

        private List<Product> GetChosenProducts()
        {
            var chosenProducts = new List<Product>();
            for (int i = 0; i < _checkedListBoxProducts.Items.Count; i++)
            {
                if (_checkedListBoxProducts.GetItemChecked(i) && _checkedListBoxProducts.Items[i] is Product p)
                {
                    chosenProducts.Add(p);
                }
            }
            return chosenProducts;
        }

        private void DisplayPurchaseResult()
        {
            foreach (Control c in Controls)
            {
                c.Visible = false;
            }

            var resultLabel = new Label()
            {
                AutoSize = true,
                Location = new Point(16, 20),
                Text = GetPurchaseSummary(),
            };

            Controls.Add(resultLabel);
        }

        private string GetPurchaseSummary()
        {
            string products = string.Join("\n", _purchase!.Products);
            string partnerBonus = _purchase.HasPartnerBonus ? "\n+ бонус от партнёров" : "";

            var productsWithExtendedWarranty = _purchase.Products.Where(p => p.Price >= ExtendedWarrantyPurchaseHandler.MinAmountForExtendedWarranty);
            string extendedWarranty = productsWithExtendedWarranty.Any() ? "\n+ увеличенная гарантия на " + string.Join(", ", productsWithExtendedWarranty) : "";

            string freeDelivery = _purchase.HasFreeDelivery ? "\n+ бесплатная доставка" : "";

            return $"Ваш заказ:\n{products}\n\nСумма: {_purchase.Amount}{partnerBonus}{extendedWarranty}{freeDelivery}";
        }

        private void DisplayPurchaseDataPreview()
        {
            _checkedListBoxProducts.Enabled = _buttonAcceptProductsChoice.Enabled = _labelChooseProducts.Enabled = false;
            _labelPurchaseSum.Text += _purchase!.Amount.ToString();
            _labelPurchaseSum.Visible = true;
            _buttonAcceptPurchase.Visible = true;
        }

        private void DisplayNoProductSelectedToolTip()
        {
            var toolTip = new ToolTip();
            toolTip.Show("Не выбран ни один товар", _checkedListBoxProducts, _checkedListBoxProducts.Width, 0, 2000);
        }

        private void DisplayPurchaseTerms()
        {
            _checkedListBoxProducts.Items.AddRange(Products.GetProducts().ToArray());
            _labelAmountBonuses.Text = $"Бонус от партнёра для заказа от {PartnerBonusHandler.MinAmountForPartnerBonus}" +
                $"\nБесплатное продление гарантии на товары от {ExtendedWarrantyPurchaseHandler.MinAmountForExtendedWarranty}" +
                $"\nБесплатная доставка заказа от {FreeDeliveryPurchaseHandler.MinAmountForFreeDelivery}";
        }
    }
}


