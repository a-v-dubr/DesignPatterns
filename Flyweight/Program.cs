namespace Flyweight
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ЗАДАЧА:
            // создавать документы с одинаковым внутренним состоянием (шаблоном-хедером) и получаемым от юзера внешним (тело документа)
            // таким образом, чтобы переиспользовать шаблонную часть, а не создавать каждый раз новый объект

            // ИМПЛЕМЕНТАЦИЯ FLYWEIGHT:
            // повторяющиеся значения (текст хедера, шрифт, флоу панель) вынесены в отдельный класс, объект которого является
            // свойством Document; объекты IHeaderTemplate создаются и кешируются с помощью фабрики

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}