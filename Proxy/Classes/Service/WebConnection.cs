using Proxy.Classes.Proxy;

namespace Proxy.Classes.Service
{
    internal class WebConnection : IWebConnection
    {
        public void Connect(string host)
        {
            Console.WriteLine($"Successfully connected to {host}");
        }
    }
}
