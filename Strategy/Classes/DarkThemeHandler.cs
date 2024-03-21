namespace Strategy.Classes
{
    internal class DarkThemeHandler : IColorTheme
    {
        public void ApplyColorTheme(Control control)
        {
            control.BackColor = Color.Black;
            control.ForeColor = Color.DarkGreen;
        }
    }
}
