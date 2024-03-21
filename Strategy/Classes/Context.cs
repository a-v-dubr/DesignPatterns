namespace Strategy.Classes
{
    internal class Context
    {
        public IColorTheme ColorTheme { get; private set; }
        private readonly IColorTheme _defaultColorTheme = new LightThemeHandler();

        public Context()
        {
            ColorTheme = _defaultColorTheme;
        }

        public void SetColorTheme(IColorTheme theme)
        {
            ColorTheme = theme;
        }

        public void ApplyColorTheme(Control control)
        {
            ColorTheme.ApplyColorTheme(control);
        }
    }
}
