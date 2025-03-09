namespace HubConnectionBuilderSample
{
    public class HubConnection
    {
        public string ConnectionName { get; }
        public string Url { get; }
        public bool UseHttps { get; }
        public int Timeout { get; }
        public string AuthenticationToken { get; }

        public HubConnection(string connectionName, string url, bool useHttps, int timeout, string authenticationToken)
        {
            ConnectionName = connectionName;
            Url = url;
            UseHttps = useHttps;
            Timeout = timeout;
            AuthenticationToken = authenticationToken;
        }

        public void Connect()
        {
            Console.WriteLine($"Connecting to {Url} with name {ConnectionName}, using HTTPS: {UseHttps}");
        }
    
    }
}
