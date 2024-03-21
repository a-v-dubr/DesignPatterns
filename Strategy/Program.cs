namespace Strategy
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
            // реализовать смену светлой и тёмной тем элементов управления в форме 

            // ИМПЛЕМЕНТАЦИЯ STRATEGY:
            // клиент взаимодействует с контекстом, передавая ему объект выбранной конкретной стратегии 
            // стратегия может быть определена и заменена в рантайм
            // клиент не знает деталей имплементации стpатегий (т.е. контекст pаботает ещё и как фасад)

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}