using Proxy.Classes.Service;

namespace Proxy.Classes.Proxy
{
    internal class WebConnectionProxy
    {
        private readonly WebConnection _webConnection;

        private readonly List<string> _restrictedSites = ["restricted.com", "restricted.ru"];

        public WebConnectionProxy()
        {
            _webConnection = new();
        }

        public void Connect(string host)
        {
            if (AccessIsAllowed(host))
            {
                _webConnection.Connect(host);
            }
            else
            {
                Console.WriteLine($"Access to {host} denied");
            }
        }

        private bool AccessIsAllowed(string host)
        {
            return !_restrictedSites.Exists(host.Contains);
        }
    }
}
