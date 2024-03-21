using Flyweight.Classes;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        private readonly HeaderTemplatesFactory _factory = new();
        private IHeaderTemplate? _template;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonToDoListClick(object sender, EventArgs e)
        {
            SetToDoListTemplate();
            DisplayUserInputTextBox();
        }


        private void OnButtonBirthdayClick(object sender, EventArgs e)
        {
            SetBirthdayLabelTemplate();
            DisplayUserInputTextBox();
        }

        private void DisplayUserInputTextBox()
        {
            _label.Text = "Введите данные в текстовом поле";
            _buttonBirthday.Visible = _buttonToDoList.Visible = false;

            _textBox.Visible = _buttonCreateTemplate.Visible = true;
        }

        private void OnButtonCreateTemplateClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_textBox.Text) && _template is not null)
            {
                _textBox.Visible = _buttonCreateTemplate.Visible = _label.Visible = false;

                var document = new Document(_template, _textBox.Text);
                document.Render(this);
            }
        }

        private void SetBirthdayLabelTemplate()
        {
            var birthdayFont = new Font("Segoe Script", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            var text = "С днём рождения!";
            _template = _factory.GetTemplateLabel(birthdayFont, text);
        }

        private void SetToDoListTemplate()
        {
            var toDoListFont = new Font("Courier New", 11F, FontStyle.Underline, GraphicsUnit.Point, 0);
            var text = "Список дел";
            _template = _factory.GetTemplateLabel(toDoListFont, text);
        }
    }
}
