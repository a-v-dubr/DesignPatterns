namespace Strategy.Classes
{
    internal class LightThemeHandler : IColorTheme
    {
        public void ApplyColorTheme(Control control)
        {
            control.BackColor = Color.LightCyan;
            control.ForeColor = Color.Black;
        }
    }
}
