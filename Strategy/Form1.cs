using Strategy.Classes;

namespace Strategy
{
    public partial class Form1 : Form
    {
        private readonly Context _colorThemeContext;

        public Form1()
        {
            InitializeComponent();
            _colorThemeContext = new();
        }
        private void OnButtonChangeThemeClick(object sender, EventArgs e)
        {
            if (_colorThemeContext.ColorTheme is LightThemeHandler)
            {
                _colorThemeContext.SetColorTheme(new DarkThemeHandler());
            }
            else
            {
                _colorThemeContext.SetColorTheme(new LightThemeHandler());
            }
            foreach (Control control in Controls)
            {
                _colorThemeContext.ApplyColorTheme(control);
            }
        }
    }
}
