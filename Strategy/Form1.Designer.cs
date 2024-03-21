namespace Strategy
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
            _changeColorThemeButton = new Button();
            _flowLayoutPanel = new FlowLayoutPanel();
            _label = new Label();
            _textBox = new TextBox();
            _buttonApplyRandomFont = new Button();
            _resultLabel = new Label();
            _flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _changeColorThemeButton
            // 
            _changeColorThemeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _changeColorThemeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _changeColorThemeButton.Location = new Point(9, 8);
            _changeColorThemeButton.Margin = new Padding(9, 8, 9, 38);
            _changeColorThemeButton.Name = "_changeColorThemeButton";
            _changeColorThemeButton.Size = new Size(143, 28);
            _changeColorThemeButton.TabIndex = 0;
            _changeColorThemeButton.Text = "Изменить тему";
            _changeColorThemeButton.UseVisualStyleBackColor = true;
            _changeColorThemeButton.Click += OnButtonChangeThemeClick;
            // 
            // _flowLayoutPanel
            // 
            _flowLayoutPanel.Controls.Add(_changeColorThemeButton);
            _flowLayoutPanel.Controls.Add(_textBox);
            _flowLayoutPanel.Controls.Add(_buttonApplyRandomFont);
            _flowLayoutPanel.Controls.Add(_label);
            _flowLayoutPanel.Controls.Add(_resultLabel);
            _flowLayoutPanel.Dock = DockStyle.Fill;
            _flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            _flowLayoutPanel.Location = new Point(0, 0);
            _flowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            _flowLayoutPanel.Name = "_flowLayoutPanel";
            _flowLayoutPanel.RightToLeft = RightToLeft.No;
            _flowLayoutPanel.Size = new Size(220, 182);
            _flowLayoutPanel.TabIndex = 1;
            // 
            // _label
            // 
            _label.AutoSize = true;
            _label.Location = new Point(3, 149);
            _label.Name = "_label";
            _label.Size = new Size(0, 15);
            _label.TabIndex = 3;
            // 
            // _textBox
            // 
            _textBox.Location = new Point(9, 82);
            _textBox.Margin = new Padding(9, 8, 9, 8);
            _textBox.Multiline = true;
            _textBox.Name = "_textBox";
            _textBox.PlaceholderText = "Type text";
            _textBox.Size = new Size(143, 21);
            _textBox.TabIndex = 1;
            // 
            // _buttonApplyRandomFont
            // 
            _buttonApplyRandomFont.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _buttonApplyRandomFont.Location = new Point(9, 119);
            _buttonApplyRandomFont.Margin = new Padding(9, 8, 9, 8);
            _buttonApplyRandomFont.Name = "_buttonApplyRandomFont";
            _buttonApplyRandomFont.Size = new Size(143, 22);
            _buttonApplyRandomFont.TabIndex = 2;
            _buttonApplyRandomFont.Text = "Button";
            _buttonApplyRandomFont.UseVisualStyleBackColor = true;
            // 
            // _resultLabel
            // 
            _resultLabel.AutoSize = true;
            _resultLabel.Location = new Point(170, 8);
            _resultLabel.Margin = new Padding(9, 8, 9, 8);
            _resultLabel.Name = "_resultLabel";
            _resultLabel.Size = new Size(0, 15);
            _resultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 182);
            Controls.Add(_flowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            _flowLayoutPanel.ResumeLayout(false);
            _flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Button _changeColorThemeButton;
        private FlowLayoutPanel _flowLayoutPanel;
        private TextBox _textBox;
        private Button _buttonApplyRandomFont;
        private Label _label;
        private Label _resultLabel;
    }
}
