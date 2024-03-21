namespace ChainOfResponsibility
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
            // при формировании заказа последовательно обновить свойства заказа в зависимости от общей суммы или стоимости отдельных
            // товаров: добавить бесплатную доставку, гарантию, бонус от партнёра

            // ИМПЛЕМЕНТАЦИЯ CHAIN OF RESPONSIBILITY:
            // методы классов IPurchaseHandler обновляют свойства объекта Purchase, относящиеся к их ответственности, и затем
            // вызывают следующий обработчик; порядок вызова обработчиков задан снаружи 

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}