namespace Flyweight
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
            _label = new Label();
            _buttonBirthday = new Button();
            _buttonToDoList = new Button();
            _textBox = new TextBox();
            _buttonCreateTemplate = new Button();
            SuspendLayout();
            // 
            // _label
            // 
            _label.AutoSize = true;
            _label.Location = new Point(25, 13);
            _label.Name = "_label";
            _label.Size = new Size(176, 20);
            _label.TabIndex = 0;
            _label.Text = "Выберите тип шаблона:";
            // 
            // _buttonBirthday
            // 
            _buttonBirthday.Location = new Point(25, 81);
            _buttonBirthday.Name = "_buttonBirthday";
            _buttonBirthday.Size = new Size(285, 29);
            _buttonBirthday.TabIndex = 1;
            _buttonBirthday.Text = "Поздравление с днём рождения";
            _buttonBirthday.UseVisualStyleBackColor = true;
            _buttonBirthday.Click += OnButtonBirthdayClick;
            // 
            // _buttonToDoList
            // 
            _buttonToDoList.Location = new Point(25, 46);
            _buttonToDoList.Name = "_buttonToDoList";
            _buttonToDoList.Size = new Size(285, 29);
            _buttonToDoList.TabIndex = 2;
            _buttonToDoList.Text = "Список дел";
            _buttonToDoList.UseVisualStyleBackColor = true;
            _buttonToDoList.Click += OnButtonToDoListClick;
            // 
            // _textBox
            // 
            _textBox.Location = new Point(25, 49);
            _textBox.Multiline = true;
            _textBox.Name = "_textBox";
            _textBox.Size = new Size(285, 218);
            _textBox.TabIndex = 3;
            _textBox.Visible = false;
            // 
            // _buttonCreateTemplate
            // 
            _buttonCreateTemplate.Location = new Point(28, 278);
            _buttonCreateTemplate.Name = "_buttonCreateTemplate";
            _buttonCreateTemplate.Size = new Size(282, 29);
            _buttonCreateTemplate.TabIndex = 4;
            _buttonCreateTemplate.Text = "Создать шаблон";
            _buttonCreateTemplate.UseVisualStyleBackColor = true;
            _buttonCreateTemplate.Visible = false;
            _buttonCreateTemplate.Click += OnButtonCreateTemplateClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 416);
            Controls.Add(_buttonCreateTemplate);
            Controls.Add(_textBox);
            Controls.Add(_buttonToDoList);
            Controls.Add(_buttonBirthday);
            Controls.Add(_label);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _label;
        private Button _buttonBirthday;
        private Button _buttonToDoList;
        private TextBox _textBox;
        private Button _buttonCreateTemplate;
    }
}
