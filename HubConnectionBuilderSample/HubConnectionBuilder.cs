namespace HubConnectionBuilderSample
{
    public class HubConnectionBuilder
    {
        private string _connectionName;
        private string _url;
        private bool _useHttps;
        private int _timeout;
        private string _authenticationToken;


        public HubConnectionBuilder WithConnectionName(string connectionName)
        {
            _connectionName = connectionName;
            return this;
        }
        public HubConnectionBuilder WithUrl(string url)
        {
            _url = url;
            return this;
        }
        public HubConnectionBuilder UseHttps(bool https=true)
        {
            _useHttps = https; 
            return this;
            
        }
        public HubConnectionBuilder WithTimeout(int timeout)
        {
            _timeout = timeout; return this;
        }
        public HubConnectionBuilder WithAuthenticationToken(string authenticationToken)
        {
            _authenticationToken = authenticationToken;
            return this;
        }
        public   HubConnection Build()
        {
            return new HubConnection(_connectionName,_url,_useHttps,_timeout,_authenticationToken);
        }
    }
}
