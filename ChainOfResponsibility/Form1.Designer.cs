namespace ChainOfResponsibility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _checkedListBoxProducts = new CheckedListBox();
            _labelChooseProducts = new Label();
            _buttonAcceptPurchase = new Button();
            _labelPurchaseSum = new Label();
            _buttonAcceptProductsChoice = new Button();
            _labelAmountBonuses = new Label();
            SuspendLayout();
            // 
            // _checkedListBoxProducts
            // 
            _checkedListBoxProducts.FormattingEnabled = true;
            _checkedListBoxProducts.Location = new Point(12, 42);
            _checkedListBoxProducts.Name = "_checkedListBoxProducts";
            _checkedListBoxProducts.Size = new Size(300, 114);
            _checkedListBoxProducts.TabIndex = 0;
            // 
            // _labelChooseProducts
            // 
            _labelChooseProducts.AutoSize = true;
            _labelChooseProducts.Location = new Point(12, 9);
            _labelChooseProducts.Name = "_labelChooseProducts";
            _labelChooseProducts.Size = new Size(136, 20);
            _labelChooseProducts.TabIndex = 1;
            _labelChooseProducts.Text = "Выберите товары:";
            // 
            // _buttonAcceptPurchase
            // 
            _buttonAcceptPurchase.Location = new Point(9, 222);
            _buttonAcceptPurchase.Name = "_buttonAcceptPurchase";
            _buttonAcceptPurchase.Size = new Size(203, 29);
            _buttonAcceptPurchase.TabIndex = 4;
            _buttonAcceptPurchase.Text = "Заказать";
            _buttonAcceptPurchase.UseVisualStyleBackColor = true;
            _buttonAcceptPurchase.Visible = false;
            _buttonAcceptPurchase.Click += OnButtonAcceptPurchaseClick;
            // 
            // _labelPurchaseSum
            // 
            _labelPurchaseSum.AutoSize = true;
            _labelPurchaseSum.Location = new Point(9, 199);
            _labelPurchaseSum.Name = "_labelPurchaseSum";
            _labelPurchaseSum.Size = new Size(111, 20);
            _labelPurchaseSum.TabIndex = 5;
            _labelPurchaseSum.Text = "Сумма заказа: ";
            _labelPurchaseSum.Visible = false;
            // 
            // _buttonAcceptProductsChoice
            // 
            _buttonAcceptProductsChoice.Location = new Point(12, 162);
            _buttonAcceptProductsChoice.Name = "_buttonAcceptProductsChoice";
            _buttonAcceptProductsChoice.Size = new Size(201, 29);
            _buttonAcceptProductsChoice.TabIndex = 6;
            _buttonAcceptProductsChoice.Text = "Подтвердить выбор";
            _buttonAcceptProductsChoice.UseVisualStyleBackColor = true;
            _buttonAcceptProductsChoice.Click += OnButtonAcceptProductsChoiceClick;
            // 
            // _labelAmountBonuses
            // 
            _labelAmountBonuses.AutoSize = true;
            _labelAmountBonuses.Location = new Point(331, 43);
            _labelAmountBonuses.Name = "_labelAmountBonuses";
            _labelAmountBonuses.Size = new Size(0, 20);
            _labelAmountBonuses.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 303);
            Controls.Add(_labelAmountBonuses);
            Controls.Add(_buttonAcceptProductsChoice);
            Controls.Add(_labelPurchaseSum);
            Controls.Add(_buttonAcceptPurchase);
            Controls.Add(_labelChooseProducts);
            Controls.Add(_checkedListBoxProducts);
            Name = "Form1";
            Text = "Оформление заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox _checkedListBoxProducts;
        private Label _labelChooseProducts;
        private Button _buttonAcceptPurchase;
        private Label _labelPurchaseSum;
        private Button _buttonAcceptProductsChoice;
        private Label _labelAmountBonuses;
    }
}
