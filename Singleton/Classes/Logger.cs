namespace Singleton.Classes
{
    internal class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new();
        public readonly List<string> LogEntries = [];

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    _instance ??= new Logger();
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            LogEntries.Add(logEntry);
            Console.WriteLine(logEntry);
        }
    }
}
